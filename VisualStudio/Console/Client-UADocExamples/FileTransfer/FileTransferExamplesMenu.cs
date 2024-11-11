// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable LocalizableElement

using System;
using System.Collections.Generic;
using OpcLabs.BaseLib.Console;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.Engine;

namespace UADocExamples.FileTransfer
{
    static class FileTransferExamplesMenu
    {
        public static void Main1()
        {
            var actionArray = new Action[] {
                // ReSharper disable RedundantCommaInArrayInitializer
                _EasyUAFileTransferClient.BrowseFiles.Main1,
                _EasyUAFileTransferClient.Copy.File1,
                _EasyUAFileTransferClient.CreateDirectoryAndDelete.Main1,
                _EasyUAFileTransferClient.CreateFileAndDelete.Main1,
                _EasyUAFileTransferClient.GetFileProperties.Main1,
                _EasyUAFileTransferClient.ReadAllBytes.Main1,
                _EasyUAFileTransferClient.ReadAndSetFilePosition.Main1,
                _EasyUAFileTransferClient.WriteAllBytes.Main1,
                _EasyUAFileTransferClient.WriteFile.Main1,
                _UAFileStream.ReadAndSeek.Main1,
                _UAFileStream.ReadText.Main1,
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
