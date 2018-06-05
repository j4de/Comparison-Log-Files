namespace Comparison_Log_Files
{
    partial class LoadingForm
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnCancelProgress = new System.Windows.Forms.Button();
            this.lblSimilarities = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(88, 54);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(257, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnCancelProgress
            // 
            this.btnCancelProgress.Location = new System.Drawing.Point(182, 97);
            this.btnCancelProgress.Name = "btnCancelProgress";
            this.btnCancelProgress.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProgress.TabIndex = 1;
            this.btnCancelProgress.Text = "Cancel";
            this.btnCancelProgress.UseVisualStyleBackColor = true;
            this.btnCancelProgress.Click += new System.EventHandler(this.btnCancelProgress_Click);
            // 
            // lblSimilarities
            // 
            this.lblSimilarities.AutoSize = true;
            this.lblSimilarities.Location = new System.Drawing.Point(88, 33);
            this.lblSimilarities.Name = "lblSimilarities";
            this.lblSimilarities.Size = new System.Drawing.Size(150, 13);
            this.lblSimilarities.TabIndex = 2;
            this.lblSimilarities.Text = "Calculating the similarities........";
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 132);
            this.Controls.Add(this.lblSimilarities);
            this.Controls.Add(this.btnCancelProgress);
            this.Controls.Add(this.progressBar1);
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnCancelProgress;
        private System.Windows.Forms.Label lblSimilarities;
    }
}