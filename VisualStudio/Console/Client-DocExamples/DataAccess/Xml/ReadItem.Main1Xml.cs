﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
// ReSharper disable CheckNamespace
#region Example 
// This example shows how to read a single item, and display its value, timestamp and quality.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.OperationModel;

namespace DocExamples.DataAccess.Xml
{
    partial class ReadItem
    {
        public static void Main1Xml()
        {
            // Instantiate the client object.
            var client = new EasyDAClient();

            DAVtq vtq;
            try
            {
                vtq = client.ReadItem("http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "Dynamic/Analog Types/Int");
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }

            Console.WriteLine("Vtq: {0}", vtq);
        }
    }
}
#endregion
