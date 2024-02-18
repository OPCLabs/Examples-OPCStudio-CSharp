﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
// ReSharper disable LocalizableElement
#region Example
// This example shows how to read a value of a specific attribute of a single node, and display it.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    partial class ReadValue
    {
        public static void Overload2()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            UANodeDescriptor nodeDescriptor = "nsu=http://test.org/UA/Data/ ;i=10853";

            // Instantiate the client object
            var client = new EasyUAClient();

            // Obtain value of a DataType attribute
            object value;
            try
            {
                value = client.ReadValue(endpointDescriptor, nodeDescriptor, UAAttributeId.DataType);
            }
            catch (UAException uaException)
            {
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}");
                return;
            }

            // Display results
            Console.WriteLine($"value type: {value?.GetType()}");
            Console.WriteLine($"value: {value}");
        }
    }
}
#endregion
