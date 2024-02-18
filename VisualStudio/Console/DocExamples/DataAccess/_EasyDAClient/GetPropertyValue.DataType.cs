﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable PossibleNullReferenceException
#region Example 
// This example shows how to obtain a data type of an OPC item.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using OpcLabs.BaseLib.ComInterop;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.OperationModel;

namespace DocExamples.DataAccess._EasyDAClient
{
    partial class GetPropertyValue
    {
        public static void DataType()
        {
            // Instantiate the client object.
            var client = new EasyDAClient();

            // Get the value of DataType property; it is a 16-bit signed integer
            short dataType;
            try
            {
                dataType = (short)client.GetPropertyValue("", "OPCLabs.KitServer.2", "Simulation.Random",
                    DAPropertyIds.DataType);
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }
            // Convert the data type to VarType
            var varType = (VarType)dataType;

            // Display the obtained data type
            Console.WriteLine("DataType: {0}", dataType);   // Display data type as numerical value
            Console.WriteLine("VarType: {0}", varType);     // Display data type symbolically

            // Code below illustrates how decisions can be made based on type
            switch (varType.InternalValue)
            {
                case VarTypes.R8:
                    Console.WriteLine("The data type is VarTypes.R8, as we expected.");
                    break;

                // other cases may come here ...

                default:
                    Console.WriteLine("The data type is not as we expected!");
                    break;
            }
        }
    }
}
#endregion
