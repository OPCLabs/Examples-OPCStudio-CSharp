﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
#region Example
// This example demonstrates how to set the application name for the client certificate.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.BaseLib.Instrumentation;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Application;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._UAApplicationManifest
{
    class ApplicationName
    {
        public static void Main1()
        {
            UAEndpointDescriptor endpointDescriptor =
                "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // or "http://opcua.demo-this.com:51211/UA/SampleServer" (currently not supported)
            // or "https://opcua.demo-this.com:51212/UA/SampleServer/"

            // Hook static events
            EasyUAClient.LogEntry += EasyUAClientOnLogEntry;

            try
            {
                // Set the application name, which determines the subject of the client certificate.
                // Note that this only works once in each host process.
                EasyUAApplication.Instance.ApplicationParameters.ApplicationManifest.ApplicationName = 
                    "QuickOPC - CSharp example application";

                // Do something - invoke an OPC read, to trigger some loggable entries.
                var client = new EasyUAClient();
                try
                {
                    client.ReadValue(endpointDescriptor, "nsu=http://test.org/UA/Data/ ;i=10853");
                }
                catch (UAException uaException)
                {
                    Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message);
                }

                // The certificate will be located or created in a directory similar to:
                // C:\ProgramData\OPC Foundation\CertificateStores\MachineDefault\certs
                // and its subject will be as given by the application name.

                Console.WriteLine("Processing log entry events for 10 seconds...");
                System.Threading.Thread.Sleep(10 * 1000);

                Console.WriteLine("Finished.");
            }
            finally
            {
                // Unhook static events
                EasyUAClient.LogEntry -= EasyUAClientOnLogEntry;
            }
        }

        // Event handler for the LogEntry event.
        // Print the loggable entry containing client certificate parameters.
        private static void EasyUAClientOnLogEntry(object sender, LogEntryEventArgs logEntryEventArgs)
        {
            if (logEntryEventArgs.EventId == 161)
                Console.WriteLine(logEntryEventArgs);
        }
    }
}
#endregion
