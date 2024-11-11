// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using OpcLabs.BaseLib.Console;
using System;
using System.Collections.Generic;

namespace UADocExamples
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
                    {UAExamplesMenu.Main1, "Main"}, 
                    {AlarmsAndConditions.AlarmsAndConditionsExamplesMenu.Main1, "Alarms and Conditions"}, 
                    {ComplexData.ComplexDataExamplesMenu.Main1, "Complex Data"},
                    {FileProviders.FileProvidersExamplesMenu.Main1, "File Providers"},
                    {FileTransfer.FileTransferExamplesMenu.Main1, "File Transfer"},
                    {Gds.GdsExamplesMenu.Main1, "GDS"},
                    {InformationModel.InformationModelExamplesMenu.Main1, "Information Model"},
                    {Interaction.InteractionExamplesMenu.Main1, "Interaction"},
                    {Licensing.LicensingExamplesMenu.Main1, "Licensing"},
                    {Specialized.SpecializedExamplesMenu.Main1, "Specialized"},
                    {Users.UsersExamplesMenu.Main1, "Users"}
                });
                action?.Invoke();
            }
            while (!(action is null));
        }
    }
}
