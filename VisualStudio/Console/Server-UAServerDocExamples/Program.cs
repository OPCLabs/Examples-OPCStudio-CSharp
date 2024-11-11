// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;

namespace UAServerDocExamples
{
    class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Action action;
            do
            {
                Console.WriteLine();
                action = ConsoleDialog.SelectItem("Select example group", "Return", new Dictionary<Action, string>
                {
                    {UAServerExamplesMenu.Main1, "Main"},
                    {Configuration.ConfigurationExamplesMenu.Main1, "Configuration"},
                    {Licensing.LicensingExamplesMenu.Main1, "Licensing"},
                });
                action?.Invoke();
            }
            while (!(action is null));
        }
    }
}
