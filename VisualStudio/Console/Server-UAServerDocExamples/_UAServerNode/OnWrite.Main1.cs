﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable ConvertClosureToMethodGroup
// ReSharper disable LocalizableElement
// ReSharper disable PossibleNullReferenceException
#region Example
// This example shows how to define a custom folder class which implements writing to its data variables.
// You can use any OPC UA client, including our Connectivity Explorer and OpcCmd utility, to connect to the server. 
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client, server and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-OPCStudio-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using OpcLabs.BaseLib.NodeSpace;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.NodeSpace;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UAServerDocExamples._UAServerNode
{
    class OnWrite
    {
        /// <summary>
        /// A folder in the OPC UA address space, with specialized write behavior.
        /// </summary>
        class FolderWithOnWrite : UAFolder
        {
            public FolderWithOnWrite(string name) : base(name)
            {
            }

            /// <summary>
            /// Processes the supplied OPC UA write data.
            /// </summary>
            /// <param name="e">The event arguments.</param>
            protected override void OnWrite(UADataVariableWriteEventArgs e)
            {
                // Obtain the state associated with the data variable that is being written, and display it on the console
                // together with the new value.
                Console.WriteLine($"Data variable {e.DataVariable.State}, value written: {e.AttributeData.Value}");
            }
        }

        public static void Main1()
        {
            // Instantiate the server object.
            // By default, the server will run on endpoint URL "opc.tcp://localhost:48040/".
            var server = new EasyUAServer();

            // Create a folder node.
            var myFolder = new FolderWithOnWrite("MyFolder");
            server.Add(myFolder);

            // Create data variables in the folder. Distinguish them by their state.
            myFolder.Add(new UADataVariable("MyDataVariable1").ValueType<int>().SetState(1));
            myFolder.Add(new UADataVariable("MyDataVariable2").ValueType<int>().SetState(2));
            myFolder.Add(new UADataVariable("MyDataVariable3").ValueType<int>().SetState(3));
            myFolder.Add(new UADataVariable("MyDataVariable4").ValueType<int>().SetState(4));
            myFolder.Add(new UADataVariable("MyDataVariable5").ValueType<int>().SetState(5));

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
