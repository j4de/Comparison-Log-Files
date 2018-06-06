namespace Comparison_Log_Files
{
    partial class DatabaseDetailsForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownMaxLogs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumOfDays = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaxLogs
            // 
            this.numericUpDownMaxLogs.Location = new System.Drawing.Point(31, 65);
            this.numericUpDownMaxLogs.Name = "numericUpDownMaxLogs";
            this.numericUpDownMaxLogs.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxLogs.TabIndex = 1;
            // 
            // numericUpDownNumOfDays
            // 
            this.numericUpDownNumOfDays.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownNumOfDays.Location = new System.Drawing.Point(31, 122);
            this.numericUpDownNumOfDays.Name = "numericUpDownNumOfDays";
            this.numericUpDownNumOfDays.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNumOfDays.TabIndex = 2;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(31, 184);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown3.TabIndex = 3;
            // 
            // DatabaseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 501);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDownNumOfDays);
            this.Controls.Add(this.numericUpDownMaxLogs);
            this.Controls.Add(this.button1);
            this.Name = "DatabaseDetailsForm";
            this.Text = "DatabaseDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumOfDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxLogs;
        private System.Windows.Forms.NumericUpDown numericUpDownNumOfDays;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
    }
}