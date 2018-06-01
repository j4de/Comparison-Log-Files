using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison_Log_Files
{
    public partial class LoadingForm : Form
    {
        Form1 check;
        long totalProgress = 0;
        long sizeOfLog = 0;
        Boolean canceled = false;
        Boolean complete = false;
        public LoadingForm(Form1 frm, long logsize, long progress)
        {
            InitializeComponent();
            CenterToScreen();
            check = frm;
            sizeOfLog = logsize;
            totalProgress = progress;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }
        internal void setFilterprogress(long progress)
        {
            
            int per = (int)(((double)progress / (double)sizeOfLog) * 100);
            progressBar1.Value = per;
            if (progressBar1.Value > 99)
            {
                Close();
            }
        }

        private void btnCancelProgress_Click(object sender, EventArgs e)
        {
            canceled = true;
            lblSimilarities.Text = "Loading Cancelled";
            btnCancelProgress.Enabled = true;
        }
        internal bool iscanceled()
        {
            return canceled;
        }

        internal bool completed()
        {
            return complete;
        }
    }
}
