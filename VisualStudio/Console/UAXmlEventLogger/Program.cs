﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable StringLiteralTypo
#region Example
// Logs OPC UA Alarms&Conditions event notifications into an XML file.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.AddressSpace.Standard;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UAXmlEventLogger
{
    class Program
    {
        static void Main()
        {
            // Define which server we will work with.
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer";

            Console.WriteLine("Starting up...");
            var xmlSerializer = new XmlSerializer(typeof(EasyUAEventNotificationEventArgs));
            var xmlWriter = XmlWriter.Create("UAEvents.xml", new XmlWriterSettings
            {
                Indent = true,
                CloseOutput = true
            });
            // The root element can have any name you need, but the name below also allows reading the log back as .NET array
            xmlWriter.WriteStartElement("ArrayOfEasyUAEventNotificationEventArgs");

            Console.WriteLine("Logging events for 30 seconds...");
            int handle = EasyUAClient.SharedInstance.SubscribeEvent(endpointDescriptor, UAObjectIds.Server, 
                samplingInterval:1000,
                (_, eventArgs) =>
                {
                    Debug.Assert(!(eventArgs is null));
                    Console.Write(".");
                    xmlSerializer.Serialize(xmlWriter, eventArgs);
                });
            System.Threading.Thread.Sleep(30 * 1000);

            Console.WriteLine();
            Console.WriteLine("Shutting down...");
            EasyUAClient.SharedInstance.UnsubscribeMonitoredItem(handle);
            xmlWriter.WriteEndElement();    // not really necessary - XmlWriter would write the end tag for us anyway
            xmlWriter.Close();

            Console.WriteLine("Finished.");
        }
    }
}
#endregion