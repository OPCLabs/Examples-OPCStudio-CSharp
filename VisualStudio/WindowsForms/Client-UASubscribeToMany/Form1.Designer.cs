using JetBrains.Annotations;

namespace UASubscribeToMany
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
            this.valuesListView = new System.Windows.Forms.ListView();
            this.startButton = new System.Windows.Forms.Button();
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            this.changeCountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.elapsedTimeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changesPerSecondTextBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numberOfItemsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItemsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // valuesListView
            // 
            this.valuesListView.HideSelection = false;
            this.valuesListView.Location = new System.Drawing.Point(12, 41);
            this.valuesListView.Name = "valuesListView";
            this.valuesListView.Size = new System.Drawing.Size(568, 363);
            this.valuesListView.TabIndex = 0;
            this.valuesListView.UseCompatibleStateImageBehavior = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(505, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyUAClient1_DataChangeNotification);
            // 
            // changeCountTextBox
            // 
            this.changeCountTextBox.Location = new System.Drawing.Point(630, 57);
            this.changeCountTextBox.Name = "changeCountTextBox";
            this.changeCountTextBox.ReadOnly = true;
            this.changeCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.changeCountTextBox.TabIndex = 2;
            this.changeCountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(627, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change count:";
            // 
            // elapsedTimeTextBox
            // 
            this.elapsedTimeTextBox.Location = new System.Drawing.Point(630, 100);
            this.elapsedTimeTextBox.Name = "elapsedTimeTextBox";
            this.elapsedTimeTextBox.ReadOnly = true;
            this.elapsedTimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.elapsedTimeTextBox.TabIndex = 4;
            this.elapsedTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elapsed time [s]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Changes/second:";
            // 
            // changesPerSecondTextBox
            // 
            this.changesPerSecondTextBox.Location = new System.Drawing.Point(630, 144);
            this.changesPerSecondTextBox.Name = "changesPerSecondTextBox";
            this.changesPerSecondTextBox.ReadOnly = true;
            this.changesPerSecondTextBox.Size = new System.Drawing.Size(100, 20);
            this.changesPerSecondTextBox.TabIndex = 7;
            this.changesPerSecondTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numberOfItemsNumericUpDown
            // 
            this.numberOfItemsNumericUpDown.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numberOfItemsNumericUpDown.Location = new System.Drawing.Point(146, 12);
            this.numberOfItemsNumericUpDown.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numberOfItemsNumericUpDown.Name = "numberOfItemsNumericUpDown";
            this.numberOfItemsNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.numberOfItemsNumericUpDown.TabIndex = 8;
            this.numberOfItemsNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numberOfItemsNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "&Number of items:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberOfItemsNumericUpDown);
            this.Controls.Add(this.changesPerSecondTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elapsedTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeCountTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.valuesListView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfItemsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView valuesListView;
        private System.Windows.Forms.Button startButton;
        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
        private System.Windows.Forms.TextBox changeCountTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox elapsedTimeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changesPerSecondTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numberOfItemsNumericUpDown;
        private System.Windows.Forms.Label label4;
    }
}

