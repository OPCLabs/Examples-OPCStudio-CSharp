// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.
using System;
using System.Collections.Generic;
using DocExamples.AlarmsAndEvents;
using DocExamples.DataAccess;
using DocExamples.DataAccess.Xml;
using DocExamples.Specialized;
using OpcLabs.BaseLib.Console;

namespace DocExamples
{
    class Program
    {
        static void Main()
        {
            Action action;
            do
            {
                Console.WriteLine();
                action = ConsoleDialog.SelectItem("Select OPC specification", "Return", new Dictionary<Action, string>
                {
                    {CommonExamplesMenu.Main1, "Common examples"},
                    {AEExamplesMenu.Main1, "OPC Alarms&Events"}, 
                    {DAExamplesMenu.Main1, "OPC Data Access"},
                    {XmlExamplesMenu.Main1, "OPC XML-DA"},
                    {SpecializedExamplesMenu.Main1, "Specialized examples"}
                });
                action?.Invoke();
            }
            while (!(action is null));
        }
    }
}
