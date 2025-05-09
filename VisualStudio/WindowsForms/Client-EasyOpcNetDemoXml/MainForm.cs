﻿// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

// ReSharper disable InconsistentNaming
// ReSharper disable NotNullMemberIsNotInitialized

using System.Diagnostics;
using EasyOpcNetDemoXml.Properties;
using OpcLabs.BaseLib.ComInterop;
using OpcLabs.EasyOpc.DataAccess;
using System;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using OpcLabs.EasyOpc.DataAccess.OperationModel;
using OpcLabs.EasyOpc.OperationModel;

[assembly:CLSCompliant(true)]
namespace EasyOpcNetDemoXml
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private bool _isItemSubscribed/* = false*/;

        /// <summary>
        /// A handle for the OPC item subscription, returned by the client component. The handle is used to change the
        /// parameters of the subscription, or to unsubscribe.
        /// </summary>
        private int _itemHandle/* = 0*/;


        /// <summary>
        /// The user has pressed the "About" button. Show a message box with information about the executing assembly.
        /// </summary>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, Assembly.GetExecutingAssembly().FullName,
                Resources.MainForm_aboutButton_Click_Assembly_Name, MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// The user has pressed the "Browse computers and servers" button. Let the user select or enter the machine and an
        /// OPC server in a modal dialog.
        /// </summary>
        private void browseComputersAndServersButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);

            opcComputerAndServerDialog1.ServerDescriptor.UrlString = serverUrlTextBox.Text;
            if (opcComputerAndServerDialog1.ShowDialog(this) == DialogResult.OK)
                serverUrlTextBox.Text = opcComputerAndServerDialog1.ServerDescriptor.UrlString;
        }

        /// <summary>
        /// The user has pressed the "Browse items" button. Let the user select the OPC item (from items available in the
        /// given OPC server) in a modal dialog.
        /// </summary>
        private void browseItemsButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(daItemDialog1.NodeDescriptor != null);

            daItemDialog1.ServerDescriptor.UrlString = serverUrlTextBox.Text;
            daItemDialog1.NodeDescriptor.ItemId = itemIdTextBox.Text;
            daItemDialog1.NodeDescriptor.NodePath = nodePathTextBox.Text;
            if (daItemDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.Assert(daItemDialog1.NodeDescriptor != null);
                itemIdTextBox.Text = daItemDialog1.NodeDescriptor.ItemId;
                nodePathTextBox.Text = daItemDialog1.NodeDescriptor.NodePath;
            }
        }

        /// <summary>
        /// The user has pressed the "Browse properties" button. Let the user select an OPC property (from properties
        /// available on the given OPC item) in a modal dialog.
        /// </summary>
        private void browsePropertiesButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(itemIdTextBox.Text != null);

            daPropertyDialog1.ServerDescriptor.UrlString = serverUrlTextBox.Text;
            daPropertyDialog1.NodeDescriptor.ItemId = itemIdTextBox.Text;
            daPropertyDialog1.NodeDescriptor.NodePath = nodePathTextBox.Text;
            if (daPropertyDialog1.ShowDialog() == DialogResult.OK)
            {
                Debug.Assert(daPropertyDialog1.PropertyElement != null);
                propertyTextBox.Text = daPropertyDialog1.PropertyDescriptor.ToString();
            }
        }

        /// <summary>
        /// The user has pressed the "Change item subscription" button. Change the parameters of the current subscription to
        /// the requested update rate and percent deadband currently given on the form.
        /// </summary>
        private void changeItemSubscriptionButton_Click(object sender, EventArgs e)
        {
            var groupParameters = new DAGroupParameters(
                (int)requestedUpdateRateNumericUpDown.Value,
                (float)percentDeadbandNumericUpDown.Value);
            easyDAClient1.ChangeItemSubscription(_itemHandle, groupParameters);
        }

        /// <summary>
        /// The user has pressed the "Close" button. Close the form.
        /// </summary>
        private void closeButton_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Updates the "Exception" text box with the text of the error, or clears it if there is no exception.
        /// </summary>
        private void DisplayException(Exception exception)
        {
            exceptionTextBox.Text = (exception is null) ? "" : exception.GetBaseException().Message;
        }

        /// <summary>
        /// Updates the "Value", "Timestamp" and "Quality" text boxes with data from the OPC server, or clears them if no
        /// data is available.
        /// </summary>
        private void DisplayVtq(DAVtq vtq)
        {
            if (vtq is null)
            {
                valueTextBox.Text = "";
                timestampTextBox.Text = "";
                qualityTextBox.Text = "";
            }
            else
            {
                valueTextBox.Text = vtq.DisplayValue();
                timestampTextBox.Text = vtq.Timestamp.ToString(CultureInfo.CurrentCulture);
                qualityTextBox.Text = vtq.Quality.ToString();
            }
        }

        /// <summary>
        /// Event handler for the <see cref="EasyDAClient.ItemChanged"/> event. It is invoked for every significant change
        /// related to the OPC items subscribed. We display the data received (or the error) on the form.
        /// </summary>
        private void easyDAClient1_ItemChanged(object sender, EasyDAItemChangedEventArgs e)
        {
            DisplayVtq(e.Vtq);
            DisplayException(e.Exception);
        }

        /// <summary>
        /// The user has pressed the "Get property value" button. Attempt to get the value of the given OPC property, and
        /// display either the value, or the error received.
        /// </summary>
        private void getPropertyValueButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(itemIdTextBox.Text != null);
            Debug.Assert(propertyTextBox.Text != null);

            object value = null;
            Exception exception = null;
            try
            {
                value = easyDAClient1.GetPropertyValue(
                    serverUrlTextBox.Text,
                    new DANodeDescriptor(itemIdTextBox.Text) { NodePath = nodePathTextBox.Text },
                    propertyTextBox.Text);
            }
            catch (OpcException ex)
            {
                exception = ex;
            }
            propertyValueTextBox.Text = (value is null) ? "(null)" :
                String.Format(CultureInfo.CurrentCulture, "{0}", value);
            DisplayException(exception);
        }

        /// <summary>
        /// Gets or sets whether there is currently a subscription to an OPC item.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The method enables or disables corresponding controls on the form.</para>
        /// </remarks>
        public bool IsItemSubscribed
        {
            get => _isItemSubscribed;
            set
            {
                _isItemSubscribed = value;
                subscribeItemButton.Enabled = !_isItemSubscribed;
                changeItemSubscriptionButton.Enabled = _isItemSubscribed;
                unsubscribeItemButton.Enabled = _isItemSubscribed;
            }
        }

        /// <summary>
        /// The user has pressed the "Read item" button. Attempt to read the given OPC item from the given OPC server, and
        /// display either the value-timestamp-quality, or the error received.
        /// </summary>
        private void readItemButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(itemIdTextBox.Text != null);

            DAVtq vtq = null;
            Exception exception = null;
            try
            {
                vtq = easyDAClient1.ReadItem(
                    serverUrlTextBox.Text,
                    new DAItemDescriptor(itemIdTextBox.Text) { NodePath = nodePathTextBox.Text });
            }
            catch (OpcException ex)
            {
                exception = ex;
            }
            DisplayVtq(vtq);
            DisplayException(exception);
        }

        /// <summary>
        /// The user has pressed the "Subscribe item" button. Subscribe to the given OPC item. Data will flow into the form
        /// by means of the <see cref="easyDAClient1_ItemChanged"/> event handler.
        /// </summary>
        private void subscribeItemButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(itemIdTextBox.Text != null);

            const VarTypes dataType = VarTypes.Empty;
            // ReSharper disable SuggestUseVarKeywordEvident
            int requestedUpdateRate = (int)requestedUpdateRateNumericUpDown.Value;
            float percentDeadband = (float)percentDeadbandNumericUpDown.Value;
            // ReSharper restore SuggestUseVarKeywordEvident
            _itemHandle = easyDAClient1.SubscribeItem(
                serverUrlTextBox.Text,
                new DAItemDescriptor(itemIdTextBox.Text, dataType) { NodePath = nodePathTextBox.Text }, 
                requestedUpdateRate, 
                percentDeadband);
            IsItemSubscribed = true;
        }

        /// <summary>
        /// The user has pressed the "Unsubscribe item" button. Unsubscribe from OPC item we have subscribed earlier in
        /// <see cref="subscribeItemButton_Click"/>. Data will no longer flow through the
        /// <see cref="easyDAClient1_ItemChanged"/> event handler.
        /// </summary>
        private void unsubscribeItemButton_Click(object sender, EventArgs e)
        {
            easyDAClient1.UnsubscribeItem(_itemHandle);
            _itemHandle = 0;
            IsItemSubscribed = false;
        }

        /// <summary>
        /// The user has pressed the "Write item" button. Attempt to write the value entered on the form to the given OPC
        /// item. If an error was received, display it.
        /// </summary>
        private void writeItemValueButton_Click(object sender, EventArgs e)
        {
            Debug.Assert(serverUrlTextBox.Text != null);
            Debug.Assert(itemIdTextBox.Text != null);

            object value = valueToWriteTextBox.Text;
            Exception exception = null;
            try
            {
                easyDAClient1.WriteItemValue(
                    serverUrlTextBox.Text, 
                    new DAItemDescriptor(itemIdTextBox.Text) { NodePath = nodePathTextBox.Text }, 
                    value);
            }
            catch (OpcException ex)
            {
                exception = ex;
            }
            DisplayException(exception);
        }
    }
}
