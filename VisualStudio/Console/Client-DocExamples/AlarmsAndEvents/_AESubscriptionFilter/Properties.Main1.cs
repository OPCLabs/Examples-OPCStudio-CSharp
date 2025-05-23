// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
#region Example
// This example shows how to set the filtering criteria to be used for the event subscription.
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System;
using System.Threading;
using OpcLabs.EasyOpc.AlarmsAndEvents;
using OpcLabs.EasyOpc.AlarmsAndEvents.OperationModel;
using OpcLabs.EasyOpc.DataAccess;
using OpcLabs.EasyOpc.OperationModel;

namespace DocExamples.AlarmsAndEvents._AESubscriptionFilter
{
    class Properties
    {
        // Instantiate the OPC-A&E client object.
        static readonly EasyAEClient AEClient = new EasyAEClient();


        // Instantiate the OPC-DA client object.
        static readonly EasyDAClient DAClient = new EasyDAClient();

        public static void Main1()
        {
            var eventHandler = new EasyAENotificationEventHandler(aeClient_Notification);
            AEClient.Notification += eventHandler;

            Console.WriteLine("Processing event notifications...");
            var subscriptionFilter = new AESubscriptionFilter
            {
                Sources = new AENodeDescriptor[] { "Simulation.ConditionState1", "Simulation.ConditionState3" }
            };
            // You can also filter using event types, categories, severity, and areas.
            int handle = AEClient.SubscribeEvents("", "OPCLabs.KitEventServer.2", 1000, null, subscriptionFilter);

            // Allow time for initial refresh
            Thread.Sleep(5 * 1000);

            // Set some events to active state.
            try
            {
                // The activation below will come from a source contained in a filter and the notification will arrive.
                DAClient.WriteItemValue("", "OPCLabs.KitServer.2", "SimulateEvents.ConditionState1.Activate", true);
                // The activation below will come from a source that is not contained in a filter and the notification will not arrive.
                DAClient.WriteItemValue("", "OPCLabs.KitServer.2", "SimulateEvents.ConditionState2.Activate", true);
            }
            catch (OpcException opcException)
            {
                Console.WriteLine("*** Failure: {0}", opcException.GetBaseException().Message);
                return;
            }

            Thread.Sleep(10 * 1000);

            AEClient.UnsubscribeEvents(handle);
            AEClient.Notification -= eventHandler;
        }

        // Notification event handler
        static void aeClient_Notification(object sender, EasyAENotificationEventArgs e)
        {
            Console.WriteLine();
            if (!e.Succeeded)
            {
                Console.WriteLine("*** Failure: {0}", e.ErrorMessageBrief);
                return;
            }

            Console.WriteLine("Refresh: {0}", e.Refresh);
            Console.WriteLine("RefreshComplete: {0}", e.RefreshComplete);
            AEEventData eventData = e.EventData;
            if (!(eventData is null))
            {
                Console.WriteLine("Event.QualifiedSourceName: {0}", eventData.QualifiedSourceName);
                Console.WriteLine("Event.Message: {0}", eventData.Message);
                Console.WriteLine("Event.Active: {0}", eventData.Active);
                Console.WriteLine("Event.Acknowledged: {0}", eventData.Acknowledged);
            }
        }
    }
}
#endregion
