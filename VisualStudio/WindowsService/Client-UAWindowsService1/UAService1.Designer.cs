namespace UAWindowsService1
{
    partial class UAService1
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
            this.easyUAClient1 = new OpcLabs.EasyOpc.UA.EasyUAClient(this.components);
            // 
            // easyUAClient1
            // 
            this.easyUAClient1.DataChangeNotification += new OpcLabs.EasyOpc.UA.EasyUADataChangeNotificationEventHandler(this.easyUAClient1_DataChangeNotification);
            // 
            // UAService1
            // 
            this.ServiceName = "Service1";

        }

        #endregion

        private OpcLabs.EasyOpc.UA.EasyUAClient easyUAClient1;
    }
}
