namespace LiveBindingDemo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint1 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint2 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint3 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint4 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint5 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint6 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint7 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint8 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters daItemPointSubscribeParameters1 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint9 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters daItemPointSubscribeParameters2 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint10 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters daItemPointSubscribeParameters3 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPointSubscribeParameters();
            OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint daItemPoint11 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAItemPoint();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bindingKindsTabPage = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.conversionsTabPage = new System.Windows.Forms.TabPage();
            this.writeFahrenheitButton = new System.Windows.Forms.Button();
            this.writeCelsiusButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.animationsTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.cumulativeTabPage = new System.Windows.Forms.TabPage();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bindingExtender1 = new OpcLabs.BaseLib.LiveBinding.BindingExtender();
            this.pointBinding1 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding2 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding3 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding6 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.celsiusToFahrenheitConverter = new OpcLabs.BaseLib.Components.LinearConverter();
            this.pointBinding7 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding5 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding4 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding8 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.linearConverter1 = new OpcLabs.BaseLib.Components.LinearConverter();
            this.pointBinding9 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.linearConverter2 = new OpcLabs.BaseLib.Components.LinearConverter();
            this.pointBinding10 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.pointBinding11 = new OpcLabs.BaseLib.LiveBinding.PointBinding();
            this.daConnectivity1 = new OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity();
            this.pointBinder1 = new OpcLabs.BaseLib.LiveBinding.PointBinder();
            this.tabControl1.SuspendLayout();
            this.bindingKindsTabPage.SuspendLayout();
            this.conversionsTabPage.SuspendLayout();
            this.animationsTabPage.SuspendLayout();
            this.cumulativeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingExtender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daConnectivity1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.bindingKindsTabPage);
            this.tabControl1.Controls.Add(this.conversionsTabPage);
            this.tabControl1.Controls.Add(this.animationsTabPage);
            this.tabControl1.Controls.Add(this.cumulativeTabPage);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(759, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // bindingKindsTabPage
            // 
            this.bindingKindsTabPage.Controls.Add(this.label3);
            this.bindingKindsTabPage.Controls.Add(this.label2);
            this.bindingKindsTabPage.Controls.Add(this.label1);
            this.bindingKindsTabPage.Controls.Add(this.textBox3);
            this.bindingKindsTabPage.Controls.Add(this.textBox2);
            this.bindingKindsTabPage.Controls.Add(this.textBox1);
            this.bindingKindsTabPage.Controls.Add(this.richTextBox2);
            this.bindingKindsTabPage.Controls.Add(this.richTextBox1);
            this.bindingKindsTabPage.Location = new System.Drawing.Point(4, 22);
            this.bindingKindsTabPage.Name = "bindingKindsTabPage";
            this.bindingKindsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.bindingKindsTabPage.Size = new System.Drawing.Size(751, 511);
            this.bindingKindsTabPage.TabIndex = 1;
            this.bindingKindsTabPage.Text = "Binding Kinds";
            this.bindingKindsTabPage.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Timestamp in local time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Timestamp in UTC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Value:";
            // 
            // textBox3
            // 
            this.bindingExtender1.SetBindingBag(this.textBox3, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding1))}));
            this.textBox3.Location = new System.Drawing.Point(353, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.bindingExtender1.SetBindingBag(this.textBox2, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding2))}));
            this.textBox2.Location = new System.Drawing.Point(353, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.bindingExtender1.SetBindingBag(this.textBox1, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding3))}));
            this.textBox1.Location = new System.Drawing.Point(85, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(6, 66);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(739, 20);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "When binding a timestamp, you can select between a time expressed in UTC, or in l" +
    "ocal time. Below is a value shown with both forms of its timestamp.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(6, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(739, 33);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // conversionsTabPage
            // 
            this.conversionsTabPage.Controls.Add(this.writeFahrenheitButton);
            this.conversionsTabPage.Controls.Add(this.writeCelsiusButton);
            this.conversionsTabPage.Controls.Add(this.label5);
            this.conversionsTabPage.Controls.Add(this.label4);
            this.conversionsTabPage.Controls.Add(this.textBox6);
            this.conversionsTabPage.Controls.Add(this.textBox7);
            this.conversionsTabPage.Controls.Add(this.textBox5);
            this.conversionsTabPage.Controls.Add(this.textBox);
            this.conversionsTabPage.Controls.Add(this.richTextBox4);
            this.conversionsTabPage.Controls.Add(this.richTextBox3);
            this.conversionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.conversionsTabPage.Name = "conversionsTabPage";
            this.conversionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.conversionsTabPage.Size = new System.Drawing.Size(751, 511);
            this.conversionsTabPage.TabIndex = 0;
            this.conversionsTabPage.Text = "Conversions";
            this.conversionsTabPage.UseVisualStyleBackColor = true;
            // 
            // writeFahrenheitButton
            // 
            this.writeFahrenheitButton.Location = new System.Drawing.Point(251, 193);
            this.writeFahrenheitButton.Name = "writeFahrenheitButton";
            this.writeFahrenheitButton.Size = new System.Drawing.Size(60, 23);
            this.writeFahrenheitButton.TabIndex = 11;
            this.writeFahrenheitButton.Text = "Write";
            this.writeFahrenheitButton.UseVisualStyleBackColor = true;
            // 
            // writeCelsiusButton
            // 
            this.writeCelsiusButton.Location = new System.Drawing.Point(77, 193);
            this.writeCelsiusButton.Name = "writeCelsiusButton";
            this.writeCelsiusButton.Size = new System.Drawing.Size(60, 23);
            this.writeCelsiusButton.TabIndex = 10;
            this.writeCelsiusButton.Text = "Write";
            this.writeCelsiusButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fahrenheit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Celsius:";
            // 
            // textBox6
            // 
            this.bindingExtender1.SetBindingBag(this.textBox6, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding6))}));
            this.textBox6.Location = new System.Drawing.Point(251, 231);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(60, 20);
            this.textBox6.TabIndex = 7;
            // 
            // textBox7
            // 
            this.bindingExtender1.SetBindingBag(this.textBox7, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding7))}));
            this.textBox7.Location = new System.Drawing.Point(77, 231);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(60, 20);
            this.textBox7.TabIndex = 6;
            // 
            // textBox5
            // 
            this.bindingExtender1.SetBindingBag(this.textBox5, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding5))}));
            this.textBox5.Location = new System.Drawing.Point(251, 166);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(60, 20);
            this.textBox5.TabIndex = 5;
            // 
            // textBox
            // 
            this.bindingExtender1.SetBindingBag(this.textBox, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding4))}));
            this.textBox.Location = new System.Drawing.Point(77, 166);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(60, 20);
            this.textBox.TabIndex = 4;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(6, 63);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(739, 56);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(6, 15);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(739, 33);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // animationsTabPage
            // 
            this.animationsTabPage.Controls.Add(this.button1);
            this.animationsTabPage.Controls.Add(this.richTextBox6);
            this.animationsTabPage.Controls.Add(this.richTextBox5);
            this.animationsTabPage.Location = new System.Drawing.Point(4, 22);
            this.animationsTabPage.Name = "animationsTabPage";
            this.animationsTabPage.Size = new System.Drawing.Size(751, 511);
            this.animationsTabPage.TabIndex = 2;
            this.animationsTabPage.Text = "Animations";
            this.animationsTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bindingExtender1.SetBindingBag(this.button1, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding8)),
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding9))}));
            this.button1.Location = new System.Drawing.Point(100, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "*";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Location = new System.Drawing.Point(9, 67);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(739, 33);
            this.richTextBox6.TabIndex = 4;
            this.richTextBox6.Text = "Below, the Left and Top properties of a Button are bound to a value with sinus ou" +
    "tput. Two LinearConverter components are used to convert the incoming values int" +
    "o proper screen coordinates.";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Location = new System.Drawing.Point(9, 15);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(739, 33);
            this.richTextBox5.TabIndex = 3;
            this.richTextBox5.Text = "Binding to layout properties of controls, such as to their location or size, prov" +
    "ides a convenient way to create animations.";
            // 
            // cumulativeTabPage
            // 
            this.cumulativeTabPage.Controls.Add(this.richTextBox9);
            this.cumulativeTabPage.Controls.Add(this.listBox1);
            this.cumulativeTabPage.Controls.Add(this.richTextBox8);
            this.cumulativeTabPage.Controls.Add(this.richTextBox7);
            this.cumulativeTabPage.Controls.Add(this.listView1);
            this.cumulativeTabPage.Location = new System.Drawing.Point(4, 22);
            this.cumulativeTabPage.Name = "cumulativeTabPage";
            this.cumulativeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cumulativeTabPage.Size = new System.Drawing.Size(751, 511);
            this.cumulativeTabPage.TabIndex = 3;
            this.cumulativeTabPage.Text = "Cumulative";
            this.cumulativeTabPage.UseVisualStyleBackColor = true;
            // 
            // richTextBox9
            // 
            this.richTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Location = new System.Drawing.Point(403, 66);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.Size = new System.Drawing.Size(342, 62);
            this.richTextBox9.TabIndex = 7;
            this.richTextBox9.Text = "Similarly, we can bind to the Items.Add method of the ListView. Each incoming val" +
    "ue will create a new item in the ListView.";
            // 
            // listBox1
            // 
            this.bindingExtender1.SetBindingBag(this.listBox1, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding10))}));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 355);
            this.listBox1.TabIndex = 6;
            // 
            // richTextBox8
            // 
            this.richTextBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Location = new System.Drawing.Point(6, 66);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(342, 62);
            this.richTextBox8.TabIndex = 5;
            this.richTextBox8.Text = resources.GetString("richTextBox8.Text");
            // 
            // richTextBox7
            // 
            this.richTextBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Location = new System.Drawing.Point(6, 17);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(739, 33);
            this.richTextBox7.TabIndex = 4;
            this.richTextBox7.Text = "The binding does not have to show the most recent value only. When you bind to co" +
    "ntrols that are designed to represent data sets, you can keep the old data while" +
    " adding new.";
            // 
            // listView1
            // 
            this.bindingExtender1.SetBindingBag(this.listView1, new OpcLabs.BaseLib.LiveBinding.BindingBag(new OpcLabs.BaseLib.LiveBinding.IAbstractBinding[] {
                ((OpcLabs.BaseLib.LiveBinding.IAbstractBinding)(this.pointBinding11))}));
            this.listView1.Location = new System.Drawing.Point(418, 137);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(287, 355);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // bindingExtender1
            // 
            this.bindingExtender1.OfflineEventSource.SourceComponent = this;
            this.bindingExtender1.OfflineEventSource.SourcePath = "FormClosing";
            this.bindingExtender1.OnlineEventSource.SourceComponent = this;
            this.bindingExtender1.OnlineEventSource.SourcePath = "Shown";
            // 
            // pointBinding1
            // 
            this.pointBinding1.ArgumentsPath = "TimestampLocal";
            daItemPoint1.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Demo.Single", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Demo",
                "Single"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint1.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding1.Point = daItemPoint1;
            this.pointBinding1.StringFormat = "{0:G}";
            this.pointBinding1.ValueTarget.TargetComponent = this.textBox3;
            this.pointBinding1.ValueTarget.TargetPath = "Text";
            // 
            // pointBinding2
            // 
            this.pointBinding2.ArgumentsPath = "Timestamp";
            daItemPoint2.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Demo.Single", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Demo",
                "Single"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint2.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding2.Point = daItemPoint2;
            this.pointBinding2.StringFormat = "{0:G}";
            this.pointBinding2.ValueTarget.TargetComponent = this.textBox2;
            this.pointBinding2.ValueTarget.TargetPath = "Text";
            // 
            // pointBinding3
            // 
            this.pointBinding3.ArgumentsPath = "Value";
            daItemPoint3.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Demo.Single", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Demo",
                "Single"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint3.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding3.Point = daItemPoint3;
            this.pointBinding3.ValueTarget.TargetComponent = this.textBox1;
            this.pointBinding3.ValueTarget.TargetPath = "Text";
            // 
            // pointBinding6
            // 
            this.pointBinding6.ArgumentsPath = "Value";
            this.pointBinding6.Converter = this.celsiusToFahrenheitConverter;
            daItemPoint4.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Register_R4", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Register_R4"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint4.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding6.Point = daItemPoint4;
            this.pointBinding6.ValueTarget.TargetComponent = this.textBox6;
            this.pointBinding6.ValueTarget.TargetPath = "Text";
            // 
            // celsiusToFahrenheitConverter
            // 
            this.celsiusToFahrenheitConverter.Y1 = 32D;
            this.celsiusToFahrenheitConverter.Y2 = 212D;
            // 
            // pointBinding7
            // 
            this.pointBinding7.ArgumentsPath = "Value";
            daItemPoint5.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Register_R4", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Register_R4"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint5.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding7.Point = daItemPoint5;
            this.pointBinding7.ValueTarget.TargetComponent = this.textBox7;
            this.pointBinding7.ValueTarget.TargetPath = "Text";
            // 
            // pointBinding5
            // 
            this.pointBinding5.ArgumentsPath = "Value";
            this.pointBinding5.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write;
            this.pointBinding5.Converter = this.celsiusToFahrenheitConverter;
            daItemPoint6.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Register_R4", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Register_R4"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint6.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding5.Point = daItemPoint6;
            this.pointBinding5.ValueTarget.TargetComponent = this.textBox5;
            this.pointBinding5.ValueTarget.TargetPath = "Text";
            this.pointBinding5.WriteEventSource.SourceComponent = this.writeFahrenheitButton;
            this.pointBinding5.WriteEventSource.SourcePath = "Click";
            // 
            // pointBinding4
            // 
            this.pointBinding4.ArgumentsPath = "Value";
            this.pointBinding4.BindingOperations = OpcLabs.BaseLib.LiveBinding.PointBindingOperations.Write;
            daItemPoint7.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Register_R4", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Register_R4"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint7.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding4.Point = daItemPoint7;
            this.pointBinding4.ValueTarget.TargetComponent = this.textBox;
            this.pointBinding4.ValueTarget.TargetPath = "Text";
            this.pointBinding4.WriteEventSource.SourceComponent = this.writeCelsiusButton;
            this.pointBinding4.WriteEventSource.SourcePath = "Click";
            // 
            // pointBinding8
            // 
            this.pointBinding8.ArgumentsPath = "Value";
            this.pointBinding8.Converter = this.linearConverter1;
            daItemPoint8.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Sine (10 s)", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Sine (10 s)"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint8.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding8.Point = daItemPoint8;
            daItemPointSubscribeParameters1.RequestedUpdateRate = 100;
            this.pointBinding8.SubscribeParameters = daItemPointSubscribeParameters1;
            this.pointBinding8.ValueTarget.TargetComponent = this.button1;
            this.pointBinding8.ValueTarget.TargetPath = "Left";
            // 
            // linearConverter1
            // 
            this.linearConverter1.X1 = -1D;
            this.linearConverter1.X2 = 1D;
            this.linearConverter1.Y1 = 100D;
            this.linearConverter1.Y2 = 200D;
            // 
            // pointBinding9
            // 
            this.pointBinding9.ArgumentsPath = "Value";
            this.pointBinding9.Converter = this.linearConverter2;
            daItemPoint9.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Sine (10 s)", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Sine (10 s)"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint9.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding9.Point = daItemPoint9;
            daItemPointSubscribeParameters2.RequestedUpdateRate = 100;
            this.pointBinding9.SubscribeParameters = daItemPointSubscribeParameters2;
            this.pointBinding9.ValueTarget.TargetComponent = this.button1;
            this.pointBinding9.ValueTarget.TargetPath = "Top";
            // 
            // linearConverter2
            // 
            this.linearConverter2.X1 = -1D;
            this.linearConverter2.X2 = 1D;
            this.linearConverter2.Y1 = 120D;
            this.linearConverter2.Y2 = 220D;
            // 
            // pointBinding10
            // 
            this.pointBinding10.ArgumentsPath = "Vtq";
            daItemPoint10.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Ramp 0:100 (10 min)", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Ramp 0:100 (10 min)"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint10.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding10.Point = daItemPoint10;
            daItemPointSubscribeParameters3.RequestedUpdateRate = 10000;
            this.pointBinding10.SubscribeParameters = daItemPointSubscribeParameters3;
            this.pointBinding10.ValueTarget.TargetComponent = this.listBox1;
            this.pointBinding10.ValueTarget.TargetPath = "Items.Add";
            // 
            // pointBinding11
            // 
            this.pointBinding11.ArgumentsPath = "Value";
            daItemPoint11.ItemDescriptor = new OpcLabs.EasyOpc.DataAccess.DAItemDescriptor("", "Simulation.Random (10 s)", new OpcLabs.BaseLib.Navigation.BrowsePath(new string[] {
                "Simulation",
                "Random (10 s)"}), new OpcLabs.BaseLib.ComInterop.VarType(), "");
            daItemPoint11.ServerDescriptor = new OpcLabs.EasyOpc.ServerDescriptor("opcda:OPCLabs.KitServer.2/%7Bc8a12f17-1e03-401e-b53d-6c654dd576da%7D");
            this.pointBinding11.Point = daItemPoint11;
            this.pointBinding11.StringFormat = "{0:F3}";
            this.pointBinding11.ValueTarget.TargetComponent = this.listView1;
            this.pointBinding11.ValueTarget.TargetPath = "Items.Add(System.String)";
            // 
            // pointBinder1
            // 
            this.pointBinder1.BindingExtender = this.bindingExtender1;
            this.pointBinder1.Connectivity = this.daConnectivity1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Live Binding Demo 2 in Windows Forms";
            this.tabControl1.ResumeLayout(false);
            this.bindingKindsTabPage.ResumeLayout(false);
            this.bindingKindsTabPage.PerformLayout();
            this.conversionsTabPage.ResumeLayout(false);
            this.conversionsTabPage.PerformLayout();
            this.animationsTabPage.ResumeLayout(false);
            this.cumulativeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingExtender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daConnectivity1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage conversionsTabPage;
        private System.Windows.Forms.TabPage bindingKindsTabPage;
        private System.Windows.Forms.TabPage animationsTabPage;
        private System.Windows.Forms.TabPage cumulativeTabPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private OpcLabs.BaseLib.LiveBinding.BindingExtender bindingExtender1;
        private OpcLabs.BaseLib.Components.LinearConverter celsiusToFahrenheitConverter;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button writeFahrenheitButton;
        private System.Windows.Forms.Button writeCelsiusButton;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.Button button1;
        private OpcLabs.BaseLib.Components.LinearConverter linearConverter1;
        private OpcLabs.BaseLib.Components.LinearConverter linearConverter2;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.ListView listView1;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding1;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding2;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding3;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding6;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding7;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding5;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding4;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding8;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding9;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding10;
        private OpcLabs.BaseLib.LiveBinding.PointBinding pointBinding11;
        private OpcLabs.EasyOpc.DataAccess.Connectivity.DAConnectivity daConnectivity1;
        private OpcLabs.BaseLib.LiveBinding.PointBinder pointBinder1;
    }
}

