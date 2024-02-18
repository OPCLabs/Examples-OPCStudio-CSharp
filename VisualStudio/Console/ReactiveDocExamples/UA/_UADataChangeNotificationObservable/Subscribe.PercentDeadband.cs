﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable PossibleNullReferenceException
#region Example
// Shows how to observe OPC UA data changes with a specified percent deadband.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using OpcLabs.EasyOpc.UA.Reactive;
using System;
using System.Threading;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace ReactiveDocExamples
{
    namespace _UADataChangeNotificationObservable
    {
        partial class Subscribe
        {
            public static void PercentDeadband()
            {
                // Define which server we will work with.
                UAEndpointDescriptor endpointDescriptor =
                    "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
                // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
                // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

                const double percentDeadband = 5.0;
                Console.WriteLine($"Creating observable with  {percentDeadband}% deadband...");
                var attributeArguments = new UAAttributeArguments(
                    endpointDescriptor,
                    "nsu=http://test.org/UA/Data/ ;i=11194");    // /Data.Dynamic.AnalogScalar.Int32Value
                var monitoredItemArguments = new UAMonitoredItemArguments(
                    attributeArguments,
                    new UAMonitoringParameters(
                        samplingInterval: 1000, 
                        new UADataChangeFilter(UADeadbandType.Percent, percentDeadband)));
                UADataChangeNotificationObservable<int> observable =
                    UADataChangeNotificationObservable.Create<int>(monitoredItemArguments);

                Console.WriteLine("Subscribing...");
                using (observable.Subscribe(e => Console.WriteLine(
                    (e.Exception is null) ? e.AttributeData.ToString() : e.Exception.GetBaseException().ToString())))
                {
                    Console.WriteLine("Waiting for 10 seconds...");
                    Thread.Sleep(10*1000);

                    Console.WriteLine("Unsubscribing...");
                }

                Console.WriteLine("Waiting for 2 seconds...");
                Thread.Sleep(2 * 1000);
            }
        }
    }
}
#endregion
