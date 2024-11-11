// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using JetBrains.Annotations;

namespace EasyOpcNetDemo
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
            this.easyDAClient1 = new OpcLabs.EasyOpc.DataAccess.EasyDAClient(this.components);
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.subscribeItemButton = new System.Windows.Forms.Button();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.timestampTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exceptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.machineNameTextBox = new System.Windows.Forms.TextBox();
            this.browseServersButton = new System.Windows.Forms.Button();
            this.serverClassTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.unsubscribeItemButton = new System.Windows.Forms.Button();
            this.itemIdTextBox = new System.Windows.Forms.TextBox();
            this.requestedUpdateRateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.browseItemsButton = new System.Windows.Forms.Button();
            this.readItemButton = new System.Windows.Forms.Button();
            this.browsePropertiesButton = new System.Windows.Forms.Button();
            this.getPropertyValueButton = new System.Windows.Forms.Button();
            this.propertyIdMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.propertyValueTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.changeItemSubscriptionButton = new System.Windows.Forms.Button();
            this.percentDeadbandNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.writeItemValueButton = new System.Windows.Forms.Button();
            this.valueToWriteTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.browseMachinesButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.computerBrowserDialog1 = new OpcLabs.BaseLib.Forms.Browsing.Specialized.ComputerBrowserDialog(this.components);
            this.opcServerDialog1 = new OpcLabs.EasyOpc.Forms.Browsing.OpcServerDialog(this.components);
            this.daPropertyDialog1 = new OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAPropertyDialog(this.components);
            this.daItemDialog1 = new OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAItemDialog(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hintLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.requestedUpdateRateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentDeadbandNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // easyDAClient1
            // 
            this.easyDAClient1.ItemChanged += new OpcLabs.EasyOpc.DataAccess.EasyDAItemChangedEventHandler(this.easyDAClient1_ItemChanged);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(436, 193);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.valueTextBox.TabIndex = 0;
            // 
            // subscribeItemButton
            // 
            this.subscribeItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribeItemButton.Location = new System.Drawing.Point(218, 191);
            this.subscribeItemButton.Name = "subscribeItemButton";
            this.subscribeItemButton.Size = new System.Drawing.Size(118, 23);
            this.subscribeItemButton.TabIndex = 1;
            this.subscribeItemButton.Text = "Su&bscribe item";
            this.subscribeItemButton.UseVisualStyleBackColor = true;
            this.subscribeItemButton.Click += new System.EventHandler(this.subscribeItemButton_Click);
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Location = new System.Drawing.Point(436, 252);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.ReadOnly = true;
            this.qualityTextBox.Size = new System.Drawing.Size(200, 20);
            this.qualityTextBox.TabIndex = 2;
            // 
            // timestampTextBox
            // 
            this.timestampTextBox.Location = new System.Drawing.Point(436, 222);
            this.timestampTextBox.Name = "timestampTextBox";
            this.timestampTextBox.ReadOnly = true;
            this.timestampTextBox.Size = new System.Drawing.Size(200, 20);
            this.timestampTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Timestamp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quality:";
            // 
            // exceptionTextBox
            // 
            this.exceptionTextBox.Location = new System.Drawing.Point(5, 294);
            this.exceptionTextBox.Multiline = true;
            this.exceptionTextBox.Name = "exceptionTextBox";
            this.exceptionTextBox.ReadOnly = true;
            this.exceptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.exceptionTextBox.Size = new System.Drawing.Size(755, 60);
            this.exceptionTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Exception:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "&Machine name:";
            // 
            // machineNameTextBox
            // 
            this.machineNameTextBox.Location = new System.Drawing.Point(112, 46);
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.Size = new System.Drawing.Size(224, 20);
            this.machineNameTextBox.TabIndex = 10;
            // 
            // browseServersButton
            // 
            this.browseServersButton.Location = new System.Drawing.Point(342, 70);
            this.browseServersButton.Name = "browseServersButton";
            this.browseServersButton.Size = new System.Drawing.Size(118, 23);
            this.browseServersButton.TabIndex = 11;
            this.browseServersButton.Text = "< Browse &servers...";
            this.browseServersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseServersButton.UseVisualStyleBackColor = true;
            this.browseServersButton.Click += new System.EventHandler(this.browseServersButton_Click);
            // 
            // serverClassTextBox
            // 
            this.serverClassTextBox.Location = new System.Drawing.Point(112, 72);
            this.serverClassTextBox.Name = "serverClassTextBox";
            this.serverClassTextBox.Size = new System.Drawing.Size(224, 20);
            this.serverClassTextBox.TabIndex = 14;
            this.serverClassTextBox.Text = "OPCLabs.KitServer.2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Server &class:";
            // 
            // unsubscribeItemButton
            // 
            this.unsubscribeItemButton.Enabled = false;
            this.unsubscribeItemButton.Location = new System.Drawing.Point(218, 249);
            this.unsubscribeItemButton.Name = "unsubscribeItemButton";
            this.unsubscribeItemButton.Size = new System.Drawing.Size(118, 23);
            this.unsubscribeItemButton.TabIndex = 16;
            this.unsubscribeItemButton.Text = "&Unsubscribe item";
            this.unsubscribeItemButton.UseVisualStyleBackColor = true;
            this.unsubscribeItemButton.Click += new System.EventHandler(this.unsubscribeItemButton_Click);
            // 
            // itemIdTextBox
            // 
            this.itemIdTextBox.Location = new System.Drawing.Point(112, 99);
            this.itemIdTextBox.Name = "itemIdTextBox";
            this.itemIdTextBox.Size = new System.Drawing.Size(224, 20);
            this.itemIdTextBox.TabIndex = 17;
            this.itemIdTextBox.Text = "Demo.Ramp";
            // 
            // requestedUpdateRateNumericUpDown
            // 
            this.requestedUpdateRateNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.requestedUpdateRateNumericUpDown.Location = new System.Drawing.Point(112, 191);
            this.requestedUpdateRateNumericUpDown.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.requestedUpdateRateNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.requestedUpdateRateNumericUpDown.Name = "requestedUpdateRateNumericUpDown";
            this.requestedUpdateRateNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.requestedUpdateRateNumericUpDown.TabIndex = 18;
            this.requestedUpdateRateNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.requestedUpdateRateNumericUpDown.ThousandsSeparator = true;
            this.requestedUpdateRateNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Item &ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Update &rate (ms):";
            // 
            // browseItemsButton
            // 
            this.browseItemsButton.Location = new System.Drawing.Point(342, 96);
            this.browseItemsButton.Name = "browseItemsButton";
            this.browseItemsButton.Size = new System.Drawing.Size(118, 23);
            this.browseItemsButton.TabIndex = 21;
            this.browseItemsButton.Text = "< &Browse items...";
            this.browseItemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseItemsButton.UseVisualStyleBackColor = true;
            this.browseItemsButton.Click += new System.EventHandler(this.browseItemsButton_Click);
            // 
            // readItemButton
            // 
            this.readItemButton.Location = new System.Drawing.Point(218, 158);
            this.readItemButton.Name = "readItemButton";
            this.readItemButton.Size = new System.Drawing.Size(118, 23);
            this.readItemButton.TabIndex = 22;
            this.readItemButton.Text = "&Read item";
            this.readItemButton.UseVisualStyleBackColor = true;
            this.readItemButton.Click += new System.EventHandler(this.readItemButton_Click);
            // 
            // browsePropertiesButton
            // 
            this.browsePropertiesButton.Location = new System.Drawing.Point(218, 127);
            this.browsePropertiesButton.Name = "browsePropertiesButton";
            this.browsePropertiesButton.Size = new System.Drawing.Size(118, 23);
            this.browsePropertiesButton.TabIndex = 23;
            this.browsePropertiesButton.Text = "< Browse &properties...";
            this.browsePropertiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browsePropertiesButton.UseVisualStyleBackColor = true;
            this.browsePropertiesButton.Click += new System.EventHandler(this.browsePropertiesButton_Click);
            // 
            // getPropertyValueButton
            // 
            this.getPropertyValueButton.Location = new System.Drawing.Point(342, 127);
            this.getPropertyValueButton.Name = "getPropertyValueButton";
            this.getPropertyValueButton.Size = new System.Drawing.Size(118, 23);
            this.getPropertyValueButton.TabIndex = 24;
            this.getPropertyValueButton.Text = "&Get property value";
            this.getPropertyValueButton.UseVisualStyleBackColor = true;
            this.getPropertyValueButton.Click += new System.EventHandler(this.getPropertyValueButton_Click);
            // 
            // propertyIdMaskedTextBox
            // 
            this.propertyIdMaskedTextBox.Location = new System.Drawing.Point(112, 128);
            this.propertyIdMaskedTextBox.Mask = "0000000000";
            this.propertyIdMaskedTextBox.Name = "propertyIdMaskedTextBox";
            this.propertyIdMaskedTextBox.PromptChar = ' ';
            this.propertyIdMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.propertyIdMaskedTextBox.TabIndex = 25;
            this.propertyIdMaskedTextBox.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Property I&D:";
            // 
            // propertyValueTextBox
            // 
            this.propertyValueTextBox.Location = new System.Drawing.Point(560, 127);
            this.propertyValueTextBox.Name = "propertyValueTextBox";
            this.propertyValueTextBox.ReadOnly = true;
            this.propertyValueTextBox.Size = new System.Drawing.Size(200, 20);
            this.propertyValueTextBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(476, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Property value:";
            // 
            // changeItemSubscriptionButton
            // 
            this.changeItemSubscriptionButton.Enabled = false;
            this.changeItemSubscriptionButton.Location = new System.Drawing.Point(218, 220);
            this.changeItemSubscriptionButton.Name = "changeItemSubscriptionButton";
            this.changeItemSubscriptionButton.Size = new System.Drawing.Size(118, 23);
            this.changeItemSubscriptionButton.TabIndex = 28;
            this.changeItemSubscriptionButton.Text = "C&hange subscription";
            this.changeItemSubscriptionButton.UseVisualStyleBackColor = true;
            this.changeItemSubscriptionButton.Click += new System.EventHandler(this.changeItemSubscriptionButton_Click);
            // 
            // percentDeadbandNumericUpDown
            // 
            this.percentDeadbandNumericUpDown.DecimalPlaces = 3;
            this.percentDeadbandNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.percentDeadbandNumericUpDown.Location = new System.Drawing.Point(112, 220);
            this.percentDeadbandNumericUpDown.Name = "percentDeadbandNumericUpDown";
            this.percentDeadbandNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.percentDeadbandNumericUpDown.TabIndex = 29;
            this.percentDeadbandNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Percent deadba&nd:";
            // 
            // writeItemValueButton
            // 
            this.writeItemValueButton.Location = new System.Drawing.Point(642, 156);
            this.writeItemValueButton.Name = "writeItemValueButton";
            this.writeItemValueButton.Size = new System.Drawing.Size(118, 23);
            this.writeItemValueButton.TabIndex = 31;
            this.writeItemValueButton.Text = "&Write item value";
            this.writeItemValueButton.UseVisualStyleBackColor = true;
            this.writeItemValueButton.Click += new System.EventHandler(this.writeItemValueButton_Click);
            // 
            // valueToWriteTextBox
            // 
            this.valueToWriteTextBox.Location = new System.Drawing.Point(436, 158);
            this.valueToWriteTextBox.Name = "valueToWriteTextBox";
            this.valueToWriteTextBox.Size = new System.Drawing.Size(200, 20);
            this.valueToWriteTextBox.TabIndex = 32;
            this.valueToWriteTextBox.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "&Value to write:";
            // 
            // browseMachinesButton
            // 
            this.browseMachinesButton.Location = new System.Drawing.Point(342, 43);
            this.browseMachinesButton.Name = "browseMachinesButton";
            this.browseMachinesButton.Size = new System.Drawing.Size(118, 23);
            this.browseMachinesButton.TabIndex = 34;
            this.browseMachinesButton.Text = "< Browse m&achines...";
            this.browseMachinesButton.UseVisualStyleBackColor = true;
            this.browseMachinesButton.Click += new System.EventHandler(this.browseMachinesButton_Click);
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
            // computerBrowserDialog1
            // 
            this.computerBrowserDialog1.Description = "Select machine where the OPC Server is located.";
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
            this.hintLabel.Size = new System.Drawing.Size(379, 13);
            this.hintLabel.TabIndex = 37;
            this.hintLabel.Text = "Hint: Press the \"Subscribe item\" button to see dynamically changing OPC data.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(772, 360);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.browseMachinesButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.valueToWriteTextBox);
            this.Controls.Add(this.writeItemValueButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.percentDeadbandNumericUpDown);
            this.Controls.Add(this.changeItemSubscriptionButton);
            this.Controls.Add(this.propertyValueTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.propertyIdMaskedTextBox);
            this.Controls.Add(this.getPropertyValueButton);
            this.Controls.Add(this.browsePropertiesButton);
            this.Controls.Add(this.readItemButton);
            this.Controls.Add(this.browseItemsButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.requestedUpdateRateNumericUpDown);
            this.Controls.Add(this.itemIdTextBox);
            this.Controls.Add(this.unsubscribeItemButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.serverClassTextBox);
            this.Controls.Add(this.browseServersButton);
            this.Controls.Add(this.machineNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exceptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timestampTextBox);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.subscribeItemButton);
            this.Controls.Add(this.valueTextBox);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "EasyOPC.NET Demo Application";
            ((System.ComponentModel.ISupportInitialize)(this.requestedUpdateRateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentDeadbandNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpcLabs.EasyOpc.DataAccess.EasyDAClient easyDAClient1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button subscribeItemButton;
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.TextBox timestampTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox exceptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox machineNameTextBox;
        private System.Windows.Forms.Button browseServersButton;
        private System.Windows.Forms.TextBox serverClassTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button unsubscribeItemButton;
        private System.Windows.Forms.TextBox itemIdTextBox;
        private System.Windows.Forms.NumericUpDown requestedUpdateRateNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button browseItemsButton;
        private System.Windows.Forms.Button readItemButton;
        private System.Windows.Forms.Button browsePropertiesButton;
        private System.Windows.Forms.Button getPropertyValueButton;
        private System.Windows.Forms.MaskedTextBox propertyIdMaskedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox propertyValueTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button changeItemSubscriptionButton;
        private System.Windows.Forms.NumericUpDown percentDeadbandNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button writeItemValueButton;
        private System.Windows.Forms.TextBox valueToWriteTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button browseMachinesButton;
        private System.Windows.Forms.Button aboutButton;
        private OpcLabs.BaseLib.Forms.Browsing.Specialized.ComputerBrowserDialog computerBrowserDialog1;
        private OpcLabs.EasyOpc.Forms.Browsing.OpcServerDialog opcServerDialog1;
        private OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAPropertyDialog daPropertyDialog1;
        private OpcLabs.EasyOpc.DataAccess.Forms.Browsing.DAItemDialog daItemDialog1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hintLabel;
    }
}

