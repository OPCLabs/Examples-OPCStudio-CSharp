// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Engine;

namespace UACommonDocExamples.Application
{
    static class ApplicationExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                UADocExamples.Application._IEasyUAClientServerApplication.AssureOwnCertificatePack.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.FindGdsRegistrations.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.GetApplicationElement.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.GetCertificateSubjectName.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.ObtainNewCertificatePack.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.ObtainNewCertificatePack.Progress,
                UADocExamples.Application._IEasyUAClientServerApplication.RefreshTrustLists.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.RegisterToGds.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.RemoveOwnCertificatePack.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.UnregisterFromGds.Main1,
                UADocExamples.Application._IEasyUAClientServerApplication.UpdateGdsRegistration.Main1,
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
