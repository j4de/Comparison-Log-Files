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
using System.IO;

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
                    dgvClusterDetails.DataSource = tblClusterDetails;
                }
            }

        }
       
        //to open external app
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void RunComparisonBtn(object sender, EventArgs e)
        {
            if (dgvClusterDetails.SelectedRows.Count > 0)
            {
                string mainLogName = "p" + mainLogNameLabel.Text.ToString() + ".txt";
                string selectedLogName = "p" + dgvClusterDetails.SelectedRows[0].Cells[0].Value.ToString() + ".txt";
                string dir = Directory.GetCurrentDirectory();

                string file1 = Path.Combine(dir, mainLogName);
                string file2 = Path.Combine(dir, selectedLogName);

                string app = "";
                if (txtBoxApplication.Text != "")
                {
                    app = txtBoxApplication.Text;
                    try
                    {
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = (app + ".exe");
                        startInfo.Arguments = file1 + " " + file2;
                        Process.Start(startInfo);
                        Thread.Sleep(1000);

                    }
                    catch (Win32Exception ex)
                    {
                        MessageBox.Show(ex.ToString() + "\n\nAPPLICATION NOT FOUND !!\nPerhaps you misspelt it?");
                    }
                }
                else
                    MessageBox.Show("Please enter the name of the application you wish to open");
            }
            else
                MessageBox.Show("No file to compare !!");
        }
            

        
    }
}
