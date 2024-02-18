﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement
#region Example
// This example shows how to read and display data of an attribute (value, timestamps, and status code).
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    partial class Read
    {
        public static void Main1()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Instantiate the client object.
            var client = new EasyUAClient();

            // Obtain attribute data. By default, the Value attribute of a node will be read.
            UAAttributeData attributeData;
            try
            {
                attributeData = client.Read(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853");
            }
            catch (UAException uaException)
            {
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}");
                return;
            }

            // Display results
            Console.WriteLine($"Value: {attributeData.Value}");
            Console.WriteLine($"ServerTimestamp: {attributeData.ServerTimestamp}");
            Console.WriteLine($"SourceTimestamp: {attributeData.SourceTimestamp}");
            Console.WriteLine($"StatusCode: {attributeData.StatusCode}");

            // Example output:
            //
            //Value: -2.230064E-31
            //ServerTimestamp: 11/6/2011 1:34:30 PM
            //SourceTimestamp: 11/6/2011 1:34:30 PM
            //StatusCode: Good
        }
    }
}
#endregion
