// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Engine;

namespace UADocExamples
{
    static class UAExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                _EasyUAClient.Browse.All,
                _EasyUAClient.Browse.Main1,
                _EasyUAClient.BrowseDataNodes.Overload1,
                _EasyUAClient.BrowseDataNodes.Recursive,
                _EasyUAClient.BrowseDataVariables.Overload2,
                _EasyUAClient.BrowseMethods.Overload2,
                _EasyUAClient.BrowseObjects.Overload2,
                _EasyUAClient.BrowseProperties.Overload2,
                _EasyUAClient.CallMethod.Main1,
                _EasyUAClient.CallMultipleMethods.Main1,
                _EasyUAClient.ChangeMonitoredItemSubscription.Overload1,
                _EasyUAClient.ChangeMultipleMonitoredItemSubscriptions.Overload2,
                _EasyUAClient.DiscoverGlobalServers.Hierarchical,
                _EasyUAClient.DiscoverGlobalServers.Main1,
                _EasyUAClient.DiscoverLocalServers.Overload1,
                _EasyUAClient.DiscoverNetworkServers.Hierarchical,
                _EasyUAClient.DiscoverNetworkServers.Main1,
                _EasyUAClient.FindLocalApplications.Main1,
                _EasyUAClient.GetMonitoredItemArguments.Main1,
                _EasyUAClient.GetMonitoredItemArgumentsDictionary.Main1,
                _EasyUAClient.Isolated.Main1,
                _EasyUAClient.LogEntry.Main1,
                _EasyUAClient.PullDataChangeNotification.Main1,
                _EasyUAClient.Read.BrowsePath,
                _EasyUAClient.Read.FromDevice,
                _EasyUAClient.Read.Main1,
                _EasyUAClient.ReadMultiple.BrowsePath,
                _EasyUAClient.ReadMultiple.FromDevice,
                _EasyUAClient.ReadMultiple.Main1,
                _EasyUAClient.ReadMultipleValues.DataType,
                _EasyUAClient.ReadMultipleValues.Main1,
                _EasyUAClient.ReadValue.ArrayOfUInt16,
                _EasyUAClient.ReadValue.MultipleServers,
                _EasyUAClient.ReadValue.NamespaceArray,
                _EasyUAClient.ReadValue.Overload1,
                _EasyUAClient.ReadValue.Overload2,
                _EasyUAClient.ReadValue.Repeated,
                _EasyUAClient.RetrieveAllDataTypes.Main1,
                _EasyUAClient.SubscribeDataChange.AbsoluteDeadband,
                _EasyUAClient.SubscribeDataChange.CallbackLambda,
                _EasyUAClient.SubscribeDataChange.Filter,
                _EasyUAClient.SubscribeDataChange.Overload1,
                _EasyUAClient.SubscribeDataChange.PercentDeadband,
                _EasyUAClient.SubscribeMultipleMonitoredItems.AbsoluteDeadband,
                _EasyUAClient.SubscribeMultipleMonitoredItems.AllInObject,
                _EasyUAClient.SubscribeMultipleMonitoredItems.Filter,
                _EasyUAClient.SubscribeMultipleMonitoredItems.Main1,
                _EasyUAClient.SubscribeMultipleMonitoredItems.PercentDeadband,
                _EasyUAClient.SubscribeMultipleMonitoredItems.StateAsInteger,
                _EasyUAClient.SubscribeMultipleMonitoredItems.StateAsObject,
                _EasyUAClient.SubscribeMultipleMonitoredItems.StoreInDictionary,
                _EasyUAClient.UnsubscribeAllMonitoredItems.Main1,
                _EasyUAClient.UnsubscribeMonitoredItem.Main1,
                _EasyUAClient.UnsubscribeMultipleMonitoredItems.Main1,
                _EasyUAClient.UnsubscribeMultipleMonitoredItems.Some,
                _EasyUAClient.Write.Main1,
                _EasyUAClient.WriteMultiple.TestSuccess,
                _EasyUAClient.WriteMultipleValues.Main1,
                _EasyUAClient.WriteMultipleValues.TestSuccess,
                _EasyUAClient.WriteMultipleValues.ValueType,
                _EasyUAClient.WriteMultipleValues.ValueTypeCode,
                _EasyUAClient.WriteMultipleValues.ValueTypeFullName,
                _EasyUAClient.WriteValue.ArrayOfInt32,
                _EasyUAClient.WriteValue.ByteString,
                _EasyUAClient.WriteValue.Incrementing,
                _EasyUAClient.WriteValue.Main1,
                _EasyUAClient.WriteValue.Type,
                _EasyUAClient.WriteValue.TypeCode,

                _EasyUAClientConnectionControl.DisposableLockConnection.Main1,
                _EasyUAClientConnectionControl.LockAndUnlockConnection.Main1,

                _EasyUAClientConnectionMonitoring.ServerConditionChanged.Main1,

                _EasyUAClientExtension.WaitForValue.Main1,

                _EasyUAClientNodeRegistration.RegisterAndUnregisterMultipleNodes.Main1,

                _UAClientMapper.DefineMapping.Main1,

                _UAClientSessionParameters.Timeouts.Isolated,
                // ReSharper restore RedundantCommaInArrayInitializer
            };

            var actionList = new List<Action>(actionArray);

            var originalSharedParameters = (EasyUAClientSharedParameters)EasyUAClient.SharedParameters.Clone();
            do
            {
                Console.WriteLine();
                if (!ConsoleDialog.SelectAndPerformAction("Select action to perform", "Return", actionList))
                    break;

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                if (EasyUAClient.SharedParameters != originalSharedParameters)
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
