﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable ConvertClosureToMethodGroup
// ReSharper disable LocalizableElement
#region Example
// This example shows how to create a read-write "register" data variable that is a 3-dimensional array.
// You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client, server and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-OPCStudio-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.NodeSpace;

namespace UAServerDocExamples._UADataVariable
{
    partial class ReadWriteValue
    {
        public static void Array3D()
        {
            // Instantiate the server object.
            // By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            var server = new EasyUAServer();

            // Create a 3-dimensional array data variable.
            // The type of the data variable (Int32 3-dimensional array, in this case) is inferred from the initial value.
            server.Add(new UADataVariable("MyVariable").ReadWriteValue(new int[2, 4, 3]));

            // Start the server.
            Console.WriteLine("The server is starting...");
            server.Start();

            Console.WriteLine("The server is started.");
            Console.WriteLine();

            // Let the user decide when to stop.
            Console.WriteLine("Press Enter to stop the server...");
            Console.ReadLine();

            // Stop the server.
            Console.WriteLine("The server is stopping...");
            server.Stop();

            Console.WriteLine("The server is stopped.");
        }
    }
}
#endregion
