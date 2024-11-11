// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;

namespace DocExamples.DataAccess.Xml
{
    static class XmlExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer

                BrowseBranches.Main1Xml,
                BrowseLeaves.Main1Xml,
                BrowseNodes.RecursiveXml,
                BrowseProperties.Main1Xml,
                ChangeItemSubscription.Main1Xml,
                GetMultiplePropertyValues.DataTypeXml,
                GetMultiplePropertyValues.Main1Xml,
                GetPropertyValue.Main1Xml,
                PullItemChanged.Main1Xml,
                ReadItem.DeviceSourceXml,
                ReadItem.Main1Xml,
                ReadItemValue.DeviceSourceXml,
                ReadItemValue.Main1Xml,
                ReadMultipleItems.DeviceSourceXml,
                ReadMultipleItems.Main1Xml,
                ReadMultipleItemValues.Main1Xml,
                SubscribeItem.CallbackLambdaXml,
                SubscribeItem.PercentDeadbandXml,
                SubscribeMultipleItems.PercentDeadbandXml,
                WriteItemValue.Main1Xml,
                WriteMultipleItemValues.Main1Xml,

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
