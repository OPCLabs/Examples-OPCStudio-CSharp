﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

#region Example
// Logs OPC Unified Architecture data changes into an XML file.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UAXmlLogger
{
    class Program
    {
        static void Main()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            Console.WriteLine("Starting up...");
            var xmlSerializer = new XmlSerializer(typeof(EasyUADataChangeNotificationEventArgs));
            var xmlWriter = XmlWriter.Create("UAData.xml", new XmlWriterSettings
            {
                Indent = true,
                CloseOutput = true
            });
            // The root element can have any name you need, but the name below also allows reading the log back as .NET array
            xmlWriter.WriteStartElement("ArrayOfEasyUADataChangeNotificationEventArgs");

            Console.WriteLine("Logging data for 30 seconds...");
            int handle = EasyUAClient.SharedInstance.SubscribeDataChange(endpointDescriptor, 
                "nsu=http://test.org/UA/Data/ ;i=10853", 
                samplingInterval:100,
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
