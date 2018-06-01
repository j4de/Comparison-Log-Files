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
                    dgvClusterDetails.DataSource = tblClusterDetails;
                }
            }

        }
        //static void Main()
        //{
        //    // ... Open specified Word file.
        //    OpenTwoFiles(@"C:\Users\markoshea\source\repos\Comparison-Log-Files2\Comparison-Log-Files\Comparison-Log-Files\bin\Debug.");
        //}

        ///// <summary>
        ///// Open specified word document.
        ///// </summary>
        //static void OpenMicrosoftWord(string file1, string file2)
        //{
        //    ProcessStartInfo startInfo = new ProcessStartInfo();
        //    startInfo.FileName = "WINWORD.EXE";
        //    startInfo.Arguments = file1;
        //    startInfo.Arguments = file2;
        //    Process.Start(startInfo);
        //}
        static void OpenTwoFile(string file1, string file2)
        {

        }
        //to open external app
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void RunComparisonBtn(object sender, EventArgs e)
        {
            string userName = Environment.UserName;
            string mainLogName = mainLogNameLabel.Text.ToString();
            string selectedLogName = dgvClusterDetails.SelectedRows[0].Cells[0].Value.ToString();
            string file1 = @"C:\Users\"+userName+@"\source\repos\Comparison-Log-Files2\Comparison-Log-Files\Comparison-Log-Files\bin\Debug\p" + mainLogName+".txt";
            string file2 = @"C:\Users\" + userName + @"\source\repos\Comparison-Log-Files2\Comparison-Log-Files\Comparison-Log-Files\bin\Debug\p" + selectedLogName+".txt";
            string app = "";
            if (txtBoxApplication.Text != "")
            {
                app = txtBoxApplication.Text;
                try
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = (app + ".exe");
                    startInfo.Arguments = file1+" "+file2;
                    //startInfo.Arguments = file2;
                    Process.Start(startInfo);
                    Thread.Sleep(500);
                    
                    //SetParent(p.MainWindowHandle, this.Handle);
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\n\nAPPLICATION NOT FOUND !!\nPerhaps you misspelt it?");
                }
            }
            else
                MessageBox.Show("Please enter the name of the application you wish to open");
        }

        
    }
}
