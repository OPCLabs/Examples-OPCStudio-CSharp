﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
// ReSharper disable CheckNamespace
#region Example
// Shows how to write into an OPC item that is of array type, and read the array value back.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.OperationModel;

namespace DocExamples.DataAccess._EasyDAClient
{
    partial class WriteItemValue
    {
        public static void Array()
        {
            // Instantiate the client object.
            var client = new EasyDAClient();

            Console.WriteLine("Writing array value...");
            try
            {
                client.WriteItemValue("", "OPCLabs.KitServer.2", "Simulation.Register_ArrayOfI2", new Int16[] { 1234, 2345, 3456 });
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }

            Console.WriteLine("Reading array value...");
            short[] value;
            try
            {
                value = (Int16[])client.ReadItemValue("", "OPCLabs.KitServer.2", "Simulation.Register_ArrayOfI2");
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }

            if (!(value is null))
            {
                Console.WriteLine(value[0]);
                Console.WriteLine(value[1]);
                Console.WriteLine(value[2]);
            }
        }
    }
}
#endregion
