﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement
// ReSharper disable InconsistentNaming
#region Example
// This example shows how to obtain parameters of certain monitored item subscription.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    class GetMonitoredItemArguments
    {
        public static void Main1()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Instantiate the client object and hook events.
            var client = new EasyUAClient();
            client.DataChangeNotification += client_DataChangeNotification;

            Console.WriteLine("Subscribing...");
            int[] handleArray = client.SubscribeMultipleMonitoredItems(new[]
                {
                    new EasyUAMonitoredItemArguments(null, endpointDescriptor, 
                        "nsu=http://test.org/UA/Data/ ;i=10845", 1000),
                    new EasyUAMonitoredItemArguments(null, endpointDescriptor, 
                        "nsu=http://test.org/UA/Data/ ;i=10853", 1000),
                    new EasyUAMonitoredItemArguments(null, endpointDescriptor, 
                        "nsu=http://test.org/UA/Data/ ;i=10855", 1000)
                });

            Console.WriteLine("Getting monitored item arguments...");
            EasyUAMonitoredItemArguments monitoredItemArguments =
                client.GetMonitoredItemArguments(handleArray[2]);
            Console.WriteLine($"NodeDescriptor: {monitoredItemArguments.NodeDescriptor}");
            Console.WriteLine($"SamplingInterval: {monitoredItemArguments.MonitoringParameters.SamplingInterval}");
            Console.WriteLine($"PublishingInterval: {monitoredItemArguments.SubscriptionParameters.PublishingInterval}");

            Console.WriteLine("Waiting for 5 seconds...");
            System.Threading.Thread.Sleep(5 * 1000);

            Console.WriteLine("Unsubscribing...");
            client.UnsubscribeAllMonitoredItems();

            Console.WriteLine("Waiting for 5 seconds...");
            System.Threading.Thread.Sleep(5 * 1000);

            Console.WriteLine("Finished.");
        }

        static void client_DataChangeNotification(object sender, EasyUADataChangeNotificationEventArgs e)
        {
            // Your code would do the processing here.
        }


        // Example output:
        //
        //Subscribing...
        //Getting monitored item arguments...
        //NodeDescriptor: NodeId="nsu=http://test.org/UA/Data/ ;i=10855"
        //SamplingInterval: 1000
        //PublishingInterval: 0
        //Waiting for 5 seconds...
        //Unsubscribing...
        //Waiting for 5 seconds...
        //Finished.

    }
}
#endregion
