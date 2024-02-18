﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
#region Example
// Shows how different data types can be subscribed to, including rare types and arrays of values.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;

namespace DocExamples.DataAccess._EasyDAClient
{
    partial class SubscribeMultipleItems
    {
        static void client_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine("Arguments.ItemDescriptor.ItemId: {0}", e.Arguments.ItemDescriptor.ItemId);

            if (e.Succeeded)
            {
                Debug.Assert(e.Vtq != null);
                Console.WriteLine("Vtq: {0}", e.Vtq);
            }
            else
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief);
        }

        public static void DataTypes()
        {
            IEnumerable<DAItemGroupArguments> arguments = new[]
                {
                    "Simulation.Register_EMPTY",
                    "Simulation.Register_NULL",
                    "Simulation.Register_DISPATCH",

                    "Simulation.ReadValue_I2",
                    "Simulation.ReadValue_I4",
                    "Simulation.ReadValue_R4",
                    "Simulation.ReadValue_R8",
                    "Simulation.ReadValue_CY",
                    "Simulation.ReadValue_DATE",
                    "Simulation.ReadValue_BSTR",
                    "Simulation.ReadValue_BOOL",
                    "Simulation.ReadValue_DECIMAL",
                    "Simulation.ReadValue_I1",
                    "Simulation.ReadValue_UI1",
                    "Simulation.ReadValue_UI2",
                    "Simulation.ReadValue_UI4",
                    "Simulation.ReadValue_INT",
                    "Simulation.ReadValue_UINT",

                    "Simulation.ReadValue_ArrayOfI2",
                    "Simulation.ReadValue_ArrayOfI4",
                    "Simulation.ReadValue_ArrayOfR4",
                    "Simulation.ReadValue_ArrayOfR8",
                    "Simulation.ReadValue_ArrayOfCY",
                    "Simulation.ReadValue_ArrayOfDATE",
                    "Simulation.ReadValue_ArrayOfBSTR",
                    "Simulation.ReadValue_ArrayOfBOOL",
                    //"Simulation.ReadValue_ArrayOfDECIMAL",
                    "Simulation.ReadValue_ArrayOfI1",
                    "Simulation.ReadValue_ArrayOfUI1",
                    "Simulation.ReadValue_ArrayOfUI2",
                    "Simulation.ReadValue_ArrayOfUI4",
                    "Simulation.ReadValue_ArrayOfINT",
                    "Simulation.ReadValue_ArrayOfUINT",
                }.Select(itemId => new DAItemGroupArguments("", "OPCLabs.KitServer.2", itemId, 3 * 1000, null));

            // Instantiate the client object.
            var client = new EasyDAClient();
            client.ItemChanged += client_ItemChanged;

            Console.WriteLine("Subscribing items...");
            client.SubscribeMultipleItems(arguments.ToArray());
            Thread.Sleep(30 * 1000);
            client.UnsubscribeAllItems();
            client.ItemChanged -= client_ItemChanged;
        }
    }
}
#endregion
