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
        List<Cluster> clustListForm2;
        List<LogFile> logListForm2; 
        string clusterName = "";
        public ClusterDetailsForm()
        {
            
            InitializeComponent();

            //Set default
            txtBoxApplication.Text = "Winmerge";
            CenterToScreen();
        }

        private void backToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ClusterSelected(string cName, List<Cluster> clusterList, List<LogFile> logList)
        {
 
            clusterName = cName;
            clustListForm2 = clusterList;
            logListForm2 = logList;
            DataTable tblClusterDetails = new DataTable();
            tblClusterDetails.Columns.Add("Log File");
            tblClusterDetails.Columns.Add("Lines");
            tblClusterDetails.Columns.Add("LD");

            foreach (Cluster item in clustListForm2)
            {
                if (item.MainLog.Name.Equals(clusterName))
                {
                    mainLogNameLabel.Text = clusterName;
                    numberOfLinesLabel.Text = (item.MainLog.NumOfLines - 1).ToString();
                    
                    foreach (LogFile log in item.MatchedLogs)
                    {
                        numberOfLinesLabel.Text = (log.NumOfLines - 1).ToString();
                        
                            tblClusterDetails.Rows.Add(
                                log.Name,
                                log.NumOfLines -1,
                                log.LDvalue
                                );                     
                    }
                    dvgClusterDetails.DataSource = tblClusterDetails;
                }
            }

        }

        //to open external app
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void RunComparisonBtn(object sender, EventArgs e)
        {
            
            string app = "";
            if (txtBoxApplication.Text != "")
            {
                app = txtBoxApplication.Text;
                Process p = Process.Start(app + ".exe");
                Thread.Sleep(500);
                p.WaitForInputIdle();
                //SetParent(p.MainWindowHandle, this.Handle);
            }
            
        }

        
    }
}
