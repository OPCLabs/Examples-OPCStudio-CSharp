// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
#region Example
// This example shows how to subscribe to events and later change the notification rate.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Threading;
using OpcLabs.EasyOpc.AlarmsAndEvents;
using OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel;

namespace DocExamples.AlarmsAndEvents._EasyAEClient
{
    class ChangeEventSubscription
    {
        public static void Main1()
        {
            // Instantiate the client object.
            using (var client = new EasyAEClient())
            {
                var eventHandler = new EasyAENotificationEventHandler(client_Notification);
                client.Notification += eventHandler;

                Console.WriteLine("Subscribing...");
                int handle = client.SubscribeEvents("", "OPCLabs.KitEventServer.2", 500);

                Console.WriteLine("Waiting for 10 seconds...");
                Thread.Sleep(10 * 1000);

                Console.WriteLine("Changing subscription...");
                client.ChangeEventSubscription(handle, 5 * 1000);

                Console.WriteLine("Waiting for 50 seconds...");
                Thread.Sleep(50 * 1000);

                client.UnsubscribeEvents(handle);
            }
        }

        // Notification event handler
        static void client_Notification(object sender, EasyAENotificationEventArgs e)
        {
            if (!e.Succeeded)
            {
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief);
                return;
            }

            if (!(e.EventData is null))
                Console.WriteLine(e.EventData.Message);
        }
    }
}
#endregion
