﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using System;
using System.Collections.Generic;
using DocExamples.Specialized;
using OpcLabs.BaseLib.Console;

namespace UADocExamples.Specialized
{
    static class SpecializedExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                
                UnifiedAutomation_UaSdkNetBundle.RegisterAndUnregisterNodes,

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
