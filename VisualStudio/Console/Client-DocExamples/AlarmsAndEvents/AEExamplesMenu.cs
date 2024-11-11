using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;

namespace DocExamples.AlarmsAndEvents
{
    static class AEExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer

                _AEAttributeElement.Properties.Main1,
                
                _AECategoryElement.Properties.Main1,

                _AEConditionElement.Properties.Main1,

                _AESubscriptionFilter.Properties.Main1,

                _EasyAEClient.AcknowledgeCondition.Main1,
                _EasyAEClient.BrowseAreas.Main1,
                _EasyAEClient.BrowseServers.Main1,
                _EasyAEClient.BrowseSources.Main1,
                _EasyAEClient.ChangeEventSubscription.Main1,
                _EasyAEClient.GetConditionState.Main1,
                _EasyAEClient.PullNotification.Main1,
                _EasyAEClient.QueryEventCategories.Main1,
                _EasyAEClient.QuerySourceConditions.Main1,
                _EasyAEClient.RefreshEventSubscription.Main1,
                _EasyAEClient.SubscribeEvents.CallbackLambda,
                _EasyAEClient.SubscribeEvents.FilterByCategories,
                _EasyAEClient.SubscribeEvents.Main1,
                _EasyAEClient.UnsubscribeAllEvents.Main1,
                _EasyAEClient.UnsubscribeEvents.Main1,

                _EasyAENotificationEventArgs.AttributeValues.Main1,

                SWToolbox.TOPServer_AE.Main1,

                // ReSharper restore RedundantCommaInArrayInitializer
            };

            var actionList = new List<Action>(actionArray);
            bool cont;
            do
            {
                Console.WriteLine();
                cont = ConsoleDialog.SelectAndPerformAction("Select action to perform", "Return", actionList);
                if (cont)
                {
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }
            while (cont);
        }
    }
}
