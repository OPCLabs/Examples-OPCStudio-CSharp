// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using System;
using System.Collections.Generic;
using System.Net.Mime;
using Microsoft.VisualBasic;
using OpcLabs.BaseLib.Console;

namespace UASubscriberDocExamples
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
                    {PubSub.PubSubExamplesMenu.Main1, "PubSub"},
                });
                action?.Invoke();
            }
            while (!(action is null));
        }
    }
}
