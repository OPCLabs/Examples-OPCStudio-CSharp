﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable CheckNamespace
// ReSharper disable AssignNullToNotNullAttribute
#region Example
// Shows how to read the full contents of an OPC UA file at once, using the file transfer client.
// Note: Consider using a higher-level abstraction, OPC UA file provider, instead.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.IO;
using System.Text;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.FileTransfer;
using OpcLabs.EasyOpc.UA.IO.Extensions;

namespace UADocExamples.FileTransfer._EasyUAFileTransferClient
{
    class ReadAllBytes
    {
        public static void Main1()
        {
            // Unified Automation .NET based demo server (UaNETServer/UaServerNET.exe)
            UAEndpointDescriptor endpointDescriptor = "opc.tcp://localhost:48030";

            // A node that represents an instance of OPC UA FileType object.
            UANodeDescriptor fileNodeDescriptor = "nsu=http://www.unifiedautomation.com/DemoServer/ ;s=Demo.Files.TextFile";
            
            // Instantiate the file transfer client object
            var fileTransferClient = new EasyUAFileTransferClient();

            // Read in all contents from a specified file node.
            byte[] bytes;
            try
            {
                Console.WriteLine("Reading the whole file...");
                bytes = fileTransferClient.ReadAllBytes(endpointDescriptor, fileNodeDescriptor);
            }
            // Beware that ReadAllFileBytes throws IOException and not UAException.
            catch (IOException ioException)
            {
                Console.WriteLine("*** Failure: {0}", ioException.GetBaseException().Message);
                return;
            }

            // Display result
            Console.WriteLine();
            // We know that the file contains text, so we convert the received data to a string. If the file contents was
            // binary, you would process the data according to their format.
            string text = Encoding.UTF8.GetString(bytes);
            Console.WriteLine("File content:");
            Console.WriteLine(text);

            Console.WriteLine();
            Console.WriteLine("Finished...");
        }
    }
}
#endregion
