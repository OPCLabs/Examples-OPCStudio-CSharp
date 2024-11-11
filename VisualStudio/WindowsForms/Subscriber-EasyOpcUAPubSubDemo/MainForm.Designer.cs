// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using JetBrains.Annotations;
using OpcLabs.BaseLib.Forms;
using OpcLabs.EasyOpc.UA.Forms.PubSub;
using OpcLabs.EasyOpc.UA.PubSub;

namespace EasyOpcUAPubSubDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.subscribeButton = new System.Windows.Forms.Button();
            this.errorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.readyMadeSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.unsubscribeButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.subscribeDataSetArgumentsControl = new OpcLabs.BaseLib.Forms.AutomaticValueControl();
            this.uaDataSetDataControl1 = new OpcLabs.EasyOpc.UA.Forms.PubSub.UADataSetDataControl();
            this.label2 = new System.Windows.Forms.Label();
            this.easyUASubscriber1 = new OpcLabs.EasyOpc.UA.PubSub.EasyUASubscriber(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.subscribeDataSetArgumentsControl)).BeginInit();
            this.SuspendLayout();
            // 
            // subscribeButton
            // 
            this.subscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subscribeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribeButton.Location = new System.Drawing.Point(602, 89);
            this.subscribeButton.Margin = new System.Windows.Forms.Padding(2);
            this.subscribeButton.Name = "subscribeButton";
            this.subscribeButton.Size = new System.Drawing.Size(90, 25);
            this.subscribeButton.TabIndex = 5;
            this.subscribeButton.Text = "&Subscribe";
            this.subscribeButton.UseVisualStyleBackColor = true;
            this.subscribeButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // errorTextBox
            // 
            this.errorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorTextBox.Location = new System.Drawing.Point(11, 583);
            this.errorTextBox.Multiline = true;
            this.errorTextBox.Name = "errorTextBox";
            this.errorTextBox.ReadOnly = true;
            this.errorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorTextBox.Size = new System.Drawing.Size(685, 54);
            this.errorTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Ready-made settings:";
            // 
            // readyMadeSettingsComboBox
            // 
            this.readyMadeSettingsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readyMadeSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.readyMadeSettingsComboBox.Items.AddRange(new object[] {
            "None (custom)",
            "JSON messages over MQTT transport, demo publisher on the Internet",
            "UADP messages over Ethernet transport, data from capture file on disk",
            "UADP messages over Ethernet transport, demo publisher on the local network",
            "UADP messages over MQTT transport, demo publisher on the Internet",
            "UADP messages over UDP transport, demo publisher on the local network",
            "Resolving information from a PubSub binary configuration file"});
            this.readyMadeSettingsComboBox.Location = new System.Drawing.Point(126, 10);
            this.readyMadeSettingsComboBox.Name = "readyMadeSettingsComboBox";
            this.readyMadeSettingsComboBox.Size = new System.Drawing.Size(439, 21);
            this.readyMadeSettingsComboBox.TabIndex = 2;
            this.readyMadeSettingsComboBox.SelectedIndexChanged += new System.EventHandler(this.readyMadeSettingsComboBox_SelectedIndexChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.BackColor = System.Drawing.SystemColors.Info;
            this.infoLabel.Location = new System.Drawing.Point(11, 37);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(554, 28);
            this.infoLabel.TabIndex = 3;
            // 
            // unsubscribeButton
            // 
            this.unsubscribeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unsubscribeButton.Enabled = false;
            this.unsubscribeButton.Location = new System.Drawing.Point(602, 119);
            this.unsubscribeButton.Name = "unsubscribeButton";
            this.unsubscribeButton.Size = new System.Drawing.Size(90, 23);
            this.unsubscribeButton.TabIndex = 6;
            this.unsubscribeButton.Text = "&Unsubscribe";
            this.unsubscribeButton.UseVisualStyleBackColor = true;
            this.unsubscribeButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutButton.Location = new System.Drawing.Point(602, 8);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(90, 23);
            this.aboutButton.TabIndex = 0;
            this.aboutButton.Text = "&About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // subscribeDataSetArgumentsControl
            // 
            this.subscribeDataSetArgumentsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subscribeDataSetArgumentsControl.EditTypeName = "OpcLabs.EasyOpc.UA.PubSub.OperationModel.UASubscribeDataSetArguments, OpcLabs.Eas" +
    "yOpcUA";
            this.subscribeDataSetArgumentsControl.Location = new System.Drawing.Point(11, 89);
            this.subscribeDataSetArgumentsControl.Margin = new System.Windows.Forms.Padding(2);
            this.subscribeDataSetArgumentsControl.Name = "subscribeDataSetArgumentsControl";
            this.subscribeDataSetArgumentsControl.Size = new System.Drawing.Size(554, 53);
            this.subscribeDataSetArgumentsControl.TabIndex = 4;
            // 
            // uaDataSetDataControl1
            // 
            this.uaDataSetDataControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uaDataSetDataControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uaDataSetDataControl1.Location = new System.Drawing.Point(11, 154);
            this.uaDataSetDataControl1.Margin = new System.Windows.Forms.Padding(1);
            this.uaDataSetDataControl1.MinimumSize = new System.Drawing.Size(685, 131);
            this.uaDataSetDataControl1.Name = "uaDataSetDataControl1";
            this.uaDataSetDataControl1.PreciseTimeFormat = true;
            this.uaDataSetDataControl1.RequestReadWrite = false;
            this.uaDataSetDataControl1.Size = new System.Drawing.Size(685, 429);
            this.uaDataSetDataControl1.SizingGrip = false;
            this.uaDataSetDataControl1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "&Dataset subscription:";
            // 
            // easyUASubscriber1
            // 
            this.easyUASubscriber1.DataSetMessage += new OpcLabs.EasyOpc.UA.PubSub.EasyUADataSetMessageEventHandler(this.easyUASubscriber1_DataSetMessage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.unsubscribeButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.readyMadeSettingsComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subscribeDataSetArgumentsControl);
            this.Controls.Add(this.uaDataSetDataControl1);
            this.Controls.Add(this.subscribeButton);
            this.Controls.Add(this.errorTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "MainForm";
            this.Text = "EasyOPC-UA PubSub Demo Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subscribeDataSetArgumentsControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button subscribeButton;
        private UADataSetDataControl uaDataSetDataControl1;
        private AutomaticValueControl subscribeDataSetArgumentsControl;
        private System.Windows.Forms.TextBox errorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox readyMadeSettingsComboBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button unsubscribeButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Label label2;
        private EasyUASubscriber easyUASubscriber1;
    }
}

