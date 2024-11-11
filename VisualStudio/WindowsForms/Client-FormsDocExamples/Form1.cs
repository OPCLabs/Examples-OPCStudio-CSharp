using System;
using System.Windows.Forms;

namespace FormsDocExamples
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
            _DAItemDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _OpcBrowseDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            _OpcServerDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            _AEAreaOrSourceDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            _AEAttributeDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            _AECategoryConditionDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            _AECategoryDialog.ShowDialog.Main1(this);
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            new _OpcBrowseControl.UsageForm().ShowDialog(this);
        }
    }
}
