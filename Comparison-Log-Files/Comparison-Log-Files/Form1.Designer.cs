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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Automation = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxDetails = new System.Windows.Forms.ListBox();
            this.labelPieChart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxCustomerID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNarrative = new System.Windows.Forms.Label();
            this.tbxNarrative = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NumOfDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxLinesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelMaxLines = new System.Windows.Forms.Label();
            this.labelOutPutFileName = new System.Windows.Forms.Label();
            this.btnGetFromDatabase = new System.Windows.Forms.Button();
            this.lbMaxLogs = new System.Windows.Forms.Label();
            this.labelNumOfDays = new System.Windows.Forms.Label();
            this.tbxOutputFileName = new System.Windows.Forms.TextBox();
            this.maxLogsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.clusterLabel = new System.Windows.Forms.Label();
            this.clusterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.linesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.linesLabel = new System.Windows.Forms.Label();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.btnViewResults = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.btnSaveProcessed = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.lableHeading = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Automation_Settings = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.Automation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDaysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLinesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLogsNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Automation
            // 
            this.Automation.BackColor = System.Drawing.Color.Transparent;
            this.Automation.ColumnCount = 20;
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.243543F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.656826F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.125F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.875F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.904059F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.751825F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.576642F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.321168F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.79562F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.591241F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.335766F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.21168F));
            this.Automation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.5839416F));
            this.Automation.Controls.Add(this.dataGridViewFiles, 0, 0);
            this.Automation.Controls.Add(this.chart1, 1, 12);
            this.Automation.Controls.Add(this.listBoxDetails, 1, 2);
            this.Automation.Controls.Add(this.labelPieChart, 9, 11);
            this.Automation.Controls.Add(this.label1, 1, 1);
            this.Automation.Controls.Add(this.textBoxFilePath, 2, 1);
            this.Automation.Controls.Add(this.panel1, 13, 2);
            this.Automation.Controls.Add(this.panel2, 13, 13);
            this.Automation.Controls.Add(this.exitButton, 17, 22);
            this.Automation.Controls.Add(this.btnSaveProcessed, 12, 22);
            this.Automation.Controls.Add(this.browseButton, 13, 1);
            this.Automation.Controls.Add(this.lableHeading, 5, 0);
            this.Automation.Controls.Add(this.Automation_Settings, 18, 1);
            this.Automation.Controls.Add(this.btnImg, 18, 20);
            this.Automation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Automation.Location = new System.Drawing.Point(0, 0);
            this.Automation.Name = "Automation";
            this.Automation.RowCount = 24;
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.300485F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.523425F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.931973F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.555556F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.962963F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.851852F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.363368F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.361874F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.877221F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.71567F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.55412F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.01034F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.877221F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.877221F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.71567F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.55412F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.50081F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.022157F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.462585F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.931973F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.272109F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Automation.Size = new System.Drawing.Size(1370, 691);
            this.Automation.TabIndex = 0;
            this.Automation.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.Size = new System.Drawing.Size(18, 26);
            this.dataGridViewFiles.TabIndex = 0;
            this.dataGridViewFiles.Visible = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.Text;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.Automation.SetColumnSpan(this.chart1, 10);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(43, 348);
            this.chart1.Name = "chart1";
            this.Automation.SetRowSpan(this.chart1, 12);
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(700, 322);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseMove);
            // 
            // listBoxDetails
            // 
            this.listBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Automation.SetColumnSpan(this.listBoxDetails, 10);
            this.listBoxDetails.FormattingEnabled = true;
            this.listBoxDetails.Location = new System.Drawing.Point(43, 77);
            this.listBoxDetails.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.listBoxDetails.Name = "listBoxDetails";
            this.Automation.SetRowSpan(this.listBoxDetails, 10);
            this.listBoxDetails.Size = new System.Drawing.Size(700, 238);
            this.listBoxDetails.TabIndex = 16;
            // 
            // labelPieChart
            // 
            this.labelPieChart.AutoSize = true;
            this.labelPieChart.Location = new System.Drawing.Point(749, 271);
            this.labelPieChart.Name = "labelPieChart";
            this.labelPieChart.Size = new System.Drawing.Size(0, 13);
            this.labelPieChart.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Log:";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Automation.SetColumnSpan(this.textBoxFilePath, 9);
            this.textBoxFilePath.Location = new System.Drawing.Point(100, 46);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(643, 20);
            this.textBoxFilePath.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Automation.SetColumnSpan(this.panel1, 6);
            this.panel1.Controls.Add(this.comboBoxCustomerID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelNarrative);
            this.panel1.Controls.Add(this.tbxNarrative);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NumOfDaysNumericUpDown);
            this.panel1.Controls.Add(this.maxLinesNumericUpDown);
            this.panel1.Controls.Add(this.labelMaxLines);
            this.panel1.Controls.Add(this.labelOutPutFileName);
            this.panel1.Controls.Add(this.btnGetFromDatabase);
            this.panel1.Controls.Add(this.lbMaxLogs);
            this.panel1.Controls.Add(this.labelNumOfDays);
            this.panel1.Controls.Add(this.tbxOutputFileName);
            this.panel1.Controls.Add(this.maxLogsNumericUpDown);
            this.panel1.Location = new System.Drawing.Point(820, 70);
            this.panel1.Name = "panel1";
            this.Automation.SetRowSpan(this.panel1, 10);
            this.panel1.Size = new System.Drawing.Size(524, 245);
            this.panel1.TabIndex = 44;
            // 
            // comboBoxCustomerID
            // 
            this.comboBoxCustomerID.FormattingEnabled = true;
            this.comboBoxCustomerID.Location = new System.Drawing.Point(8, 61);
            this.comboBoxCustomerID.Name = "comboBoxCustomerID";
            this.comboBoxCustomerID.Size = new System.Drawing.Size(506, 21);
            this.comboBoxCustomerID.TabIndex = 45;
            this.comboBoxCustomerID.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomerID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(201, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "Database Log Options";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNarrative
            // 
            this.labelNarrative.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNarrative.AutoSize = true;
            this.labelNarrative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNarrative.Location = new System.Drawing.Point(6, 85);
            this.labelNarrative.Name = "labelNarrative";
            this.labelNarrative.Size = new System.Drawing.Size(50, 13);
            this.labelNarrative.TabIndex = 30;
            this.labelNarrative.Text = "Narrative";
            // 
            // tbxNarrative
            // 
            this.tbxNarrative.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxNarrative.Location = new System.Drawing.Point(7, 101);
            this.tbxNarrative.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbxNarrative.Name = "tbxNarrative";
            this.tbxNarrative.Size = new System.Drawing.Size(506, 20);
            this.tbxNarrative.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Customer ID";
            // 
            // NumOfDaysNumericUpDown
            // 
            this.NumOfDaysNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NumOfDaysNumericUpDown.Location = new System.Drawing.Point(279, 173);
            this.NumOfDaysNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.NumOfDaysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfDaysNumericUpDown.Name = "NumOfDaysNumericUpDown";
            this.NumOfDaysNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.NumOfDaysNumericUpDown.TabIndex = 38;
            this.NumOfDaysNumericUpDown.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // maxLinesNumericUpDown
            // 
            this.maxLinesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLinesNumericUpDown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxLinesNumericUpDown.Location = new System.Drawing.Point(99, 173);
            this.maxLinesNumericUpDown.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.maxLinesNumericUpDown.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.maxLinesNumericUpDown.Name = "maxLinesNumericUpDown";
            this.maxLinesNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.maxLinesNumericUpDown.TabIndex = 37;
            this.maxLinesNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxLines
            // 
            this.labelMaxLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelMaxLines.AutoSize = true;
            this.labelMaxLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxLines.Location = new System.Drawing.Point(38, 175);
            this.labelMaxLines.Name = "labelMaxLines";
            this.labelMaxLines.Size = new System.Drawing.Size(55, 13);
            this.labelMaxLines.TabIndex = 32;
            this.labelMaxLines.Text = "Max Lines";
            // 
            // labelOutPutFileName
            // 
            this.labelOutPutFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOutPutFileName.AutoSize = true;
            this.labelOutPutFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutPutFileName.Location = new System.Drawing.Point(4, 126);
            this.labelOutPutFileName.Name = "labelOutPutFileName";
            this.labelOutPutFileName.Size = new System.Drawing.Size(74, 13);
            this.labelOutPutFileName.TabIndex = 33;
            this.labelOutPutFileName.Text = "Out File Name";
            this.labelOutPutFileName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnGetFromDatabase
            // 
            this.btnGetFromDatabase.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGetFromDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetFromDatabase.Location = new System.Drawing.Point(350, 214);
            this.btnGetFromDatabase.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnGetFromDatabase.Name = "btnGetFromDatabase";
            this.btnGetFromDatabase.Size = new System.Drawing.Size(164, 22);
            this.btnGetFromDatabase.TabIndex = 21;
            this.btnGetFromDatabase.Text = "Get Logs From Database";
            this.btnGetFromDatabase.UseVisualStyleBackColor = true;
            this.btnGetFromDatabase.Click += new System.EventHandler(this.btnGetDatabaseFile);
            // 
            // lbMaxLogs
            // 
            this.lbMaxLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMaxLogs.AutoSize = true;
            this.lbMaxLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxLogs.Location = new System.Drawing.Point(406, 175);
            this.lbMaxLogs.Name = "lbMaxLogs";
            this.lbMaxLogs.Size = new System.Drawing.Size(53, 13);
            this.lbMaxLogs.TabIndex = 23;
            this.lbMaxLogs.Text = "Max Logs";
            // 
            // labelNumOfDays
            // 
            this.labelNumOfDays.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNumOfDays.AutoSize = true;
            this.labelNumOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumOfDays.Location = new System.Drawing.Point(209, 175);
            this.labelNumOfDays.Name = "labelNumOfDays";
            this.labelNumOfDays.Size = new System.Drawing.Size(64, 13);
            this.labelNumOfDays.TabIndex = 29;
            this.labelNumOfDays.Text = "NumOfDays";
            // 
            // tbxOutputFileName
            // 
            this.tbxOutputFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxOutputFileName.Location = new System.Drawing.Point(7, 142);
            this.tbxOutputFileName.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.tbxOutputFileName.Name = "tbxOutputFileName";
            this.tbxOutputFileName.Size = new System.Drawing.Size(506, 20);
            this.tbxOutputFileName.TabIndex = 41;
            // 
            // maxLogsNumericUpDown
            // 
            this.maxLogsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxLogsNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxLogsNumericUpDown.Location = new System.Drawing.Point(465, 173);
            this.maxLogsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxLogsNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.maxLogsNumericUpDown.Name = "maxLogsNumericUpDown";
            this.maxLogsNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.maxLogsNumericUpDown.TabIndex = 34;
            this.maxLogsNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Beige;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Automation.SetColumnSpan(this.panel2, 6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.clusterLabel);
            this.panel2.Controls.Add(this.clusterNumericUpDown);
            this.panel2.Controls.Add(this.toleranceNumericUpDown);
            this.panel2.Controls.Add(this.linesNumericUpDown);
            this.panel2.Controls.Add(this.linesLabel);
            this.panel2.Controls.Add(this.toleranceLabel);
            this.panel2.Controls.Add(this.btnViewResults);
            this.panel2.Location = new System.Drawing.Point(820, 354);
            this.panel2.Name = "panel2";
            this.Automation.SetRowSpan(this.panel2, 5);
            this.panel2.Size = new System.Drawing.Size(524, 159);
            this.panel2.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cluster Options";
            // 
            // clusterLabel
            // 
            this.clusterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clusterLabel.AutoSize = true;
            this.clusterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clusterLabel.Location = new System.Drawing.Point(34, 61);
            this.clusterLabel.Name = "clusterLabel";
            this.clusterLabel.Size = new System.Drawing.Size(59, 13);
            this.clusterLabel.TabIndex = 13;
            this.clusterLabel.Text = "Min Cluster";
            // 
            // clusterNumericUpDown
            // 
            this.clusterNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clusterNumericUpDown.Location = new System.Drawing.Point(99, 59);
            this.clusterNumericUpDown.Name = "clusterNumericUpDown";
            this.clusterNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.clusterNumericUpDown.TabIndex = 6;
            this.clusterNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // toleranceNumericUpDown
            // 
            this.toleranceNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toleranceNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(279, 59);
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.toleranceNumericUpDown.TabIndex = 7;
            this.toleranceNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // linesNumericUpDown
            // 
            this.linesNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linesNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.linesNumericUpDown.Location = new System.Drawing.Point(463, 59);
            this.linesNumericUpDown.Name = "linesNumericUpDown";
            this.linesNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.linesNumericUpDown.TabIndex = 5;
            this.linesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // linesLabel
            // 
            this.linesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesLabel.Location = new System.Drawing.Point(386, 61);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(71, 13);
            this.linesLabel.TabIndex = 11;
            this.linesLabel.Text = "Num Of Lines";
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(198, 61);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(75, 13);
            this.toleranceLabel.TabIndex = 12;
            this.toleranceLabel.Text = "LD Tolerance ";
            // 
            // btnViewResults
            // 
            this.btnViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewResults.BackColor = System.Drawing.Color.LightGray;
            this.btnViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResults.Location = new System.Drawing.Point(409, 122);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(102, 25);
            this.btnViewResults.TabIndex = 3;
            this.btnViewResults.Text = "View Results";
            this.btnViewResults.UseVisualStyleBackColor = false;
            this.btnViewResults.Click += new System.EventHandler(this.processButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Automation.SetColumnSpan(this.exitButton, 2);
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(1249, 646);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 24);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // btnSaveProcessed
            // 
            this.btnSaveProcessed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Automation.SetColumnSpan(this.btnSaveProcessed, 2);
            this.btnSaveProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProcessed.Location = new System.Drawing.Point(823, 646);
            this.btnSaveProcessed.Name = "btnSaveProcessed";
            this.btnSaveProcessed.Size = new System.Drawing.Size(102, 24);
            this.btnSaveProcessed.TabIndex = 19;
            this.btnSaveProcessed.Text = "Save List Box Details";
            this.btnSaveProcessed.UseVisualStyleBackColor = true;
            this.btnSaveProcessed.Click += new System.EventHandler(this.btnSaveListBoxDetails);
            // 
            // browseButton
            // 
            this.browseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.Location = new System.Drawing.Point(820, 43);
            this.browseButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(99, 23);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // lableHeading
            // 
            this.lableHeading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lableHeading.AutoSize = true;
            this.Automation.SetColumnSpan(this.lableHeading, 11);
            this.lableHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lableHeading.Location = new System.Drawing.Point(352, 5);
            this.lableHeading.Margin = new System.Windows.Forms.Padding(20, 0, 3, 0);
            this.lableHeading.Name = "lableHeading";
            this.lableHeading.Size = new System.Drawing.Size(644, 29);
            this.lableHeading.TabIndex = 42;
            this.lableHeading.Text = "Choose a log from the database or browse the file directory";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Automation_Settings
            // 
            this.Automation_Settings.Location = new System.Drawing.Point(1180, 42);
            this.Automation_Settings.Name = "Automation_Settings";
            this.Automation_Settings.Size = new System.Drawing.Size(171, 22);
            this.Automation_Settings.TabIndex = 46;
            this.Automation_Settings.Text = "Automation Settings";
            this.Automation_Settings.UseVisualStyleBackColor = true;
            this.Automation_Settings.Click += new System.EventHandler(this.Automation_Settings_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(1180, 589);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(75, 23);
            this.btnImg.TabIndex = 47;
            this.btnImg.Text = "test";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 691);
            this.Controls.Add(this.Automation);
            this.Name = "Form1";
            this.Text = "Log Cluster Utility";
            this.Automation.ResumeLayout(false);
            this.Automation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfDaysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLinesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxLogsNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Automation;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button btnViewResults;
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
        private System.Windows.Forms.Button btnGetFromDatabase;
        private System.Windows.Forms.Label labelOutPutFileName;
        private System.Windows.Forms.Label labelMaxLines;
        private System.Windows.Forms.Label labelNarrative;
        private System.Windows.Forms.Label labelNumOfDays;
        private System.Windows.Forms.Label lbMaxLogs;
        private System.Windows.Forms.TextBox tbxNarrative;
        private System.Windows.Forms.NumericUpDown maxLinesNumericUpDown;
        private System.Windows.Forms.NumericUpDown NumOfDaysNumericUpDown;
        private System.Windows.Forms.NumericUpDown maxLogsNumericUpDown;
        private System.Windows.Forms.TextBox tbxOutputFileName;
        private System.Windows.Forms.Label lableHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxCustomerID;
        private System.Windows.Forms.Button Automation_Settings;
        private System.Windows.Forms.Button btnImg;
    }
}

