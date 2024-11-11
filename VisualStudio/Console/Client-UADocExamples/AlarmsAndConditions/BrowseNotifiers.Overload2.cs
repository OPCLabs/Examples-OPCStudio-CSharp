﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement
// ReSharper disable PossibleNullReferenceException
// ReSharper disable StringLiteralTypo
#region Example
// This example shows how to browse objects under the "Objects" node and display notifiers.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.AddressSpace;
using OpcLabs.EasyOpc.UA.AddressSpace.Standard;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples.AlarmsAndConditions
{
    class BrowseNotifiers
    {
        public static void Overload2()
        {
            // Start browsing from the "Objects" node.
            try
            {
                BrowseFrom(UAObjectIds.ObjectsFolder);
            }
            catch (UAException uaException)
            {
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}");
            }

            Console.WriteLine();
            Console.WriteLine("Finished.");
        }

        private static void BrowseFrom(UANodeDescriptor nodeDescriptor)
        {
            // Define which server we will work with.
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Parent node: {nodeDescriptor}");

            // Instantiate the client object.
            var client = new EasyUAClient();

            // Obtain notifiers.
            UANodeElementCollection notifierNodeElementCollection = client.BrowseNotifiers(
                endpointDescriptor, nodeDescriptor);

            // Display notifiers.
            if (notifierNodeElementCollection.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Notifiers:");
                foreach (UANodeElement notifierNodeElement in notifierNodeElementCollection)
                    Console.WriteLine(notifierNodeElement);
            }

            // Obtain objects.
            UANodeElementCollection objectNodeElementCollection = client.BrowseObjects(
                endpointDescriptor, nodeDescriptor);

            // Recurse.
            foreach (UANodeElement objectNodeElement in objectNodeElementCollection)
                BrowseFrom(objectNodeElement);
        }

        // Example output (truncated):
        //
        //
        //Parent node: ObjectsFolder
        //
        //
        //Parent node: Server
        //
        //Notifiers:
        //Green -> nsu=http://opcfoundation.org/Quickstarts/AlarmCondition ;ns=2;s=0:/Green (Object)
        //Yellow -> nsu=http://opcfoundation.org/Quickstarts/AlarmCondition ;ns=2;s=0:/Yellow (Object)
        //
        //
        //Parent node: Server_ServerCapabilities
        //...
    }
}
#endregion
