namespace Comparison_Log_Files
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.labelPieChart = new System.Windows.Forms.Label();
            this.linesLabel = new System.Windows.Forms.Label();
            this.linesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clusterLabel = new System.Windows.Forms.Label();
            this.clusterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.processButton = new System.Windows.Forms.Button();
            this.pieChartInfoLabel = new System.Windows.Forms.Label();
            this.btnSaveProcessed = new System.Windows.Forms.Button();
            this.btnGetFromDatabase = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxMaxLogs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumOfDays = new System.Windows.Forms.TextBox();
            this.textBoxNarrative = new System.Windows.Forms.TextBox();
            this.textBoxCustID = new System.Windows.Forms.TextBox();
            this.textBoxMaxLines = new System.Windows.Forms.TextBox();
            this.textBoxOutputFileName = new System.Windows.Forms.TextBox();
            this.labelNumOfDays = new System.Windows.Forms.Label();
            this.labelNarrative = new System.Windows.Forms.Label();
            this.labelCustID = new System.Windows.Forms.Label();
            this.labelMaxLines = new System.Windows.Forms.Label();
            this.labelOutPutFileName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 20;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.labelOutPutFileName, 11, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMaxLines, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCustID, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNarrative, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNumOfDays, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewFiles, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 16, 18);
            this.tableLayoutPanel1.Controls.Add(this.chart1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.listBoxDetails, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPieChart, 16, 12);
            this.tableLayoutPanel1.Controls.Add(this.pieChartInfoLabel, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveProcessed, 16, 16);
            this.tableLayoutPanel1.Controls.Add(this.processButton, 16, 10);
            this.tableLayoutPanel1.Controls.Add(this.toleranceNumericUpDown, 16, 8);
            this.tableLayoutPanel1.Controls.Add(this.toleranceLabel, 16, 7);
            this.tableLayoutPanel1.Controls.Add(this.clusterNumericUpDown, 16, 6);
            this.tableLayoutPanel1.Controls.Add(this.clusterLabel, 16, 5);
            this.tableLayoutPanel1.Controls.Add(this.linesNumericUpDown, 16, 4);
            this.tableLayoutPanel1.Controls.Add(this.linesLabel, 16, 3);
            this.tableLayoutPanel1.Controls.Add(this.browseButton, 16, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnGetFromDatabase, 16, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilePath, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaxLogs, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNumOfDays, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNarrative, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCustID, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxMaxLines, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxOutputFileName, 11, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.715582F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.84115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.854369F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxFilePath, 13);
            this.textBoxFilePath.Location = new System.Drawing.Point(83, 89);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(514, 20);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // browseButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.browseButton, 3);
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(649, 86);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(108, 26);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse Files";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.Size = new System.Drawing.Size(34, 26);
            this.dataGridViewFiles.TabIndex = 0;
            this.dataGridViewFiles.Visible = false;
            // 
            // exitButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.exitButton, 3);
            this.exitButton.Location = new System.Drawing.Point(649, 598);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 26);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Log:";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.tableLayoutPanel1.SetColumnSpan(this.chart1, 14);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 310);
            this.chart1.Name = "chart1";
            this.tableLayoutPanel1.SetRowSpan(this.chart1, 10);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(554, 314);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxDetails, 14);
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(43, 118);
            this.listBoxDetails.Name = "listBoxDetails";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxDetails, 5);
            this.listBoxDetails.Size = new System.Drawing.Size(554, 147);
            this.listBoxDetails.TabIndex = 16;
            // 
            // labelPieChart
            // 
            this.labelPieChart.AutoSize = true;
            this.labelPieChart.Location = new System.Drawing.Point(649, 403);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(0, 13);
            this.labelPieChart.TabIndex = 17;
            // 
            // linesLabel
            // 
            this.linesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.linesLabel, 3);
            this.linesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesLabel.Location = new System.Drawing.Point(649, 134);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(104, 13);
            this.linesLabel.TabIndex = 11;
            this.linesLabel.Text = "Min Lines Length";
            // 
            // linesNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.linesNumericUpDown, 3);
            this.linesNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.linesNumericUpDown.Location = new System.Drawing.Point(649, 150);
            this.linesNumericUpDown.Name = "linesNumericUpDown";
            this.linesNumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.linesNumericUpDown.TabIndex = 5;
            this.linesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // clusterLabel
            // 
            this.clusterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clusterLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.clusterLabel, 3);
            this.clusterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clusterLabel.Location = new System.Drawing.Point(649, 198);
            this.clusterLabel.Name = "clusterLabel";
            this.clusterLabel.Size = new System.Drawing.Size(70, 13);
            this.clusterLabel.TabIndex = 13;
            this.clusterLabel.Text = "Min Cluster";
            // 
            // clusterNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.clusterNumericUpDown, 3);
            this.clusterNumericUpDown.Location = new System.Drawing.Point(649, 214);
            this.clusterNumericUpDown.Name = "clusterNumericUpDown";
            this.clusterNumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.clusterNumericUpDown.TabIndex = 6;
            this.clusterNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toleranceLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.toleranceLabel, 3);
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(649, 262);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(108, 13);
            this.toleranceLabel.TabIndex = 12;
            this.toleranceLabel.Text = "Min Tolerance LD";
            // 
            // toleranceNumericUpDown
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toleranceNumericUpDown, 3);
            this.toleranceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(649, 278);
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(108, 20);
            this.toleranceNumericUpDown.TabIndex = 7;
            this.toleranceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // processButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.processButton, 3);
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(649, 342);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(108, 26);
            this.processButton.TabIndex = 3;
            this.processButton.Text = "Process And Display";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // pieChartInfoLabel
            // 
            this.pieChartInfoLabel.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.pieChartInfoLabel, 12);
            this.pieChartInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieChartInfoLabel.Location = new System.Drawing.Point(123, 275);
            this.pieChartInfoLabel.Name = "pieChartInfoLabel";
            this.pieChartInfoLabel.Size = new System.Drawing.Size(0, 24);
            this.pieChartInfoLabel.TabIndex = 20;
            this.pieChartInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveProcessed
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnSaveProcessed, 3);
            this.btnSaveProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProcessed.Location = new System.Drawing.Point(649, 534);
            this.btnSaveProcessed.Name = "btnSaveProcessed";
            this.btnSaveProcessed.Size = new System.Drawing.Size(108, 26);
            this.btnSaveProcessed.TabIndex = 19;
            this.btnSaveProcessed.Text = "Save List Box Details";
            this.btnSaveProcessed.UseVisualStyleBackColor = true;
            this.btnSaveProcessed.Click += new System.EventHandler(this.btnSaveListBoxDetails);
            // 
            // btnGetFromDatabase
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnGetFromDatabase, 3);
            this.btnGetFromDatabase.Location = new System.Drawing.Point(649, 54);
            this.btnGetFromDatabase.Name = "btnGetFromDatabase";
            this.btnGetFromDatabase.Size = new System.Drawing.Size(108, 26);
            this.btnGetFromDatabase.TabIndex = 21;
            this.btnGetFromDatabase.Text = "Get From Database";
            this.btnGetFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetFromDatabase.Click += new System.EventHandler(this.btnGetDatabasFile);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxMaxLogs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxMaxLogs, 2);
            this.textBoxMaxLogs.Location = new System.Drawing.Point(43, 54);
            this.textBoxMaxLogs.Name = "textBoxMaxLogs";
            this.textBoxMaxLogs.Size = new System.Drawing.Size(74, 20);
            this.textBoxMaxLogs.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Max Logs";
            // 
            // textBoxNumOfDays
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNumOfDays, 2);
            this.textBoxNumOfDays.Location = new System.Drawing.Point(123, 54);
            this.textBoxNumOfDays.Name = "textBoxNumOfDays";
            this.textBoxNumOfDays.Size = new System.Drawing.Size(74, 20);
            this.textBoxNumOfDays.TabIndex = 24;
            // 
            // textBoxNarrative
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxNarrative, 2);
            this.textBoxNarrative.Location = new System.Drawing.Point(203, 54);
            this.textBoxNarrative.Name = "textBoxNarrative";
            this.textBoxNarrative.Size = new System.Drawing.Size(74, 20);
            this.textBoxNarrative.TabIndex = 25;
            // 
            // textBoxCustID
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxCustID, 2);
            this.textBoxCustID.Location = new System.Drawing.Point(283, 54);
            this.textBoxCustID.Name = "textBoxCustID";
            this.textBoxCustID.Size = new System.Drawing.Size(74, 20);
            this.textBoxCustID.TabIndex = 26;
            // 
            // textBoxMaxLines
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxMaxLines, 2);
            this.textBoxMaxLines.Location = new System.Drawing.Point(363, 54);
            this.textBoxMaxLines.Name = "textBoxMaxLines";
            this.textBoxMaxLines.Size = new System.Drawing.Size(74, 20);
            this.textBoxMaxLines.TabIndex = 27;
            // 
            // textBoxOutputFileName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxOutputFileName, 2);
            this.textBoxOutputFileName.Location = new System.Drawing.Point(443, 54);
            this.textBoxOutputFileName.Name = "textBoxOutputFileName";
            this.textBoxOutputFileName.Size = new System.Drawing.Size(74, 20);
            this.textBoxOutputFileName.TabIndex = 28;
            // 
            // labelNumOfDays
            // 
            this.labelNumOfDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumOfDays.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelNumOfDays, 2);
            this.labelNumOfDays.Location = new System.Drawing.Point(123, 38);
            this.labelNumOfDays.Name = "labelNumOfDays";
            this.labelNumOfDays.Size = new System.Drawing.Size(64, 13);
            this.labelNumOfDays.TabIndex = 29;
            this.labelNumOfDays.Text = "NumOfDays";
            // 
            // labelNarrative
            // 
            this.labelNarrative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNarrative.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelNarrative, 2);
            this.labelNarrative.Location = new System.Drawing.Point(203, 38);
            this.labelNarrative.Name = "labelNarrative";
            this.labelNarrative.Size = new System.Drawing.Size(50, 13);
            this.labelNarrative.TabIndex = 30;
            this.labelNarrative.Text = "Narrative";
            // 
            // labelCustID
            // 
            this.labelCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCustID.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCustID, 2);
            this.labelCustID.Location = new System.Drawing.Point(283, 38);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(39, 13);
            this.labelCustID.TabIndex = 31;
            this.labelCustID.Text = "CustID";
            // 
            // labelMaxLines
            // 
            this.labelMaxLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxLines.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelMaxLines, 2);
            this.labelMaxLines.Location = new System.Drawing.Point(363, 38);
            this.labelMaxLines.Name = "labelMaxLines";
            this.labelMaxLines.Size = new System.Drawing.Size(55, 13);
            this.labelMaxLines.TabIndex = 32;
            this.labelMaxLines.Text = "Max Lines";
            // 
            // labelOutPutFileName
            // 
            this.labelOutPutFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOutPutFileName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelOutPutFileName, 2);
            this.labelOutPutFileName.Location = new System.Drawing.Point(443, 38);
            this.labelOutPutFileName.Name = "labelOutPutFileName";
            this.labelOutPutFileName.Size = new System.Drawing.Size(74, 13);
            this.labelOutPutFileName.TabIndex = 33;
            this.labelOutPutFileName.Text = "Out File Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Log Cluster Utility";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.NumericUpDown linesNumericUpDown;
        private System.Windows.Forms.NumericUpDown clusterNumericUpDown;
        private System.Windows.Forms.NumericUpDown toleranceNumericUpDown;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.Label clusterLabel;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.ListBox listBoxDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Label labelPieChart;
        private System.Windows.Forms.Button btnSaveProcessed;
        private System.Windows.Forms.Label pieChartInfoLabel;
        private System.Windows.Forms.Button btnGetFromDatabase;
        private System.Windows.Forms.Label labelOutPutFileName;
        private System.Windows.Forms.Label labelMaxLines;
        private System.Windows.Forms.Label labelCustID;
        private System.Windows.Forms.Label labelNarrative;
        private System.Windows.Forms.Label labelNumOfDays;
        private System.Windows.Forms.TextBox textBoxMaxLogs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumOfDays;
        private System.Windows.Forms.TextBox textBoxNarrative;
        private System.Windows.Forms.TextBox textBoxCustID;
        private System.Windows.Forms.TextBox textBoxMaxLines;
        private System.Windows.Forms.TextBox textBoxOutputFileName;
    }
}

