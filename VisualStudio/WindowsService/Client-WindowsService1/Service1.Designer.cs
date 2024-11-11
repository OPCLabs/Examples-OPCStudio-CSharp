using JetBrains.Annotations;

namespace WindowsService1
{
    partial class Service1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.easyDAClient1 = new OpcLabs.EasyOpc.DataAccess.EasyDAClient(this.components);
            // 
            // easyDAClient1
            // 
            this.easyDAClient1.ItemChanged += new OpcLabs.EasyOpc.DataAccess.EasyDAItemChangedEventHandler(this.easyDAClient1_ItemChanged);
            // 
            // Service1
            // 
            this.ServiceName = "Service1";

        }

        #endregion

        private OpcLabs.EasyOpc.DataAccess.EasyDAClient easyDAClient1;
    }
}
