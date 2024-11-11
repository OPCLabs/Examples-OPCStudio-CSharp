
namespace FormsDocExamples._OpcBrowseControl
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
            this.opcBrowseControl1 = new OpcLabs.EasyOpc.Forms.Browsing.OpcBrowseControl();
            this.setInputsButton = new System.Windows.Forms.Button();
            this.getOutputsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.browsingEventsTextBox = new System.Windows.Forms.TextBox();
            this.outputsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.opcBrowseControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // opcBrowseControl1
            // 
            this.opcBrowseControl1.Location = new System.Drawing.Point(13, 42);
            this.opcBrowseControl1.MinimumSize = new System.Drawing.Size(135, 150);
            this.opcBrowseControl1.Name = "opcBrowseControl1";
            this.opcBrowseControl1.Size = new System.Drawing.Size(450, 300);
            this.opcBrowseControl1.TabIndex = 0;
            this.opcBrowseControl1.BrowseFailure += new OpcLabs.BaseLib.FailureEventHandler(this.opcBrowseControl1_BrowseFailure);
            this.opcBrowseControl1.CurrentNodeChanged += new System.EventHandler(this.opcBrowseControl1_CurrentNodeChanged);
            this.opcBrowseControl1.NodeDoubleClick += new System.EventHandler(this.opcBrowseControl1_NodeDoubleClick);
            this.opcBrowseControl1.SelectionChanged += new System.EventHandler(this.opcBrowseControl1_SelectionChanged);
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
            this.label1.Location = new System.Drawing.Point(479, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Browsing &events:";
            // 
            // browsingEventsTextBox
            // 
            this.browsingEventsTextBox.Location = new System.Drawing.Point(482, 59);
            this.browsingEventsTextBox.Multiline = true;
            this.browsingEventsTextBox.Name = "browsingEventsTextBox";
            this.browsingEventsTextBox.ReadOnly = true;
            this.browsingEventsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.browsingEventsTextBox.Size = new System.Drawing.Size(482, 283);
            this.browsingEventsTextBox.TabIndex = 4;
            // 
            // outputsTextBox
            // 
            this.outputsTextBox.Location = new System.Drawing.Point(13, 379);
            this.outputsTextBox.Multiline = true;
            this.outputsTextBox.Name = "outputsTextBox";
            this.outputsTextBox.ReadOnly = true;
            this.outputsTextBox.Size = new System.Drawing.Size(951, 68);
            this.outputsTextBox.TabIndex = 5;
            // 
            // UsageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 450);
            this.Controls.Add(this.outputsTextBox);
            this.Controls.Add(this.browsingEventsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getOutputsButton);
            this.Controls.Add(this.setInputsButton);
            this.Controls.Add(this.opcBrowseControl1);
            this.Name = "UsageForm";
            this.Text = "Usage";
            ((System.ComponentModel.ISupportInitialize)(this.opcBrowseControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpcLabs.EasyOpc.Forms.Browsing.OpcBrowseControl opcBrowseControl1;
        private System.Windows.Forms.Button setInputsButton;
        private System.Windows.Forms.Button getOutputsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox browsingEventsTextBox;
        private System.Windows.Forms.TextBox outputsTextBox;
    }
}