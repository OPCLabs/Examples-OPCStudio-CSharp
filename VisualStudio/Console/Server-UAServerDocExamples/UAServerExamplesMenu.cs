// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable AccessToStaticMemberViaDerivedType
// ReSharper disable ArrangeModifiersOrder
// ReSharper disable LocalizableElement
// ReSharper disable RedundantCommaInArrayInitializer

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Engine;

namespace UAServerDocExamples
{
    static class UAServerExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                _EasyUAServer._Construction.Main1,
                _EasyUAServer._Parameterization.OpcCompliance,
                _EasyUAServer.ConversionError.Main1,
                _EasyUAServer.Dispose.Main1,
                _EasyUAServer.EffectiveEndpointDescriptor.Main1,
                _EasyUAServer.EndpointStateChanged.Main1,
                _EasyUAServer.EndpointUrl.Main1,
                _EasyUAServer.EndpointUrlString.Main1,
                _EasyUAServer.FindServerNode.Main1,
                _EasyUAServer.HostNames.Main1,
                _EasyUAServer.LogEntry.Main1,
                _EasyUAServer.MessageSecurityModes.Secure,
                _EasyUAServer.MessageSecurityModes.SecurityNone,
                _EasyUAServer.Objects.Main1,
                _EasyUAServer.ObjectsNamespaceUri.Main1,
                _EasyUAServer.ObjectsNamespaceUriString.Main1,
                _EasyUAServer.Start_Stop.Main1,

                _EasyUAServerConnectionMonitoring.ClientSessions.Main1,

                _UADataVariable._Building.Nested,
                _UADataVariable.ConstantValue.Main1,
                _UADataVariable.ReadAttributeData.Main1,
                _UADataVariable.ReadFunction.Main1,
                _UADataVariable.ReadFunction.Unreliable,
                _UADataVariable.ReadValueFunction.Array,
                _UADataVariable.ReadValueFunction.ByteString,
                _UADataVariable.ReadValueFunction.Main1,
                _UADataVariable.ReadValueFunction.UInt16,
                _UADataVariable.ReadWrite.Bad,
                _UADataVariable.ReadWrite.Main1,
                _UADataVariable.ReadWriteValue.Array,
                _UADataVariable.ReadWriteValue.Array2D,
                _UADataVariable.ReadWriteValue.Array3D,
                _UADataVariable.ReadWriteValue.BoundedArray,
                _UADataVariable.ReadWriteValue.ByteString,
                _UADataVariable.ReadWriteValue.FullyWritable,
                _UADataVariable.ReadWriteValue.Main1,
                _UADataVariable.SetMinimumSamplingInterval.Main1,
                _UADataVariable.UpdateReadAttributeData.Main1,
                _UADataVariable.WriteAttributeData.Main1,
                _UADataVariable.WriteFunction.GoodCompletesAsynchronously,
                _UADataVariable.WriteFunction.Main1,
                _UADataVariable.WriteValueAction.ByteString,
                _UADataVariable.WriteValueAction.Main1,
                _UADataVariable.WriteValueAction.UInt16,
                _UADataVariable.WriteValueAction.WriteOnly1,
                _UADataVariable.WriteValueFunction.Main1,

                _UAFolder._Building.Nested,

                _UAServerNode.DataSubscriptionChanged.Main1,
                _UAServerNode.EffectiveNodeDescriptor.Main1,
                _UAServerNode.Indexer.Main1,
                _UAServerNode.OnRead.Main1,
                _UAServerNode.OnWrite.Main1,
                _UAServerNode.ParentNode.Main1,
                _UAServerNode.Read.Main1,
                _UAServerNode.SamplingIntervalChanged.Main1,
                _UAServerNode.Starting_Stopped.Main1,
                _UAServerNode.Write.Main1,
            };

            var actionList = new List<Action>(actionArray);

            var originalSharedParameters = (EasyUAServerSharedParameters)EasyUAServer.SharedParameters.Clone();
            do
            {
                Console.WriteLine();
                if (!ConsoleDialog.SelectAndPerformAction("Select action to perform", "Return", actionList))
                    break;

                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();

                if (EasyUAServer.SharedParameters != originalSharedParameters)
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
