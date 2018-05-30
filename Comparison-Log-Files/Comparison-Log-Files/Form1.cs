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
                string line = streamReader.ReadLine();
                logFileData = line.Split('\n');
                int lineCounter = 0;
                bool ObtainingFound = false;
                //stringSize = line.Length + 2;
                //progress += stringSize;
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
                    AddDataToTable( message, logFileDataTable, endOfLog, filteredLogfile);

                    //If it has reached the end of a log file
                    PutDataToFileAndList( ref columnName, message, logFileDataTable, probId, columnCount, ref endOfLog, filteredLogfile);
                    lineCounter++;
                }//end while loop   
                MessageBox.Show("Your files have been parsed and saved");
                CompareLogs();
            }
            else
                MessageBox.Show("Are you sure the file exists??");
        }

        private void PutDataToFileAndList( ref string columnName, int message, DataTable logFileDataTable, string probId, int columnCount, ref bool endOfLog, string[] filteredLogfile)
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

                    cluster.MainLog.name = log.name;
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
                                result = (source.ToLower().CalculateSimilarity(target.ToLower()) * 100);
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
            listBoxDetails.Items.Clear();
            if (clusterList.Count <= 0)
            {
                listBoxDetails.Items.Add("No Clusters Found!");
            }
            else
            {
                foreach (var item in clusterList)
                {
                    listBoxDetails.Items.Add("Cluster Name " + item.MainLog.name.ToString());
                }
            }
            
        }
        private static bool LogIsInClusterList(List<Cluster> clusterList, LogFile log)
        {
            bool logInList = false;
            foreach (var cluster in clusterList)
            {
                if (log.name.Equals(cluster.MainLog.name))
                {
                    logInList = true;
                    break;
                }
                else
                {
                    foreach (LogFile ml in cluster.MatchedLogs)
                    {
                        if (ml.name.Equals(log.name))
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
                    name = probId,
                    Signature = rowSignature,
                    LDvalue = 100

                });
            }
           
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
