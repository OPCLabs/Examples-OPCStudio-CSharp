using System;
using System.Windows.Forms;
using OpcLabs.EasyOpc.UA.Forms.Application;

namespace UAFormsDocExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _ComputerBrowserDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _UABrowseDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _UABrowseDialog.ShowDialog.MultiSelect(this);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _UADataDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _UAEndpointDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            _UAHostAndEndpointDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _UADataDialog.ShowDialog.MultiSelect(this);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new _UABrowseControl.UsageForm().ShowDialog(this);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            _UABrowseDialog.ShowDialog.SelectionDescriptors(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EasyUAFormsApplication.Instance.AddToSystemMenu(this);
        }
    }
}
