﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable CheckNamespace
// ReSharper disable LocalizableElement
// ReSharper disable PossibleNullReferenceException
#region Example
// Shows how to obtain a new application certificate from the certificate manager (GDS), and store it for subsequent usage.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.BaseLib.Security.Cryptography.PkiCertificates;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Application;
using OpcLabs.EasyOpc.UA.Application.Extensions;
using OpcLabs.EasyOpc.UA.Extensions;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UADocExamples.Application._IEasyUAClientServerApplication
{
    partial class ObtainNewCertificate
    {
        public static void Main1()
        {
            // Define which GDS we will work with.
            UAEndpointDescriptor gdsEndpointDescriptor =
                ((UAEndpointDescriptor)"opc.tcp://opcua.demo-this.com:58810/GlobalDiscoveryServer")
                .WithUserNameIdentity("appadmin", "demo");

            // Obtain the application interface.
            EasyUAApplication application = EasyUAApplication.Instance;

            // Display which application we are about to work with.
            Console.WriteLine("Application URI string: {0}",
                application.GetApplicationElement().ApplicationUriString);
            
            // Obtain a new application certificate from the certificate manager (GDS), and store it for subsequent usage.
            IPkiCertificate certificate;
            try
            {
                certificate = application.ObtainNewCertificate(gdsEndpointDescriptor);
            }
            catch (UAException uaException)
            {
                Console.WriteLine("*** Failure: {0}", uaException.GetBaseException().Message);
                return;
            }

            // Display results
            Console.WriteLine("Certificate: {0}", certificate);
        }
    }
}
#endregion
