﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
#region Example
// This example shows how subscribing to items in Schneider Electric OPC Factory Server.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Threading;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.DataAccess.OperationModel;

namespace DocExamples.Specialized
{
    class SchneiderElectric_OpcFactoryServer
    {
        public static void SubscribeMultipleItems()
        {
            // Instantiate the client object.
            using (var client = new EasyDAClient())
            {
                client.ItemChanged += client_Main1_ItemChanged;

                client.SubscribeMultipleItems(
                    new[] {
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "<<system>>!#OFSStatus", 1000, null), 
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "<<system>>!#ClientAlive", 1000, null), 
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "<<system>>!#OFSQualStatus", 1000, null),  
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "DevExample_1!#MastPeriod", 1000, null),
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "DevExample_1!#WatchDogValue", 1000, null),
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "DevExample_1!#DiagBuffConf", 1000, null),
                            new DAItemGroupArguments("", "Schneider-Aut.OFS", "DevExample_1!#DiagBuffFull", 1000, null)
                        });

                Console.WriteLine("Processing item changed events for 1 minute...");
                Thread.Sleep(60 * 1000);
            }
        }

        // Item changed event handler
        static void client_Main1_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            if (e.Succeeded)
                Console.WriteLine("{0}: {1}", e.Arguments.ItemDescriptor.ItemId, e.Vtq);
            else
                Console.WriteLine("{0} *** Failure: {1}", e.Arguments.ItemDescriptor.ItemId, e.ErrorMessageBrief);
        }
    }
}
#endregion
