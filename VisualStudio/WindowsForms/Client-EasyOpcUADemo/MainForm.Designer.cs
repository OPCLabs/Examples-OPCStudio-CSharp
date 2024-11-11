// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using JetBrains.Annotations;

namespace EasyOpcUADemo
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
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.subscribeMonitoredItemButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.serverTimestampTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exceptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serverUriTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unsubscribeMonitoredItemButton = new System.Windows.Forms.Button();
            this.nodeIdTextBox = new System.Windows.Forms.TextBox();
            this.samplingIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.readButton = new System.Windows.Forms.Button();
            this.changeMonitoredItemSubscriptionButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hintLabel = new System.Windows.Forms.Label();
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            this.sourceTimestampTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.discoverServersButton = new System.Windows.Forms.Button();
            this.browseDataButton = new System.Windows.Forms.Button();
            this.uaDataDialog1 = new OpcLabs.EasyOpc.UA.Forms.Browsing.UADataDialog(this.components);
            this.valueToWriteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.writeValueButton = new System.Windows.Forms.Button();
            this.uaHostAndEndpointDialog1 = new OpcLabs.EasyOpc.UA.Forms.Browsing.UAHostAndEndpointDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.samplingIntervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDataDialog1)).BeginInit();
            this.SuspendLayout();
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(460, 147);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(176, 20);
            this.valueTextBox.TabIndex = 0;
            // 
            // subscribeMonitoredItemButton
            // 
            this.subscribeMonitoredItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribeMonitoredItemButton.Location = new System.Drawing.Point(218, 171);
            this.subscribeMonitoredItemButton.Name = "subscribeMonitoredItemButton";
            this.subscribeMonitoredItemButton.Size = new System.Drawing.Size(118, 23);
            this.subscribeMonitoredItemButton.TabIndex = 1;
            this.subscribeMonitoredItemButton.Text = "Su&bscribe";
            this.subscribeMonitoredItemButton.UseVisualStyleBackColor = true;
            this.subscribeMonitoredItemButton.Click += new System.EventHandler(this.subscribeButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(460, 174);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(176, 20);
            this.statusTextBox.TabIndex = 2;
            // 
            // serverTimestampTextBox
            // 
            this.serverTimestampTextBox.Location = new System.Drawing.Point(460, 232);
            this.serverTimestampTextBox.Name = "serverTimestampTextBox";
            this.serverTimestampTextBox.ReadOnly = true;
            this.serverTimestampTextBox.Size = new System.Drawing.Size(176, 20);
            this.serverTimestampTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server timestamp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status:";
            // 
            // exceptionTextBox
            // 
            this.exceptionTextBox.Location = new System.Drawing.Point(5, 299);
            this.exceptionTextBox.Multiline = true;
            this.exceptionTextBox.Name = "exceptionTextBox";
            this.exceptionTextBox.ReadOnly = true;
            this.exceptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exceptionTextBox.Size = new System.Drawing.Size(755, 90);
            this.exceptionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exception:";
            // 
            // serverUriTextBox
            // 
            this.serverUriTextBox.Location = new System.Drawing.Point(72, 44);
            this.serverUriTextBox.Name = "serverUriTextBox";
            this.serverUriTextBox.Size = new System.Drawing.Size(284, 20);
            this.serverUriTextBox.TabIndex = 14;
            this.serverUriTextBox.Text = "opc.tcp://opcua.demo-this.com:51210/UA/SampleServer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server &Uri:";
            // 
            // unsubscribeMonitoredItemButton
            // 
            this.unsubscribeMonitoredItemButton.Enabled = false;
            this.unsubscribeMonitoredItemButton.Location = new System.Drawing.Point(218, 229);
            this.unsubscribeMonitoredItemButton.Name = "unsubscribeMonitoredItemButton";
            this.unsubscribeMonitoredItemButton.Size = new System.Drawing.Size(118, 23);
            this.unsubscribeMonitoredItemButton.TabIndex = 16;
            this.unsubscribeMonitoredItemButton.Text = "&Unsubscribe";
            this.unsubscribeMonitoredItemButton.UseVisualStyleBackColor = true;
            this.unsubscribeMonitoredItemButton.Click += new System.EventHandler(this.unsubscribeButton_Click);
            // 
            // nodeIdTextBox
            // 
            this.nodeIdTextBox.Location = new System.Drawing.Point(72, 73);
            this.nodeIdTextBox.Name = "nodeIdTextBox";
            this.nodeIdTextBox.Size = new System.Drawing.Size(284, 20);
            this.nodeIdTextBox.TabIndex = 17;
            this.nodeIdTextBox.Text = "nsu=http://test.org/UA/Data/ ;i=10854";
            // 
            // samplingIntervalNumericUpDown
            // 
            this.samplingIntervalNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.samplingIntervalNumericUpDown.Location = new System.Drawing.Point(132, 171);
            this.samplingIntervalNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.samplingIntervalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.samplingIntervalNumericUpDown.Name = "samplingIntervalNumericUpDown";
            this.samplingIntervalNumericUpDown.Size = new System.Drawing.Size(80, 20);
            this.samplingIntervalNumericUpDown.TabIndex = 18;
            this.samplingIntervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.samplingIntervalNumericUpDown.ThousandsSeparator = true;
            this.samplingIntervalNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Node &Id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sampling interval (ms):";
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(218, 112);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(118, 23);
            this.readButton.TabIndex = 22;
            this.readButton.Text = "&Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // changeMonitoredItemSubscriptionButton
            // 
            this.changeMonitoredItemSubscriptionButton.Enabled = false;
            this.changeMonitoredItemSubscriptionButton.Location = new System.Drawing.Point(218, 200);
            this.changeMonitoredItemSubscriptionButton.Name = "changeMonitoredItemSubscriptionButton";
            this.changeMonitoredItemSubscriptionButton.Size = new System.Drawing.Size(118, 23);
            this.changeMonitoredItemSubscriptionButton.TabIndex = 28;
            this.changeMonitoredItemSubscriptionButton.Text = "C&hange subscription";
            this.changeMonitoredItemSubscriptionButton.UseVisualStyleBackColor = true;
            this.changeMonitoredItemSubscriptionButton.Click += new System.EventHandler(this.changeSubscriptionButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(685, 44);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(75, 23);
            this.aboutButton.TabIndex = 35;
            this.aboutButton.Text = "&About...";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(685, 70);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 35;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(5, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 1);
            this.panel1.TabIndex = 36;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(2, 9);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(357, 13);
            this.hintLabel.TabIndex = 37;
            this.hintLabel.Text = "Hint: Press the \"Subscribe\" button to see dynamically changing OPC data.";
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyUAClient1_DataChangeNotification);
            // 
            // sourceTimestampTextBox
            // 
            this.sourceTimestampTextBox.Location = new System.Drawing.Point(460, 202);
            this.sourceTimestampTextBox.Name = "sourceTimestampTextBox";
            this.sourceTimestampTextBox.ReadOnly = true;
            this.sourceTimestampTextBox.Size = new System.Drawing.Size(176, 20);
            this.sourceTimestampTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Source timestamp:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(234, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Monitored item:";
            // 
            // discoverServersButton
            // 
            this.discoverServersButton.Location = new System.Drawing.Point(362, 42);
            this.discoverServersButton.Name = "discoverServersButton";
            this.discoverServersButton.Size = new System.Drawing.Size(112, 23);
            this.discoverServersButton.TabIndex = 40;
            this.discoverServersButton.Text = "< Browse servers...";
            this.discoverServersButton.UseVisualStyleBackColor = true;
            this.discoverServersButton.Click += new System.EventHandler(this.discoverServersButton_Click);
            // 
            // browseDataButton
            // 
            this.browseDataButton.Location = new System.Drawing.Point(362, 70);
            this.browseDataButton.Name = "browseDataButton";
            this.browseDataButton.Size = new System.Drawing.Size(112, 23);
            this.browseDataButton.TabIndex = 41;
            this.browseDataButton.Text = "< Browse data...";
            this.browseDataButton.UseVisualStyleBackColor = true;
            this.browseDataButton.Click += new System.EventHandler(this.browseDataButton_Click);
            // 
            // valueToWriteTextBox
            // 
            this.valueToWriteTextBox.Location = new System.Drawing.Point(460, 115);
            this.valueToWriteTextBox.Name = "valueToWriteTextBox";
            this.valueToWriteTextBox.Size = new System.Drawing.Size(176, 20);
            this.valueToWriteTextBox.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Value to write:";
            // 
            // writeValueButton
            // 
            this.writeValueButton.Location = new System.Drawing.Point(641, 113);
            this.writeValueButton.Name = "writeValueButton";
            this.writeValueButton.Size = new System.Drawing.Size(118, 23);
            this.writeValueButton.TabIndex = 22;
            this.writeValueButton.Text = "&Write value";
            this.writeValueButton.UseVisualStyleBackColor = true;
            this.writeValueButton.Click += new System.EventHandler(this.writeValueButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(772, 394);
            this.Controls.Add(this.browseDataButton);
            this.Controls.Add(this.discoverServersButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.changeMonitoredItemSubscriptionButton);
            this.Controls.Add(this.writeValueButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.samplingIntervalNumericUpDown);
            this.Controls.Add(this.nodeIdTextBox);
            this.Controls.Add(this.unsubscribeMonitoredItemButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverUriTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exceptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceTimestampTextBox);
            this.Controls.Add(this.serverTimestampTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.subscribeMonitoredItemButton);
            this.Controls.Add(this.valueToWriteTextBox);
            this.Controls.Add(this.valueTextBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EasyOPC-UA Demo Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samplingIntervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uaDataDialog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button subscribeMonitoredItemButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox serverTimestampTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exceptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverUriTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button unsubscribeMonitoredItemButton;
        private System.Windows.Forms.TextBox nodeIdTextBox;
        private System.Windows.Forms.NumericUpDown samplingIntervalNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button changeMonitoredItemSubscriptionButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.TextBox sourceTimestampTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button discoverServersButton;
        private System.Windows.Forms.Button browseDataButton;
        private OpcLabs.EasyOpc.UA.Forms.Browsing.UADataDialog uaDataDialog1;
        private System.Windows.Forms.TextBox valueToWriteTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button writeValueButton;
        private OpcLabs.EasyOpc.UA.Forms.Browsing.UAHostAndEndpointDialog uaHostAndEndpointDialog1;
    }
}

