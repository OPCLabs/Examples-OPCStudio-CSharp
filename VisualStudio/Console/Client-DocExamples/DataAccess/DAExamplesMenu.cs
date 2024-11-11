// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;

namespace DocExamples.DataAccess
{
    static class DAExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer

                _DAClientMapper.DefineMapping.Main1,
                _DAClientMapper.DefineMapping.MappingKinds,
                _DAClientMapper.DefineMapping.Subscribe,

                _EasyDAClient.BrowseAccessPaths.Main1,
                _EasyDAClient.BrowseBranches.Main1,
                _EasyDAClient.BrowseLeaves.Main1,
                _EasyDAClient.BrowseNodes.DataTypes,
                _EasyDAClient.BrowseNodes.Main1,
                _EasyDAClient.BrowseNodes.Recursive,
                _EasyDAClient.BrowseNodes.RecursiveWithRead,
                _EasyDAClient.BrowseProperties.Main1,
                _EasyDAClient.BrowseServers.Main1,
                _EasyDAClient.ChangeItemSubscription.PercentDeadband,
                _EasyDAClient.ChangeItemSubscription.Main1,
                _EasyDAClient.ChangeMultipleItemSubscriptions.Main1,
                _EasyDAClient.GetMultiplePropertyValues.DataType,
                _EasyDAClient.GetMultiplePropertyValues.Main1,
                _EasyDAClient.GetPropertyValue.DataType,
                _EasyDAClient.GetPropertyValue.Main1,
                _EasyDAClient.Isolated.Main1,
                _EasyDAClient.PullItemChanged.Main1,
                _EasyDAClient.PullItemChanged.MultipleItems,
                _EasyDAClient.ReadItem.BrowsePath,
                _EasyDAClient.ReadItem.DataTypes,
                _EasyDAClient.ReadItem.DeviceSource,
                _EasyDAClient.ReadItem.GetTypeCode,
                _EasyDAClient.ReadItem.Main1,
                _EasyDAClient.ReadItem.Synchronous,
                _EasyDAClient.ReadItemValue.Array,
                _EasyDAClient.ReadItemValue.CLSID,
                _EasyDAClient.ReadItemValue.DeviceSource,
                _EasyDAClient.ReadItemValue.Main1,
                _EasyDAClient.ReadMultipleItems.DeviceSource,
                _EasyDAClient.ReadMultipleItems.Main1,
                _EasyDAClient.ReadMultipleItems.ManyRepeat,
                _EasyDAClient.ReadMultipleItems.Synchronous,
                _EasyDAClient.ReadMultipleItems.TimeMeasurements,
                _EasyDAClient.ReadMultipleItemValues.Main1,
                _EasyDAClient.SubscribeItem.CallbackLambda,
                _EasyDAClient.SubscribeItem.Main1,
                _EasyDAClient.SubscribeItem.PercentDeadband,
                _EasyDAClient.SubscribeMultipleItems.DataTypes,
                _EasyDAClient.SubscribeMultipleItems.Main1,
                _EasyDAClient.SubscribeMultipleItems.ManyItems,
                _EasyDAClient.SubscribeMultipleItems.PercentDeadband,
                _EasyDAClient.SubscribeMultipleItems.StateAsInteger,
                _EasyDAClient.SubscribeMultipleItems.StateAsObject,
                _EasyDAClient.SubscribeMultipleItems.StoreInDictionary,
                _EasyDAClient.SubscribeMultipleItems.WithRead,
                _EasyDAClient.UnsubscribeAllItems.Main1,
                _EasyDAClient.UnsubscribeItem.Main1,
                _EasyDAClient.UnsubscribeMultipleItems.Main1,
                _EasyDAClient.WriteItem.Main1,
                _EasyDAClient.WriteItemValue.Array,
                _EasyDAClient.WriteItemValue.Main1,
                _EasyDAClient.WriteItemValue.RequestedDataType,
                _EasyDAClient.WriteMultipleItems.Main1,
                _EasyDAClient.WriteMultipleItemValues.Main1,
                _EasyDAClient.WriteMultipleItemValues.RequestedDataType,
                _EasyDAClient.WriteMultipleItemValues.TestSuccess,
                _EasyDAClient.WriteMultipleItemValues.TimeMeasurements,

                _EasyDAClientExtension.GetDataTypePropertyValue.Main1,
                _EasyDAClientExtension.GetItemPropertyRecord.Main1,
                _EasyDAClientExtension.GetPropertyValueDictionary.Main1,
                _EasyDAClientExtension.WaitForItemValue.Main1,

                _EasyDAClientHoldPeriods.TopicWrite.Main1,

                _EasyDAItemChangedEventArgs.General.Main1,

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
