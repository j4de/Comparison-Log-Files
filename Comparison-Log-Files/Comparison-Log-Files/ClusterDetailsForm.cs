using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Comparison_Log_Files
{
    public partial class ClusterDetailsForm : Form
    {
        public ClusterDetailsForm()
        {
            InitializeComponent();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //to open external app
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void runComparisonButton_Click(object sender, EventArgs e)
        {
            string app = "";
            if (txtBoxApplication != null)
            {
                app = txtBoxApplication.Text;
                Process p = Process.Start(app + ".exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, this.Handle);
            }
            
        }
    }
}
