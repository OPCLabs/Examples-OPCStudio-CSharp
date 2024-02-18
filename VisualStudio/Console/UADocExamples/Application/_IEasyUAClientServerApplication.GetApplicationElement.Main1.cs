﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable LocalizableElement
// ReSharper disable PossibleNullReferenceException
#region Example
// Shows how to get the OPC UA registration information for this application.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.UA.Application;
using OpcLabs.EasyOpc.UA.Application.Extensions;
using OpcLabs.EasyOpc.UA.Discovery;

namespace UADocExamples.Application._IEasyUAClientServerApplication
{
    class GetApplicationElement
    {
        public static void Main1()
        {
            // Obtain the application interface.
            EasyUAApplication application = EasyUAApplication.Instance;

            // Get the OPC UA registration information for this application.
            UAApplicationElement applicationElement = application.GetApplicationElement();

            // Display results
            Console.WriteLine("Application element:");
            Console.WriteLine("  Application name: {0}", applicationElement.ApplicationName);
            Console.WriteLine("  Application type: {0}", applicationElement.ApplicationType);
            Console.WriteLine("  Application URI string: {0}", applicationElement.ApplicationUriString);
            Console.WriteLine("  Discovery URI strings: {0}", applicationElement.DiscoveryUriStrings);
            Console.WriteLine("  Product URI string: {0}", applicationElement.ProductUriString);
        }
    }
}
#endregion
