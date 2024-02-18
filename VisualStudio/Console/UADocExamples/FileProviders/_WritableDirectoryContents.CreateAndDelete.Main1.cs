﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable CheckNamespace
// ReSharper disable AssignNullToNotNullAttribute
#region Example
// Shows how to create and delete OPC UA directories, using the file provider model.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.BaseLib.Extensions.FileProviders;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Extensions;
using OpcLabs.EasyOpc.UA.FileTransfer;

namespace UADocExamples.FileProviders._WritableDirectoryContents
{
    class CreateAndDelete
    {
        public static void Main1()
        {
            // Unified Automation .NET based demo server (UaNETServer/UaServerNET.exe)
            var endpointDescriptor = new UAEndpointDescriptor("opc.tcp://localhost:48030")
                .WithUserNameIdentity("john", "master");

            // A node that represents an OPC UA file system (a root directory).
            UANodeDescriptor fileSystemNodeDescriptor = "nsu=http://www.unifiedautomation.com/DemoServer/ ;s=Demo.Files.FileSystem";

            // Create a random number generator - will be used for file/directory names.
            var random = new Random();
            
            // Instantiate the file transfer client object
            var fileTransferClient = new EasyUAFileTransferClient();

            Console.WriteLine("Getting writable file provider...");
            IWritableFileProvider writableFileProvider =
                fileTransferClient.GetWritableFileProvider(endpointDescriptor, fileSystemNodeDescriptor);
            // From this point onwards, the code is independent of the concrete realization of the file provider, and would
            // be identical e.g. for files in the physical file system, if the corresponding file provider was used.

            // Create two directories, and one nested directory, and delete the first one.
            try
            {
                string directoryName1 = "MyDirectory1-" + random.Next();
                Console.WriteLine($"Creating first directory, '{directoryName1}'...");
                IWritableDirectoryContents writableDirectoryContents1 = writableFileProvider.GetWritableDirectoryContents(directoryName1);
                writableDirectoryContents1.Create();

                string directoryName2 = "MyDirectory2-" + random.Next();
                Console.WriteLine($"Creating second directory, '{directoryName2}'...");
                IWritableDirectoryContents writableDirectoryContents2 = writableFileProvider.GetWritableDirectoryContents(directoryName2);
                writableDirectoryContents2.Create();

                string nestedDirectoryName = "MyDirectory3-" + random.Next();
                Console.WriteLine($"Creating nested directory, '{nestedDirectoryName}'...");
                writableDirectoryContents2.CreateSubdirectory(nestedDirectoryName);

                // At this moment, the directory structure we have created looks like this:
                // * MyDirectory1
                // * MyDirectory2
                // * * MyDirectory3

                Console.WriteLine("Deleting the first directory...");
                writableDirectoryContents1.Delete();
            }
            // Methods in the file provider model throw IOException and other exceptions, but not UAException.
            catch (Exception exception)
            {
                Console.WriteLine($"*** Failure: {exception.GetBaseException().Message}");
                return;
            }

            Console.WriteLine("Finished...");
        }
    }
}
#endregion
