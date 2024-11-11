
namespace UAFormsDocExamples._UABrowseControl
{
    partial class UsageForm
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
            this.uaBrowseControl1 = new OpcLabs.EasyOpc.UA.Forms.Browsing.UABrowseControl();
            this.setInputsButton = new System.Windows.Forms.Button();
            this.getOutputsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.outputsTextBox = new System.Windows.Forms.TextBox();
            this.browsingEventsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.uaBrowseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // uaBrowseControl1
            // 
            this.uaBrowseControl1.Location = new System.Drawing.Point(13, 42);
            this.uaBrowseControl1.MinimumSize = new System.Drawing.Size(135, 150);
            this.uaBrowseControl1.Name = "uaBrowseControl1";
            this.uaBrowseControl1.Size = new System.Drawing.Size(450, 300);
            this.uaBrowseControl1.TabIndex = 0;
            this.uaBrowseControl1.BrowseFailure += new OpcLabs.BaseLib.FailureEventHandler(this.uaBrowseControl1_BrowseFailure);
            this.uaBrowseControl1.CurrentNodeChanged += new System.EventHandler(this.uaBrowseControl1_CurrentNodeChanged);
            this.uaBrowseControl1.NodeDoubleClick += new System.EventHandler(this.uaBrowseControl1_NodeDoubleClick);
            this.uaBrowseControl1.SelectionChanged += new System.EventHandler(this.uaBrowseControl1_SelectionChanged);
            // 
            // setInputsButton
            // 
            this.setInputsButton.Location = new System.Drawing.Point(13, 13);
            this.setInputsButton.Name = "setInputsButton";
            this.setInputsButton.Size = new System.Drawing.Size(75, 23);
            this.setInputsButton.TabIndex = 1;
            this.setInputsButton.Text = "&Set inputs";
            this.setInputsButton.UseVisualStyleBackColor = true;
            this.setInputsButton.Click += new System.EventHandler(this.setInputsButton_Click);
            // 
            // getOutputsButton
            // 
            this.getOutputsButton.Location = new System.Drawing.Point(13, 349);
            this.getOutputsButton.Name = "getOutputsButton";
            this.getOutputsButton.Size = new System.Drawing.Size(75, 23);
            this.getOutputsButton.TabIndex = 2;
            this.getOutputsButton.Text = "&Get outputs";
            this.getOutputsButton.UseVisualStyleBackColor = true;
            this.getOutputsButton.Click += new System.EventHandler(this.getOutputsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Browsing events:";
            // 
            // outputsTextBox
            // 
            this.outputsTextBox.Location = new System.Drawing.Point(13, 379);
            this.outputsTextBox.Multiline = true;
            this.outputsTextBox.Name = "outputsTextBox";
            this.outputsTextBox.ReadOnly = true;
            this.outputsTextBox.Size = new System.Drawing.Size(951, 59);
            this.outputsTextBox.TabIndex = 4;
            // 
            // browsingEventsTextBox
            // 
            this.browsingEventsTextBox.Location = new System.Drawing.Point(484, 59);
            this.browsingEventsTextBox.Multiline = true;
            this.browsingEventsTextBox.Name = "browsingEventsTextBox";
            this.browsingEventsTextBox.ReadOnly = true;
            this.browsingEventsTextBox.Size = new System.Drawing.Size(480, 283);
            this.browsingEventsTextBox.TabIndex = 5;
            // 
            // UsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.browsingEventsTextBox);
            this.Controls.Add(this.outputsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getOutputsButton);
            this.Controls.Add(this.setInputsButton);
            this.Controls.Add(this.uaBrowseControl1);
            this.Name = "UsageForm";
            this.Text = "UsageForm";
            ((System.ComponentModel.ISupportInitialize)(this.uaBrowseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpcLabs.EasyOpc.UA.Forms.Browsing.UABrowseControl uaBrowseControl1;
        private System.Windows.Forms.Button setInputsButton;
        private System.Windows.Forms.Button getOutputsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputsTextBox;
        private System.Windows.Forms.TextBox browsingEventsTextBox;
    }
}