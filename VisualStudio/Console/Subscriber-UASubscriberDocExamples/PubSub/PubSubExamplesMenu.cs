// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA.PubSub;
using OpcLabs.EasyOpc.UA.PubSub.Engine;
using UASubscriberDocExamples.PubSub._EasyUASubscriber;
using UASubscriberDocExamples.PubSub._IUAReadOnlyPubSubConfiguration;

namespace UASubscriberDocExamples.PubSub
{
    static class PubSubExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                PullDataSetMessage.Main1,
                SubscribeDataSet.Callback,
                SubscribeDataSet.CaptureFile,
                SubscribeDataSet.Ethernet,
                SubscribeDataSet.ExtractField,
                SubscribeDataSet.FieldNames,
                SubscribeDataSet.Filter,
                SubscribeDataSet.Main1,
                SubscribeDataSet.MappingParameters,
                SubscribeDataSet.Metadata,
                SubscribeDataSet.MqttFromFileStorage,
                SubscribeDataSet.MqttJsonTcp,
                SubscribeDataSet.MqttTcpSaveCopy,
                SubscribeDataSet.MqttUadpTcp,
                SubscribeDataSet.PublishedDataSet,
                SubscribeDataSet.PublisherId,
                SubscribeDataSet.ResolveFromFile,
                SubscribeDataSet.Secure,
                SubscribeDataSetField.Main1,
                UnsubscribeDataSet.Main1,
                GetMethods.PublishedDataSets,
                GetMethods.PubSubComponents,
                // ReSharper restore RedundantCommaInArrayInitializer
            };

            var actionList = new List<Action>(actionArray);

            var originalSharedParameters = (EasyUASubscriberSharedParameters)EasyUASubscriber.SharedParameters.Clone();
            do
            {
                Console.WriteLine();
                if (!ConsoleDialog.SelectAndPerformAction("Select action to perform", "Return", actionList))
                    break;

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                if (EasyUASubscriber.SharedParameters != originalSharedParameters)
                {
                    using (ConsoleUtilities.WithForegroundColor(ConsoleColor.Yellow))
                        Console.WriteLine(
                            "This example has changed some global parameters that can influence how other examples work. " +
                            "For this reason, the application will now exit. Start it again to continue.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            while (true);
        }
    }
}
