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

        public Form1()
        {
            InitializeComponent();
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
            long stringSize;
            long progress = 0;
            string filePath = textBoxFilePath.Text;
            int SD = 0;
            string columnNames = "";
            int message = 1;
            DataTable logFileDataTable = new DataTable();
            logFileDataTable.Columns.Add("SD");
            logFileDataTable.Columns.Add("Message");

            if (File.Exists(filePath))
            {
                StreamReader streamReader = new StreamReader(filePath);
                string[] logFileData = new string[File.ReadAllLines(filePath).Length];

                string probId = "";
                int columnCount = 2;
                bool endOfLog = false;
                string[] filteredLogfile = new string[2];
                string line = streamReader.ReadLine();
                logFileData = line.Split('\n');
                int lineCounter = 0;
                bool ObtainingFound = false;
                stringSize = line.Length + 2;
                progress += stringSize;
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

                            filteredLogfile[SD] = logFileData[0].Substring(36, 2);
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
                    AddDataToTable(SD, message, logFileDataTable, endOfLog, filteredLogfile);

                    //If it has reached the end of a log file
                    MoveDataToFileAndList(SD, ref columnNames, message, logFileDataTable, probId, columnCount, ref endOfLog, filteredLogfile);
                    lineCounter++;
                }//end while loop   
                MessageBox.Show("Your files have been parsed and saved");
            }
            else
                MessageBox.Show("Are you sure the file exists??");
        }

        private void MoveDataToFileAndList(int SD, ref string columnNames, int message, DataTable logFileDataTable, string probId, int columnCount, ref bool endOfLog, string[] filteredLogfile)
        {
            if (endOfLog)
            {
                if (logFileDataTable != null)
                {
                    dataGridViewFiles.DataSource = logFileDataTable;
                    if (logFileDataTable.Rows.Count != 0)
                    {
                        columnNames = SaveToTextFile(columnNames, probId, columnCount);
                        AddDataToLogList(logFileDataTable, probId);
                        dataGridViewFiles.DataSource = null;

                        logFileDataTable.Rows.Clear();
                        filteredLogfile[SD] = null;
                        filteredLogfile[message] = null;
                    }
                }
                endOfLog = false;
            }
        }

        private string SaveToTextFile(string columnNames, string probId, int columnCount)
        {
            using (StreamWriter sw = new StreamWriter("p" + probId + ".txt"))
            {

                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += dataGridViewFiles.Columns[i].Name.ToString() + ",";
                }
                //A quick hack to stop the column names from being added each time a new log file is created
                if (columnNames.Length > 7)
                {
                    columnNames = columnNames.Substring(2, 7);
                }
                sw.WriteLine(columnNames);
                for (int i = 0; i < dataGridViewFiles.RowCount; i++)
                {
                    string rowdata = "";
                    for (int j = 0; j < columnCount; j++)
                    {

                        if (dataGridViewFiles.Rows[i].Cells[j].Value != null)
                        {
                            rowdata += dataGridViewFiles.Rows[i].Cells[j].Value.ToString()+",";
                        }
                        else
                        {
                            continue;
                        }

                    }
                    sw.WriteLine(rowdata);
                    //break out of loop to avoid null object reference
                    if (i == dataGridViewFiles.RowCount)
                        break;
                }
            }

            return columnNames;
        }

        private static void AddDataToTable(int SD, int message, DataTable logFileDataTable, bool endOfLog, string[] filteredLogfile)
        {
            if (!endOfLog)
            {
                if (filteredLogfile != null)
                {
                    if (filteredLogfile[SD] != "   ")
                    {
                        if (filteredLogfile[SD] != null)
                        {
                            if (filteredLogfile[message] != "Versions")
                            {
                                logFileDataTable.Rows.Add(
                                   filteredLogfile[SD],
                                   filteredLogfile[message]
                                   );
                            }
                        }


                    }
                }

            }
        }

       

        private void AddDataToLogList(DataTable logFileDataTable, string probId)
        {
            
        }
    }
}
