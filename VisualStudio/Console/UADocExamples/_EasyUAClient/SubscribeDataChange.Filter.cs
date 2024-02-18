﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement
// ReSharper disable InconsistentNaming
// ReSharper disable PossibleNullReferenceException
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
#region Example
// This example shows how to subscribe to changes of a monitored item with data change filter.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    partial class SubscribeDataChange
    {
        public static void Filter()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Instantiate the client object and hook events.
            var client = new EasyUAClient();
            client.DataChangeNotification += client_DataChangeNotification_Filter;

            Console.WriteLine("Subscribing...");
            // Report a notification if either the StatusCode or the value change. 
            // The UADataChangeTrigger has an implicit conversion to UADataChangeFilter and can thus be used in its place.
            client.SubscribeDataChange(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853", 1000, 
                dataChangeFilter:UADataChangeTrigger.StatusValue);

            Console.WriteLine("Processing data change events for 20 seconds...");
            System.Threading.Thread.Sleep(20 * 1000);

            Console.WriteLine("Unsubscribing...");
            client.UnsubscribeAllMonitoredItems();

            Console.WriteLine("Waiting for 5 seconds...");
            System.Threading.Thread.Sleep(5 * 1000);

            Console.WriteLine("Finished.");
        }

        static void client_DataChangeNotification_Filter(object sender, EasyUADataChangeNotificationEventArgs e)
        {
            // Display value.
            if (e.Succeeded)
                Console.WriteLine($"Value: {e.AttributeData.Value}");
            else
                Console.WriteLine($"*** Failure: {e.ErrorMessageBrief}");
        }
    }
}
#endregion
