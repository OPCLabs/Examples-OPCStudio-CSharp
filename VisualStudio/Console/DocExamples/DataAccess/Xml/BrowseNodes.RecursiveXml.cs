﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable AssignNullToNotNullAttribute
#region Example
// This example shows how to recursively browse the nodes in the OPC XML-DA address space.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Diagnostics;
using OpcLabs.EasyOpc;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.AddressSpace;
using OpcLabs.EasyOpc.OperationModel;

namespace DocExamples.DataAccess.Xml
{
    class BrowseNodes
    {
        public static void RecursiveXml()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // Instantiate the client object.
            var client = new EasyDAClient();

            _branchCount = 0;
            _leafCount = 0;

            try
            {
                BrowseFromNode(client, "http://opcxml.demo-this.com/XmlDaSampleServer/Service.asmx", "");
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }

            stopwatch.Stop();
            Console.WriteLine("Browsing has taken (milliseconds): {0}", stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Branch count: {0}", _branchCount);
            Console.WriteLine("Leaf count: {0}", _leafCount);
        }

        private static void BrowseFromNode(
            EasyDAClient client,
            ServerDescriptor serverDescriptor,
            DANodeDescriptor parentNodeDescriptor)
        {
            Debug.Assert(client != null);
            Debug.Assert(serverDescriptor != null);
            Debug.Assert(parentNodeDescriptor != null);

            // Obtain all node elements under parentNodeDescriptor
            var browseParameters = new DABrowseParameters();    // no filtering whatsoever
            DANodeElementCollection nodeElementCollection =
                client.BrowseNodes(serverDescriptor, parentNodeDescriptor, browseParameters);
            // Remark: that BrowseNodes(...) may also throw OpcException; a production code should contain handling for 
            // it, here omitted for brevity.

            foreach (DANodeElement nodeElement in nodeElementCollection)
            {
                Debug.Assert(nodeElement != null);

                Console.WriteLine(nodeElement);

                // If the node is a branch, browse recursively into it.
                if (nodeElement.IsBranch)
                {
                    _branchCount++;
                    BrowseFromNode(client, serverDescriptor, nodeElement);
                }
                else
                {
                    _leafCount++;
                }
            }
        }

        private static int _branchCount;
        private static int _leafCount;
    }
}
#endregion
