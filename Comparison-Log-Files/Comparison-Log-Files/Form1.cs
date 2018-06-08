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
using CBELogAsTXT;
using System.Drawing.Drawing2D;

namespace Comparison_Log_Files
{
    public partial class Form1 : Form
    {
        List<LogFile> LogList = new List<LogFile>();
        public List<Cluster> clusterList = new List<Cluster>();
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
                string line = "";
                logFileData = line.Split('\n');
                int lineCounter = 0;
                bool ObtainingFound = false;

                
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

                        if (lineCounter > 200)
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
                    AddToLogListAndSave(ref columnName, message, logFileDataTable, probId, columnCount, ref endOfLog, filteredLogfile);
                    lineCounter++;
                }//end while loop 
                CompareLogs();
            }
            else
                MessageBox.Show("Are you sure the file exists??");
        }

        private void AddToLogListAndSave(ref string columnName, int message, DataTable logFileDataTable, string probId, int columnCount, ref bool endOfLog, string[] filteredLogfile)
        {
            if (endOfLog)
            {
                if (logFileDataTable != null)
                {
                    dataGridViewFiles.DataSource = logFileDataTable;
                    if (logFileDataTable.Rows.Count != 0)
                    {                     
                        columnName = SaveToTextFile(columnName, probId, columnCount);                      
                        AddDataToLogList(logFileDataTable, probId);
                        dataGridViewFiles.DataSource = null;
                        logFileDataTable.Rows.Clear();
                        filteredLogfile[message] = null;
                    }
                }
                endOfLog = false;
            }
        }

        private void CompareLogs()
        {
            long progress = 0;
            long logListSize = LogList.LongCount();

            LoadingForm load = new LoadingForm(this, logListSize, progress);
            load.Show();

            //Three lists
            //One:    Log file
            //Two:    Clusters
            //Three:  Logs similar to main cluster log     
            int index = 0;
            string source, target;
            double result = 0;
            int nonClusteredLogs = 0;
            int foundClusteredLogs = 0;
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
                   
                    if (load.iscanceled())
                    {
                        load.Close();
                        break;
                    }
                    Application.DoEvents();
                }

                if (cluster.MatchedLogs.Count() + 1 >= minCluster)
                {
                    clusterList.Add(cluster);
                }
                index++;
                progress++;
                load.setFilterprogress(progress);
            }

            foreach (var item in clusterList)
            {
                clusterNames.Add(item.MainLog.Name.ToString());
                clusterLogsCount.Add(item.MatchedLogs.Count + 1);
                foundClusteredLogs += item.MatchedLogs.Count + 1;
            }
            
            ClusterPieChart();
            nonClusteredLogs = LogList.Count() - foundClusteredLogs;

            listBoxDetails.Items.Clear();
            PopulateListBox(nonClusteredLogs, foundClusteredLogs);
           

        }

        private void PopulateListBox(int nonClusteredLogs, int foundClusteredLogs)
        {
            if (clusterList.Count > 0)
            {
                listBoxDetails.Items.Add("Number of lines : " + this.linesNumericUpDown.Text);
                listBoxDetails.Items.Add("Minimum Cluster Size : " + this.clusterNumericUpDown.Text);
                listBoxDetails.Items.Add("Tolerance Percentage : " + this.toleranceNumericUpDown.Text);
                listBoxDetails.Items.Add("----------------------------------");
                listBoxDetails.Items.Add("Total files : " + LogList.Count.ToString());
                listBoxDetails.Items.Add("Total clusters: " + clusterLogsCount.Count().ToString());
                listBoxDetails.Items.Add("Total files clustered: " + foundClusteredLogs.ToString());
                listBoxDetails.Items.Add("Number of logs not in a cluster: " + nonClusteredLogs.ToString());

                listBoxDetails.Items.Add("----------------------------------");
                listBoxDetails.Items.Add("Main Cluster Logs : ");
                foreach (var item in clusterList)
                {
                    listBoxDetails.Items.Add(item.MainLog.Name.ToString());
                }
                listBoxDetails.Items.Add("----------------------------------");
                listBoxDetails.Items.Add("Logs that match 100% : ");

                foreach (var cluster in clusterList)
                {
                    
                    foreach (var matchedLog in cluster.MatchedLogs)
                    {
                        if (matchedLog.LDvalue == 100)
                        {
                            listBoxDetails.Items.Add(matchedLog.Name.ToString() + "   Main Log = " + cluster.MainLog.Name.ToString());
                            
                        }
                    }
                }
                listBoxDetails.Items.Add("----------------------------------");
                listBoxDetails.Items.Add("Logs that match using Tolerance LD : ");
                foreach (var cluster in clusterList)
                {

                    foreach (var matchedLog in cluster.MatchedLogs)
                    {
                        if (matchedLog.LDvalue < 100 && matchedLog.LDvalue >= toleranceNumericUpDown.Value)
                        {
                            listBoxDetails.Items.Add(matchedLog.Name + " LD = " + matchedLog.LDvalue.ToString() + "%" + "   Main Log = " + cluster.MainLog.Name.ToString());
                            listBoxDetails.Items.Add("");
                        }
                    }
                }
                
            }
            else
            {
                listBoxDetails.Items.Add("No Clusters Found!");
            }
        }

        private void SaveDetails(ListBox listBoxDetails)
        {
            if (listBoxDetails.Items.Count > 1)
            {
                string filename = "";
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "TXT (*.txt)|*.txt",
                    FileName = ""
                };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    filename = sfd.FileName;
                    StreamWriter sw = new StreamWriter(filename);
                    foreach (var item in listBoxDetails.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                }              
            }
            else
                MessageBox.Show("No Details to save");
            
        }

        private void ClusterPieChart()
        {
            
            chart1.Series[0].ChartType = SeriesChartType.Pie;
            chart1.Series[0].Points.DataBindXY(clusterNames, clusterLogsCount);
            chart1.Legends[0].Enabled = true;
            chart1.Focus();
        }
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult hit = chart1.HitTest(e.X, e.Y);
            var dp = hit.Object as DataPoint;
            Cursor = (dp is null) ? Cursors.Default : Cursors.Hand;
        }
        public void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            GoToDetails(e);

        }

        public void GoToDetails(MouseEventArgs e)
        {
            string clusterName = "";
            HitTestResult hit = chart1.HitTest(e.X, e.Y, ChartElementType.DataPoint);
            if (hit.PointIndex >= 0 && hit.Series != null)
            {
                DataPoint dp = chart1.Series[0].Points[hit.PointIndex];
                clusterName = dp.AxisLabel;

            }
            ClusterDetailsForm frm2 = new ClusterDetailsForm
            {
                Owner = this
            };
            frm2.ClusterSelected(clusterName, clusterList, LogList);
            frm2.ShowDialog();
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
            string userName = Environment.UserName;
            string folderLocation = @"C:\Users\" + userName + @"\Documents\LOG_FILE_COMPARISONS";
            Directory.CreateDirectory(folderLocation);
            
            Directory.SetCurrentDirectory(folderLocation);
            string filename = "p" + probId + ".txt";
            

            using (StreamWriter sw = new StreamWriter(filename))
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
            int count = results.Count();
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
                    LDvalue = 100,
                    NumOfLines = count

                });
            }
           
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            //ClusterDetailsForm frm2 = new ClusterDetailsForm
            //{
            //    Owner = this
            //};
            ////frm2.LogName(cluster);
            //frm2.ShowDialog();
        }

        private void btnSaveListBoxDetails(object sender, EventArgs e)
        {
            SaveDetails(listBoxDetails);

        }

        private void btnGetDatabaseFile(object sender, EventArgs e)
        {
            DefaultDatabaseData();

            int maxLogs = Convert.ToInt32(maxLogsNumericUpDown.Value);
            int numofDays = Convert.ToInt32(NumOfDaysNumericUpDown.Value);
            int maxLines = Convert.ToInt32(maxLinesNumericUpDown.Value);
            string narrrative = tbxNarrative.Text;
            string outputFile = tbxOutputFileName.Text;
            string custID = tbxCustID.Text;
            SaveFileDialog sfdSaveSPTXT = new SaveFileDialog
            {
                Filter = "TXT (*.txt)|*.txt",
                FileName = outputFile
            };

            if (sfdSaveSPTXT.ShowDialog(this).Equals(DialogResult.OK))     
            {
                outputFile = sfdSaveSPTXT.FileName;
                LogAsTXT lat = new LogAsTXT();
                textBoxFilePath.Text = "Working...";
                Application.DoEvents();

                if (lat.GetLogAsTXT(maxLogs, numofDays, narrrative, custID, maxLines, outputFile))    // CORRECT NO SPACES AT THE -   CBELogAsTXT main method to call to get the data from the SQL DB in Azure
                {
                    textBoxFilePath.Text = outputFile;
                }
                else
                {
                    MessageBox.Show("CallSP Error:" + lat.GetLastError());
                    textBoxFilePath.Text = "Call SP Error..." + lat.GetLastError();
                }
            }

        }

        private void DefaultDatabaseData()
        {
            
            if (tbxNarrative.Text == "")
            {
                tbxNarrative.Text = "Unknown";
            }
            if (tbxOutputFileName.Text == "")
            {
                tbxOutputFileName.Text = "GetLogAsTxt";
            }
           
        }

        public bool GetLogAsTXT(int maxLogsToReturn, int timePeriodInDays, string searchNarrative, string custId, int maxLineCount, string outputFileName)
        {
            int maxlogs = maxLogsToReturn;
            int time = timePeriodInDays;
            string nar = searchNarrative;
            string custid = custId;
            int maxlines = maxLineCount;
            string filename = outputFileName;
            bool result = false;
            if (maxlogs <= 100)
            {
                if (time <= 32)
                {
                    if (maxlines <= 200)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.LightSlateGray, Color.LightSteelBlue, 135F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
