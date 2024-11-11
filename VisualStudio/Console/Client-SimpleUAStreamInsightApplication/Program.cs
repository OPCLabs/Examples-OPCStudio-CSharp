﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
#region Example
// This example shows how to create an OPC Unified Architecture data event source, and query it for events carrying even data 
// value.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using System.Diagnostics;
using System.Reactive;
using System.ServiceModel;
using Microsoft.ComplexEventProcessing;
using Microsoft.ComplexEventProcessing.Linq;
using Microsoft.ComplexEventProcessing.ManagementService;
using OpcLabs.EasyOpc.UA.ComplexEventProcessing;
using OpcLabs.EasyOpc.UA.Reactive;

namespace SimpleUAStreamInsightApplication
{
    class Program
    {
        static void Main()
        {
            // Create an embedded StreamInsight server
            //using (var server = Server.Create("Default"))
            using (var server = Server.Create("Instance1"))
            {
                Debug.Assert(server != null);

                // Create a local end point for the server embedded in this program
                var managementService = server.CreateManagementService();
                Debug.Assert(managementService != null);
                var host = new ServiceHost(managementService);
                host.AddServiceEndpoint(typeof(IManagementService), new WSHttpBinding(SecurityMode.Message), 
                    "http://localhost/MyStreamInsightServer");
                host.Open();

                /* The following entities will be defined and available in the server for other clients:
                 * serverApp
                 * serverSource
                 * serverSink
                 * serverProcess
                 */

                // CREATE a StreamInsight APPLICATION in the server
                var myApp = server.CreateApplication("serverApp");

                // DEFINE a simple SOURCE (returns a point event every second)
                var observable = UADataChangeNotificationObservable.Create<int>(
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer",
                    "nsu=http://test.org/UA/Data/ ;i=11017", // Data/Dynamic/UserScalar/Int32Value
                    100);
                var mySource = myApp
                    .DefineObservable(() => observable)
                    .ToPointStreamable(
                        eventArgs => PointEvent.CreateInsert(
                            DateTimeOffset.Now, 
                            (UADataChangeNotificationPayload<int>)eventArgs),
                        AdvanceTimeSettings.StrictlyIncreasingStartTime);

                // DEPLOY the source to the server for clients to use
                mySource.Deploy("serverSource");

                // Compose a QUERY over the source (return every event carrying even data value)
                var myQuery = from e in mySource
                              where e.AttributeDataPayload.Value % 2 == 0
                              select e;

                // DEFINE a simple observer SINK (writes the value to the server console)
                var mySink = myApp.DefineObserver(() => Observer.Create<UADataChangeNotificationPayload<int>>(
                    payload => Console.WriteLine("sink_Server..: {0}", payload)));

                // DEPLOY the sink to the server for clients to use
                mySink.Deploy("serverSink");

                // BIND the query to the sink and RUN it
                var binding = myQuery.Bind(mySink);
                Debug.Assert(binding != null);
                using (/*var proc = */binding.Run("serverProcess"))
                {
                    // Wait for the user stops the server
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine("MyStreamInsightServer is running, press Enter to stop the server");
                    Console.WriteLine("----------------------------------------------------------------");
                    Console.WriteLine(" ");
                    Console.ReadLine();
                }
                host.Close();
            }
        }
    }
}
#endregion
