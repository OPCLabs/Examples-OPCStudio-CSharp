// $Header: $ 
// Copyright (c) CODE Consulting and Development, s.r.o., Plzen. All rights reserved.

using JetBrains.Annotations;

namespace UAHmiScreen
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.writeValueTextBox = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "nsu=http://test.org/UA/Data/ ;i=10853";
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyDAClient1_DataChangeNotification);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Tag = "nsu=http://test.org/UA/Data/ ;i=10854";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 81);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Tag = "nsu=http://test.org/UA/Data/ ;i=10849";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Read-only items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Writeable item:";
            // 
            // writeValueTextBox
            // 
            this.writeValueTextBox.Location = new System.Drawing.Point(12, 131);
            this.writeValueTextBox.Name = "writeValueTextBox";
            this.writeValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.writeValueTextBox.TabIndex = 5;
            this.writeValueTextBox.Tag = "nsu=http://test.org/UA/Data/ ;i=10226";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(180, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 6;
            this.textBox5.Tag = "nsu=http://test.org/UA/Data/ ;i=10226";
            // 
            // writeButton
            // 
            this.writeButton.Location = new System.Drawing.Point(116, 131);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(58, 20);
            this.writeButton.TabIndex = 7;
            this.writeButton.Text = "&Write";
            this.writeButton.UseVisualStyleBackColor = true;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.writeValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox writeValueTextBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button writeButton;
    }
}

