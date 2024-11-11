﻿
//
// Find all latest examples here: https://opclabs.doc-that.com/files/onlinedocs/OPCLabs-OpcStudio/Latest/examples.html .
// OPC client and subscriber examples in C# on GitHub: https://github.com/OPCLabs/Examples-QuickOPC-CSharp .
// Missing some example? Ask us for it on our Online Forums, https://www.opclabs.com/forum/index ! You do not have to own
// a commercial license in order to use Online Forums, and we reply to every post.

using System.Diagnostics;
using System.Windows.Forms;

namespace SymbolFactoryDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // ReSharper disable InconsistentNaming
        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        // ReSharper restore InconsistentNaming
        {
            Debug.Assert(e != null);
            Process.Start(e.LinkText);
        }
    }
}
