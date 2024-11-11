using JetBrains.Annotations;

namespace OvenControl
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
            this.easyDAClient1 = new OpcLabs.EasyOpc.DataAccess.EasyDAClient(this.components);
            this.lblUpdateRate = new System.Windows.Forms.Label();
            this.nudUpdateRate = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFanPower = new System.Windows.Forms.Label();
            this.txbFanPower = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.txbHeaterPower = new System.Windows.Forms.TextBox();
            this.lblHeaterPower = new System.Windows.Forms.Label();
            this.txbOvenTemperature = new System.Windows.Forms.TextBox();
            this.lblOvenTemperature = new System.Windows.Forms.Label();
            this.txbTemperatureSetpoint = new System.Windows.Forms.TextBox();
            this.lblTemperatureSetpoint = new System.Windows.Forms.Label();
            this.txbNewTemperatureSetpoint = new System.Windows.Forms.TextBox();
            this.lblNewTemperatureSetPoint = new System.Windows.Forms.Label();
            this.btnSetTemperatureSetpoint = new System.Windows.Forms.Button();
            this.txbHeaterTemperature = new System.Windows.Forms.TextBox();
            this.lblHeaterTemperature = new System.Windows.Forms.Label();
            this.txbFanSpeed = new System.Windows.Forms.TextBox();
            this.lblFanSpeed = new System.Windows.Forms.Label();
            this.txbExceptions = new System.Windows.Forms.TextBox();
            this.lblExceptions = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateRate)).BeginInit();
            this.SuspendLayout();
            // 
            // easyDAClient1
            // 
            // 
            // lblUpdateRate
            // 
            this.lblUpdateRate.AutoSize = true;
            this.lblUpdateRate.Location = new System.Drawing.Point(31, 43);
            this.lblUpdateRate.Name = "lblUpdateRate";
            this.lblUpdateRate.Size = new System.Drawing.Size(80, 13);
            this.lblUpdateRate.TabIndex = 6;
            this.lblUpdateRate.Text = "Update rate [s]:";
            this.lblUpdateRate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nudUpdateRate
            // 
            this.nudUpdateRate.Location = new System.Drawing.Point(117, 41);
            this.nudUpdateRate.Name = "nudUpdateRate";
            this.nudUpdateRate.Size = new System.Drawing.Size(162, 20);
            this.nudUpdateRate.TabIndex = 7;
            this.nudUpdateRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(469, 38);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(13, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 1);
            this.panel1.TabIndex = 10;
            // 
            // lblFanPower
            // 
            this.lblFanPower.AutoSize = true;
            this.lblFanPower.Location = new System.Drawing.Point(51, 93);
            this.lblFanPower.Name = "lblFanPower";
            this.lblFanPower.Size = new System.Drawing.Size(60, 13);
            this.lblFanPower.TabIndex = 11;
            this.lblFanPower.Text = "Fan power:";
            this.lblFanPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbFanPower
            // 
            this.txbFanPower.Location = new System.Drawing.Point(117, 90);
            this.txbFanPower.Name = "txbFanPower";
            this.txbFanPower.ReadOnly = true;
            this.txbFanPower.Size = new System.Drawing.Size(88, 20);
            this.txbFanPower.TabIndex = 12;
            this.txbFanPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(550, 38);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txbHeaterPower
            // 
            this.txbHeaterPower.Location = new System.Drawing.Point(117, 116);
            this.txbHeaterPower.Name = "txbHeaterPower";
            this.txbHeaterPower.ReadOnly = true;
            this.txbHeaterPower.Size = new System.Drawing.Size(88, 20);
            this.txbHeaterPower.TabIndex = 14;
            this.txbHeaterPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeaterPower
            // 
            this.lblHeaterPower.AutoSize = true;
            this.lblHeaterPower.Location = new System.Drawing.Point(37, 119);
            this.lblHeaterPower.Name = "lblHeaterPower";
            this.lblHeaterPower.Size = new System.Drawing.Size(74, 13);
            this.lblHeaterPower.TabIndex = 13;
            this.lblHeaterPower.Text = "Heater power:";
            this.lblHeaterPower.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbOvenTemperature
            // 
            this.txbOvenTemperature.Location = new System.Drawing.Point(117, 142);
            this.txbOvenTemperature.Name = "txbOvenTemperature";
            this.txbOvenTemperature.ReadOnly = true;
            this.txbOvenTemperature.Size = new System.Drawing.Size(88, 20);
            this.txbOvenTemperature.TabIndex = 16;
            this.txbOvenTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOvenTemperature
            // 
            this.lblOvenTemperature.AutoSize = true;
            this.lblOvenTemperature.Location = new System.Drawing.Point(16, 145);
            this.lblOvenTemperature.Name = "lblOvenTemperature";
            this.lblOvenTemperature.Size = new System.Drawing.Size(95, 13);
            this.lblOvenTemperature.TabIndex = 15;
            this.lblOvenTemperature.Text = "Oven temperature:";
            this.lblOvenTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbTemperatureSetpoint
            // 
            this.txbTemperatureSetpoint.Location = new System.Drawing.Point(275, 142);
            this.txbTemperatureSetpoint.Name = "txbTemperatureSetpoint";
            this.txbTemperatureSetpoint.ReadOnly = true;
            this.txbTemperatureSetpoint.Size = new System.Drawing.Size(88, 20);
            this.txbTemperatureSetpoint.TabIndex = 18;
            this.txbTemperatureSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTemperatureSetpoint
            // 
            this.lblTemperatureSetpoint.AutoSize = true;
            this.lblTemperatureSetpoint.Location = new System.Drawing.Point(219, 145);
            this.lblTemperatureSetpoint.Name = "lblTemperatureSetpoint";
            this.lblTemperatureSetpoint.Size = new System.Drawing.Size(50, 13);
            this.lblTemperatureSetpoint.TabIndex = 17;
            this.lblTemperatureSetpoint.Text = "SetPoint:";
            this.lblTemperatureSetpoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbNewTemperatureSetpoint
            // 
            this.txbNewTemperatureSetpoint.Location = new System.Drawing.Point(456, 142);
            this.txbNewTemperatureSetpoint.Name = "txbNewTemperatureSetpoint";
            this.txbNewTemperatureSetpoint.Size = new System.Drawing.Size(88, 20);
            this.txbNewTemperatureSetpoint.TabIndex = 20;
            this.txbNewTemperatureSetpoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblNewTemperatureSetPoint
            // 
            this.lblNewTemperatureSetPoint.AutoSize = true;
            this.lblNewTemperatureSetPoint.Location = new System.Drawing.Point(378, 145);
            this.lblNewTemperatureSetPoint.Name = "lblNewTemperatureSetPoint";
            this.lblNewTemperatureSetPoint.Size = new System.Drawing.Size(72, 13);
            this.lblNewTemperatureSetPoint.TabIndex = 19;
            this.lblNewTemperatureSetPoint.Text = "New setpoint:";
            this.lblNewTemperatureSetPoint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnSetTemperatureSetpoint
            // 
            this.btnSetTemperatureSetpoint.Location = new System.Drawing.Point(550, 142);
            this.btnSetTemperatureSetpoint.Name = "btnSetTemperatureSetpoint";
            this.btnSetTemperatureSetpoint.Size = new System.Drawing.Size(75, 23);
            this.btnSetTemperatureSetpoint.TabIndex = 21;
            this.btnSetTemperatureSetpoint.Text = "Set";
            this.btnSetTemperatureSetpoint.UseVisualStyleBackColor = true;
            this.btnSetTemperatureSetpoint.Click += new System.EventHandler(this.btnSetTemperatureSetpoint_Click);
            // 
            // txbHeaterTemperature
            // 
            this.txbHeaterTemperature.Location = new System.Drawing.Point(117, 168);
            this.txbHeaterTemperature.Name = "txbHeaterTemperature";
            this.txbHeaterTemperature.ReadOnly = true;
            this.txbHeaterTemperature.Size = new System.Drawing.Size(88, 20);
            this.txbHeaterTemperature.TabIndex = 23;
            this.txbHeaterTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeaterTemperature
            // 
            this.lblHeaterTemperature.AutoSize = true;
            this.lblHeaterTemperature.Location = new System.Drawing.Point(10, 171);
            this.lblHeaterTemperature.Name = "lblHeaterTemperature";
            this.lblHeaterTemperature.Size = new System.Drawing.Size(101, 13);
            this.lblHeaterTemperature.TabIndex = 22;
            this.lblHeaterTemperature.Text = "Heater temperature:";
            this.lblHeaterTemperature.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbFanSpeed
            // 
            this.txbFanSpeed.Location = new System.Drawing.Point(117, 194);
            this.txbFanSpeed.Name = "txbFanSpeed";
            this.txbFanSpeed.ReadOnly = true;
            this.txbFanSpeed.Size = new System.Drawing.Size(88, 20);
            this.txbFanSpeed.TabIndex = 25;
            this.txbFanSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblFanSpeed
            // 
            this.lblFanSpeed.AutoSize = true;
            this.lblFanSpeed.Location = new System.Drawing.Point(51, 197);
            this.lblFanSpeed.Name = "lblFanSpeed";
            this.lblFanSpeed.Size = new System.Drawing.Size(60, 13);
            this.lblFanSpeed.TabIndex = 24;
            this.lblFanSpeed.Text = "Fan speed:";
            this.lblFanSpeed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txbExceptions
            // 
            this.txbExceptions.Location = new System.Drawing.Point(13, 240);
            this.txbExceptions.Multiline = true;
            this.txbExceptions.Name = "txbExceptions";
            this.txbExceptions.ReadOnly = true;
            this.txbExceptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbExceptions.Size = new System.Drawing.Size(611, 81);
            this.txbExceptions.TabIndex = 27;
            this.txbExceptions.WordWrap = false;
            // 
            // lblExceptions
            // 
            this.lblExceptions.AutoSize = true;
            this.lblExceptions.Location = new System.Drawing.Point(13, 221);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(62, 13);
            this.lblExceptions.TabIndex = 26;
            this.lblExceptions.Text = "Exceptions:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(550, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "For application description, please see the Readme.txt file in the project.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 329);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblExceptions);
            this.Controls.Add(this.txbExceptions);
            this.Controls.Add(this.txbFanSpeed);
            this.Controls.Add(this.lblFanSpeed);
            this.Controls.Add(this.txbHeaterTemperature);
            this.Controls.Add(this.lblHeaterTemperature);
            this.Controls.Add(this.btnSetTemperatureSetpoint);
            this.Controls.Add(this.txbNewTemperatureSetpoint);
            this.Controls.Add(this.lblNewTemperatureSetPoint);
            this.Controls.Add(this.txbTemperatureSetpoint);
            this.Controls.Add(this.lblTemperatureSetpoint);
            this.Controls.Add(this.txbOvenTemperature);
            this.Controls.Add(this.lblOvenTemperature);
            this.Controls.Add(this.txbHeaterPower);
            this.Controls.Add(this.lblHeaterPower);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.txbFanPower);
            this.Controls.Add(this.lblFanPower);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.nudUpdateRate);
            this.Controls.Add(this.lblUpdateRate);
            this.Name = "Form1";
            this.Text = "OPC Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudUpdateRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpcLabs.EasyOpc.DataAccess.EasyDAClient easyDAClient1;
        private System.Windows.Forms.Label lblUpdateRate;
        private System.Windows.Forms.NumericUpDown nudUpdateRate;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFanPower;
        private System.Windows.Forms.TextBox txbFanPower;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txbHeaterPower;
        private System.Windows.Forms.Label lblHeaterPower;
        private System.Windows.Forms.TextBox txbOvenTemperature;
        private System.Windows.Forms.Label lblOvenTemperature;
        private System.Windows.Forms.TextBox txbTemperatureSetpoint;
        private System.Windows.Forms.Label lblTemperatureSetpoint;
        private System.Windows.Forms.TextBox txbNewTemperatureSetpoint;
        private System.Windows.Forms.Label lblNewTemperatureSetPoint;
        private System.Windows.Forms.Button btnSetTemperatureSetpoint;
        private System.Windows.Forms.TextBox txbHeaterTemperature;
        private System.Windows.Forms.Label lblHeaterTemperature;
        private System.Windows.Forms.TextBox txbFanSpeed;
        private System.Windows.Forms.Label lblFanSpeed;
        private System.Windows.Forms.TextBox txbExceptions;
        private System.Windows.Forms.Label lblExceptions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}

