﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CommentTypo
#region Example
// This example shows how to obtain application URLs of all OPC Unified Architecture servers, using specified discovery URI
// strings.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Discovery;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples._EasyUAClient
{
    class FindLocalApplications
    {
        public static void Main1()
        {

            string[] discoveryUriStrings =
            {
                "opc.tcp://opcua.demo-this.com:4840/UADiscovery",
                "http://opcua.demo-this.com/UADiscovery/Default.svc",
                "http://opcua.demo-this.com:52601/UADiscovery"
            };

            // Instantiate the client object.
            var client = new EasyUAClient();

            // Obtain collection of application elements.
            UADiscoveryElementCollection discoveryElementCollection;
            try
            {
                discoveryElementCollection = client.FindLocalApplications(discoveryUriStrings, UAApplicationTypes.Server);
            }
            catch (UAException uaException)
            {
                Console.WriteLine($"*** Failure: {uaException.GetBaseException().Message}");
                return;
            }

            // Display results.
            foreach (UADiscoveryElement discoveryElement in discoveryElementCollection)
                Console.WriteLine($"discoveryElementCollection[\"{discoveryElement.DiscoveryUriString}\"].ApplicationUriString: {discoveryElement.ApplicationUriString}");


            // Example output:
            //discoveryElementCollection["http://opcua.demo-this.com:62543/Quickstarts/AlarmConditionServer"].ApplicationUriString: urn:opcua.demo-this.com:Quickstart Alarm Condition Server
            //discoveryElementCollection["opc.tcp://opcua.demo-this.com:62544/Quickstarts/AlarmConditionServer"].ApplicationUriString: urn:opcua.demo-this.com:Quickstart Alarm Condition Server
            //discoveryElementCollection["opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"].ApplicationUriString: urn:opcua.demo-this.com:UA Sample Server
            //discoveryElementCollection["http://opcua.demo-this.com:51211/UA/SampleServer"].ApplicationUriString: urn:opcua.demo-this.com:UA Sample Server
            //discoveryElementCollection["https://opcua.demo-this.com:51212/UA/SampleServer/"].ApplicationUriString: urn:opcua.demo-this.com:UA Sample Server
            //discoveryElementCollection["opc.tcp://opcua.demo-this.com:51210/UA/SampleServer"].ApplicationUriString: urn:Test-PC:UA Sample Server
        }
    }
}
#endregion
