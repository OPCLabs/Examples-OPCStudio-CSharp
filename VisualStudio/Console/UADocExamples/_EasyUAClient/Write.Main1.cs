﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

#region Example
// This example shows how to write data (a value, timestamps and status code) into a single attribute of a node.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    class Write
    {
        public static void Main1()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Instantiate the client object.
            var client = new EasyUAClient();

            Console.WriteLine("Modifying data of a node's attribute...");
            try
            {
                client.Write(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10221",
                    new UAAttributeData(12345, UASeverity.GoodOrSuccess, DateTime.UtcNow));

                // The target server may not support this, and in such case a failure will occur.
            }
            catch (UAException uaException)
            {
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}");
                return;
            }

            Console.WriteLine("Finished.");
        }
    }
}
#endregion
