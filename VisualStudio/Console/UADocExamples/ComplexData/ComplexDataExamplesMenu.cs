﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Engine;

namespace UADocExamples.ComplexData
{
    static class ComplexDataExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                _DataType.Kind.Main1,
                _EasyUAClient.ReadValue.Main1,
                _EasyUAClient.SubscribeDataChange.Main1,
                _EasyUAClient.WriteValue.Main1,
                _GenericData._Construction.Main1,
                _GenericData.DataTypeKind1.Main1,
                _IEasyUAClientComplexData.ResolveDataType.Main1,
                _IUADataTypeDictionaryProvider.ResolveDataTypeDescriptorFromDataTypeEncodingId.Main1,
                _PluginSetup.Enabled.Main1,
                _UAComplexDataClientPluginParameters.IsolatedDataTypeModelProvider.Main1,
                // ReSharper restore RedundantCommaInArrayInitializer
            };

            var actionList = new List<Action>(actionArray);

            var originalSharedParameters = (EasyUASharedParameters)EasyUAClient.SharedParameters.Clone();
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
