namespace Comparison_Log_Files
{
    partial class AutomationForm
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
            this.labelAuto = new System.Windows.Forms.Label();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.Browse_auto = new System.Windows.Forms.Button();
            this.GetFile_auto = new System.Windows.Forms.Button();
            this.clusterLabel = new System.Windows.Forms.Label();
            this.toleranceLabel = new System.Windows.Forms.Label();
            this.linesLabel = new System.Windows.Forms.Label();
            this.clusterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.toleranceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.linesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Frequency = new System.Windows.Forms.Label();
            this.hourslbl = new System.Windows.Forms.Label();
            this.Frequency_Time = new System.Windows.Forms.NumericUpDown();
            this.Back_auto = new System.Windows.Forms.Button();
            this.Save_Auto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequency_Time)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuto
            // 
            this.labelAuto.AutoSize = true;
            this.labelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuto.Location = new System.Drawing.Point(271, 9);
            this.labelAuto.Name = "labelAuto";
            this.labelAuto.Size = new System.Drawing.Size(276, 31);
            this.labelAuto.TabIndex = 0;
            this.labelAuto.Text = "Automation Settings";
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(13, 64);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(534, 264);
            this.listBoxFiles.TabIndex = 1;
            // 
            // Browse_auto
            // 
            this.Browse_auto.Location = new System.Drawing.Point(581, 64);
            this.Browse_auto.Name = "Browse_auto";
            this.Browse_auto.Size = new System.Drawing.Size(207, 23);
            this.Browse_auto.TabIndex = 2;
            this.Browse_auto.Text = "Browse";
            this.Browse_auto.UseVisualStyleBackColor = true;
            this.Browse_auto.Click += new System.EventHandler(this.Browse_auto_Click);
            // 
            // GetFile_auto
            // 
            this.GetFile_auto.Location = new System.Drawing.Point(581, 111);
            this.GetFile_auto.Name = "GetFile_auto";
            this.GetFile_auto.Size = new System.Drawing.Size(207, 23);
            this.GetFile_auto.TabIndex = 3;
            this.GetFile_auto.Text = "Get File From Database";
            this.GetFile_auto.UseVisualStyleBackColor = true;
            // 
            // clusterLabel
            // 
            this.clusterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clusterLabel.AutoSize = true;
            this.clusterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clusterLabel.Location = new System.Drawing.Point(578, 202);
            this.clusterLabel.Name = "clusterLabel";
            this.clusterLabel.Size = new System.Drawing.Size(59, 13);
            this.clusterLabel.TabIndex = 14;
            this.clusterLabel.Text = "Min Cluster";
            // 
            // toleranceLabel
            // 
            this.toleranceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.toleranceLabel.AutoSize = true;
            this.toleranceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toleranceLabel.Location = new System.Drawing.Point(578, 248);
            this.toleranceLabel.Name = "toleranceLabel";
            this.toleranceLabel.Size = new System.Drawing.Size(75, 13);
            this.toleranceLabel.TabIndex = 15;
            this.toleranceLabel.Text = "LD Tolerance ";
            // 
            // linesLabel
            // 
            this.linesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linesLabel.AutoSize = true;
            this.linesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linesLabel.Location = new System.Drawing.Point(578, 297);
            this.linesLabel.Name = "linesLabel";
            this.linesLabel.Size = new System.Drawing.Size(71, 13);
            this.linesLabel.TabIndex = 17;
            this.linesLabel.Text = "Num Of Lines";
            // 
            // clusterNumericUpDown
            // 
            this.clusterNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clusterNumericUpDown.Location = new System.Drawing.Point(668, 195);
            this.clusterNumericUpDown.Name = "clusterNumericUpDown";
            this.clusterNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.clusterNumericUpDown.TabIndex = 19;
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
            this.toleranceNumericUpDown.Location = new System.Drawing.Point(668, 246);
            this.toleranceNumericUpDown.Name = "toleranceNumericUpDown";
            this.toleranceNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.toleranceNumericUpDown.TabIndex = 20;
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
            this.linesNumericUpDown.Location = new System.Drawing.Point(668, 290);
            this.linesNumericUpDown.Name = "linesNumericUpDown";
            this.linesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.linesNumericUpDown.TabIndex = 21;
            this.linesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(13, 343);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(169, 23);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(277, 343);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(169, 23);
            this.Remove.TabIndex = 23;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Frequency
            // 
            this.Frequency.AutoSize = true;
            this.Frequency.Location = new System.Drawing.Point(578, 348);
            this.Frequency.Name = "Frequency";
            this.Frequency.Size = new System.Drawing.Size(80, 13);
            this.Frequency.TabIndex = 24;
            this.Frequency.Text = "Run Frequency";
            // 
            // hourslbl
            // 
            this.hourslbl.AutoSize = true;
            this.hourslbl.Location = new System.Drawing.Point(753, 348);
            this.hourslbl.Name = "hourslbl";
            this.hourslbl.Size = new System.Drawing.Size(33, 13);
            this.hourslbl.TabIndex = 26;
            this.hourslbl.Text = "hours";
            // 
            // Frequency_Time
            // 
            this.Frequency_Time.Location = new System.Drawing.Point(668, 348);
            this.Frequency_Time.Name = "Frequency_Time";
            this.Frequency_Time.Size = new System.Drawing.Size(79, 20);
            this.Frequency_Time.TabIndex = 27;
            this.Frequency_Time.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // Back_auto
            // 
            this.Back_auto.Location = new System.Drawing.Point(619, 415);
            this.Back_auto.Name = "Back_auto";
            this.Back_auto.Size = new System.Drawing.Size(169, 23);
            this.Back_auto.TabIndex = 28;
            this.Back_auto.Text = "Back";
            this.Back_auto.UseVisualStyleBackColor = true;
            this.Back_auto.Click += new System.EventHandler(this.Back_auto_Click);
            // 
            // Save_Auto
            // 
            this.Save_Auto.Location = new System.Drawing.Point(420, 415);
            this.Save_Auto.Name = "Save_Auto";
            this.Save_Auto.Size = new System.Drawing.Size(169, 23);
            this.Save_Auto.TabIndex = 29;
            this.Save_Auto.Text = "Save";
            this.Save_Auto.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AutomationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save_Auto);
            this.Controls.Add(this.Back_auto);
            this.Controls.Add(this.Frequency_Time);
            this.Controls.Add(this.hourslbl);
            this.Controls.Add(this.Frequency);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.linesNumericUpDown);
            this.Controls.Add(this.toleranceNumericUpDown);
            this.Controls.Add(this.clusterNumericUpDown);
            this.Controls.Add(this.linesLabel);
            this.Controls.Add(this.toleranceLabel);
            this.Controls.Add(this.clusterLabel);
            this.Controls.Add(this.GetFile_auto);
            this.Controls.Add(this.Browse_auto);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.labelAuto);
            this.Name = "AutomationForm";
            this.Text = "AutomationForm";
            ((System.ComponentModel.ISupportInitialize)(this.clusterNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toleranceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Frequency_Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAuto;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button Browse_auto;
        private System.Windows.Forms.Button GetFile_auto;
        private System.Windows.Forms.Label clusterLabel;
        private System.Windows.Forms.Label toleranceLabel;
        private System.Windows.Forms.Label linesLabel;
        private System.Windows.Forms.NumericUpDown clusterNumericUpDown;
        private System.Windows.Forms.NumericUpDown toleranceNumericUpDown;
        private System.Windows.Forms.NumericUpDown linesNumericUpDown;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label Frequency;
        private System.Windows.Forms.Label hourslbl;
        private System.Windows.Forms.NumericUpDown Frequency_Time;
        private System.Windows.Forms.Button Back_auto;
        private System.Windows.Forms.Button Save_Auto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}