using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace Comparison_Log_Files
{
    public partial class Form1 : Form
    {
        List<LogFile> LogList = new List<LogFile>();
        List<Cluster> clusterList = new List<Cluster>();
        List<string> clusterNames = new List<string>();
        List<int> clusterLogsCount = new List<int>();
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxFilePath.Text = (openFileDialog1.FileName);
            }
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            LogList.Clear();
            clusterList.Clear();
            clusterNames.Clear();
            clusterLogsCount.Clear();
            string filePath = textBoxFilePath.Text;
            string columnName = "";
            int message = 0;
            bool saveToText = false;
            DataTable logFileDataTable = new DataTable();
            logFileDataTable.Columns.Add("Message");

            if (File.Exists(filePath))
            {
                StreamReader streamReader = new StreamReader(filePath);
                string[] logFileData = new string[File.ReadAllLines(filePath).Length];

                string probId = "";
                int columnCount = 1;
                bool endOfLog = false;
                string[] filteredLogfile = new string[2];
                string line = streamReader.ReadLine();
                logFileData = line.Split('\n');
                int lineCounter = 0;
                bool ObtainingFound = false;

                saveToText = AreTheLogsToBeSaved(saveToText);

                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    logFileData = line.Split('\n');
                    foreach (var logLine in logFileData)
                    {
                        if (logLine.StartsWith("-"))
                        {
                            continue;
                        }
                        if (logLine.Length < 50)
                        {
                            if (logLine.Contains("Obtaining"))
                            {
                                probId = logLine.Substring(0, 7);
                                ObtainingFound = true;
                                continue;
                            }
                            else if (logLine.Contains("End TXT"))
                            {
                                endOfLog = true;
                            }
                            else
                                continue;
                        }
                        if (!endOfLog)
                        {
                            if (logLine.Substring(12, 1) == " ")
                            {
                                continue;
                            }
                            if (logLine.Substring(35, 3) == " ??")
                            {
                                continue;
                            }
                            filteredLogfile[message] = logFileData[0].Substring(logFileData[0].LastIndexOf('|') + 1);
                        }

                        if (lineCounter > 30)
                        {
                            if (!ObtainingFound)
                            {
                                MessageBox.Show("Please check the file is in the correct format");
                                return;
                            }

                        }

                    }//end foreach loop

                    //If it hasn't reached the end of a log file
                    AddDataToTable(message, logFileDataTable, endOfLog, filteredLogfile);

                    //If the end of a log file is reached
                    AddToLogListAndSave(ref columnName, message, saveToText, logFileDataTable, probId, columnCount, ref endOfLog, filteredLogfile);
                    lineCounter++;
                }//end while loop 
                
                MessageBox.Show("The log file has been processed");
                CompareLogs();
            }
            else
                MessageBox.Show("Are you sure the file exists??");
        }

        private void AddToLogListAndSave(ref string columnName, int message, bool saveToText, DataTable logFileDataTable, string probId, int columnCount, ref bool endOfLog, string[] filteredLogfile)
        {
            if (endOfLog)
            {
                if (logFileDataTable != null)
                {
                    dataGridViewFiles.DataSource = logFileDataTable;
                    if (logFileDataTable.Rows.Count != 0)
                    {

                        if (saveToText)
                        {
                            columnName = SaveToTextFile(columnName, probId, columnCount);
                        }

                        AddDataToLogList(logFileDataTable, probId);
                        dataGridViewFiles.DataSource = null;
                        logFileDataTable.Rows.Clear();
                        filteredLogfile[message] = null;
                    }
                }
                endOfLog = false;
            }
        }

        private static bool AreTheLogsToBeSaved(bool saveToText)
        {
            DialogResult dialogResult = MessageBox.Show("Do you wish to save the filtered logs as texts files? ", "Save Filtered Logs", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                saveToText = true;
            }

            return saveToText;
        }

        private void CompareLogs()
        {
            //Three lists
            //One:    Log file
            //Two:    Clusters
            //Three:  Logs similar to main cluster log     
            int index = 0;
            string source, target;
            double result = 0;
            int minCluster = Convert.ToInt32(clusterNumericUpDown.Value);
            double minTolerance = Convert.ToDouble(toleranceNumericUpDown.Value);
            foreach (LogFile log in LogList)
            {
                Cluster cluster = new Cluster();

                if (!LogIsInClusterList(clusterList, log))
                {

                    cluster.MainLog.Name = log.Name;
                    cluster.MainLog.Signature = log.Signature;

                    for (int nextindex = index + 1; nextindex < LogList.Count(); nextindex++)
                    {
                        if (!LogIsInClusterList(clusterList, LogList[nextindex]))
                        {


                            if (LogList[nextindex].Signature == log.Signature)
                            {
                                cluster.MatchedLogs.Add(LogList[nextindex]);

                            }
                            else
                            {
                                source = log.Signature;
                                target = LogList[nextindex].Signature;
                                result = (source.CalculateSimilarity(target) * 100);
                                if (result >= minTolerance)
                                {
                                    LogList[nextindex].LDvalue = Convert.ToInt32(result);
                                    cluster.MatchedLogs.Add(LogList[nextindex]);
                                }
                            }
                        }

                    }
                }

                if (cluster.MatchedLogs.Count() + 1 >= minCluster)
                {
                    clusterList.Add(cluster);
                }
                index++;

            }
            //public void PieChart()
            //{

            //    
            //}
            foreach (var item in clusterList)
            {
                clusterNames.Add(item.MainLog.Name.ToString());
                clusterLogsCount.Add(item.MatchedLogs.Count + 1);
            }
            ClusterPieChart();

            ///THIS IS FOR TESTING ONLY
            listBoxDetails.Items.Clear();
            if (clusterList.Count > 0)
            {
                listBoxDetails.Items.Add("Total clusters found: " + clusterList.Count.ToString());
                listBoxDetails.Items.Add("Total files clustered: " + (clusterList.Count * minCluster).ToString());
                foreach (var item in clusterList)
                {
                    listBoxDetails.Items.Add("Cluster Name " + item.MainLog.Name.ToString());
                }


            }
            else
            {
                listBoxDetails.Items.Add("No Clusters Found!");
            }

        }

        private void ClusterPieChart()
        {
            //3D Pie chart
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(clusterNames, clusterLogsCount);
            chart1.Legends[0].Enabled = true;
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Focus();
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult hit = chart1.HitTest(e.X, e.Y);
            var dp = hit.Object as DataPoint;
            Cursor = (dp is null) ? Cursors.Default : Cursors.Hand;
        }
        private static bool LogIsInClusterList(List<Cluster> clusterList, LogFile log)
        {
            bool logInList = false;
            foreach (var cluster in clusterList)
            {
                if (log.Name.Equals(cluster.MainLog.Name))
                {
                    logInList = true;
                    break;
                }
                else
                {
                    foreach (LogFile mainLog in cluster.MatchedLogs)
                    {
                        if (mainLog.Name.Equals(log.Name))
                        {
                            logInList = true;
                            break;
                        }
                    }
                    if (logInList)
                    {
                        break;
                    }
                }
            }
            return logInList;
        }


        private string SaveToTextFile(string columnName, string probId, int columnCount)
        {
            using (StreamWriter sw = new StreamWriter("p" + probId + ".txt"))
            {
                columnName = dataGridViewFiles.Columns[0].Name.ToString();
                sw.WriteLine(columnName);
                for (int i = 0; i < dataGridViewFiles.RowCount; i++)
                {
                    string rowdata = "";
                   if (dataGridViewFiles.Rows[i].Cells[0].Value != null)
                    {
                        if (dataGridViewFiles.Rows[i].Cells[0].Value.ToString() != "")
                        {
                            rowdata += dataGridViewFiles.Rows[i].Cells[0].Value.ToString() + ",";
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        continue;
                    }              
                sw.WriteLine(rowdata);
                if (i == dataGridViewFiles.RowCount)
                    break;
                }
            }
            return columnName;
        }

        private static void AddDataToTable( int message, DataTable logFileDataTable, bool endOfLog, string[] filteredLogfile)
        {
            if (!endOfLog)
            {
                if (filteredLogfile != null)
                {

                    if (filteredLogfile[message] != "Versions")
                    {
                        logFileDataTable.Rows.Add(
                           filteredLogfile[message]
                           );
                    }            
                }

            }
        }

        private void AddDataToLogList(DataTable logFileDataTable, string probId)
        {
            int minLines = Convert.ToInt32(linesNumericUpDown.Value);
            string rowSignature = "";

            var results = from myRow in logFileDataTable.AsEnumerable()
                          select myRow[0];
            var topRows = results.Reverse().Take(minLines);

            foreach (var item in topRows)
            {
                rowSignature += item.ToString();
            }
            if (rowSignature != "")
            {
                LogList.Add(new LogFile
                {
                    Name = probId,
                    Signature = rowSignature,
                    LDvalue = 100

                });
            }
           
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            ClusterDetailsForm frm2 = new ClusterDetailsForm
            {
                Owner = this
            };
            //frm2.LogName(cluster);
            frm2.ShowDialog();
        }


        //to open notepad
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void btnSaveListBoxDetails(object sender, EventArgs e)
        {
            Process p = Process.Start("notepad.exe");
        }
    }
}
