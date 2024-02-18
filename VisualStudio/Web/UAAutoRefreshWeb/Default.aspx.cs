﻿// $Header: $
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

// ReSharper disable ArrangeModifiersOrder
// ReSharper disable InconsistentNaming

//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .

using System;
using System.Web.UI.WebControls;
using OpcLabs.EasyOpc.UA;
using OpcLabs.EasyOpc.UA.OperationModel;

namespace UAAutoRefreshWeb
{
    public partial class _Default : System.Web.UI.Page
    {
        // Use a shared client instance to allow for better optimization.
        static private readonly EasyUAClient Client = new EasyUAClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            Read(TextBox1, "nsu=http://test.org/UA/Data/ ;i=10853");
            Read(TextBox2, "nsu=http://test.org/UA/Data/ ;i=11017");
            Read(TextBox3, "nsu=http://test.org/UA/Data/ ;i=10845");
        }

        protected void Read(TextBox textBox, UANodeDescriptor nodeDescriptor)
        {
            try
            {
                object value = Client.ReadValue("opc.tcp://opcua.demo-this.com:51210/UA/SampleServer", nodeDescriptor);
                textBox.Text = value?.ToString() ?? "";
            }
            catch (UAException e)
            {
                textBox.Text = $"*** {e.GetBaseException().Message}"; 
            }
        }
    }
}
