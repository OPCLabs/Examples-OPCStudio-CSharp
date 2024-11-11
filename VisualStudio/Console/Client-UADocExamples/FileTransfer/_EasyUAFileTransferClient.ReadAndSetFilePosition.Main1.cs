﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable CheckNamespace
// ReSharper disable AssignNullToNotNullAttribute
#region Example
// Shows how to read different sections from an OPC UA file, using the file transfer client.
// Note: Consider using a higher-level abstraction, OPC UA file provider, instead.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.FileTransfer;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples.FileTransfer._EasyUAFileTransferClient
{
    class ReadAndSetFilePosition
    {
        public static void Main1()
        {
            // Unified Automation .NET based demo server (UaNETServer/UaServerNET.exe)
            UAEndpointDescriptor endpointDescriptor = "opc.tcp://localhost:48030";

            // A node that represents an instance of OPC UA FileType object.
            UANodeDescriptor fileNodeDescriptor = "nsu=http://www.unifiedautomation.com/DemoServer/ ;s=Demo.Files.TextFile";
            
            // Instantiate the file transfer client object
            var fileTransferClient = new EasyUAFileTransferClient();

            // Open the file, read two separate sections of it, and close it.
            try
            {
                Console.WriteLine("Opening file...");
                using (UAFileHandle fileHandle = fileTransferClient.OpenFile(endpointDescriptor, fileNodeDescriptor, UAOpenFileModes.Read))
                {
                    Console.WriteLine("Reading first file section...");
                    byte[] bytes1 = fileTransferClient.ReadFile(endpointDescriptor, fileNodeDescriptor, fileHandle, length:16);
                    Console.WriteLine($"First section: {BitConverter.ToString(bytes1)}");

                    Console.WriteLine("Reading second file section...");
                    byte[] bytes2 = fileTransferClient.ReadFile(endpointDescriptor, fileNodeDescriptor, fileHandle, length: 10);
                    Console.WriteLine($"Second section: {BitConverter.ToString(bytes2)}");

                    Console.WriteLine("Setting file position...");
                    fileTransferClient.SetFilePosition(endpointDescriptor, fileNodeDescriptor, fileHandle, position:100);

                    Console.WriteLine("Reading third file section...");
                    byte[] bytes3 = fileTransferClient.ReadFile(endpointDescriptor, fileNodeDescriptor, fileHandle, length: 20);
                    Console.WriteLine($"Third section: {BitConverter.ToString(bytes3)}");

                    Console.WriteLine("Closing file...");
                    fileTransferClient.CloseFile(endpointDescriptor, fileNodeDescriptor, fileHandle);
                }
            }
            catch (UAException uaException)
            {
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message);
                return;
            }

            Console.WriteLine("Finished...");
        }
    }
}
#endregion
