﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CoVariantArrayConversion
// ReSharper disable PossibleNullReferenceException
// ReSharper disable ConvertIfStatementToConditionalTernaryExpression
#region Example
// This example shows how to write values into 3 nodes at once, specifying a type's full name explicitly. It tests for 
// success of each write and displays the exception message in case of failure.
//
// Reasons for specifying the type explicitly might be:
// - The data type in the server has subtypes, and the client therefore needs to pick the subtype to be written.
// - The data type that the reports is incorrect.
// - Writing with an explicitly specified type is more efficient.
//
// Alternative ways of specifying the type are using the ValueType or ValueTypeCode properties.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.BaseLib.OperationModel;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    partial class WriteMultipleValues
    {
        public static void ValueTypeFullName()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Instantiate the client object.
            var client = new EasyUAClient();

            Console.WriteLine("Modifying values of nodes...");
            OperationResult[] operationResultArray = client.WriteMultipleValues(new[]
                {
                    new UAWriteValueArguments(endpointDescriptor, 
                        "nsu=http://test.org/UA/Data/ ;i=10221", 23456) 
                        {ValueTypeFullName = "System.Int32"},    // here is the type explicitly specified
                    new UAWriteValueArguments(endpointDescriptor,
                        "nsu=http://test.org/UA/Data/ ;i=10226", "This string cannot be converted to Double")
                        {ValueTypeFullName = "System.Double"},    // here is the type explicitly specified
                    new UAWriteValueArguments(endpointDescriptor,
                        "nsu=http://test.org/UA/Data/ ;s=UnknownNode", "ABC")
                        {ValueTypeFullName = "System.String"}    // here is the type explicitly specified
                });

            for (int i = 0; i < operationResultArray.Length; i++)
                if (operationResultArray[i].Succeeded)
                    Console.WriteLine($"Result {i}: success");
                else
                    Console.WriteLine($"Result {i}: {operationResultArray[i].Exception.GetBaseException().Message}");
        }
    }
}
#endregion
