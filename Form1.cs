using System;
using System.Diagnostics;
using System.Windows.Forms;
using Utility;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pid = Process.GetCurrentProcess().Id;
            MinidumpWriter.MakeDump(@"c:\temp\test.dmp", pid);
        }
    }
}
