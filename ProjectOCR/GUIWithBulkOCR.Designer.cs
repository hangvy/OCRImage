﻿namespace VietOCR.NET
{
    partial class GUIWithBulkOCR
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
            this.backgroundWorkerBulk = new System.ComponentModel.BackgroundWorker();
            this.splitContainerImage.Panel2.SuspendLayout();
            this.splitContainerImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textBox1.Size = new System.Drawing.Size(341, 373);
            this.textBox1.WordWrap = true;
            // 
            // splitContainer2
            // 
            this.splitContainerImage.Size = new System.Drawing.Size(280, 373);
            // 
            // backgroundWorkerBulk
            // 
            this.backgroundWorkerBulk.WorkerReportsProgress = true;
            this.backgroundWorkerBulk.WorkerSupportsCancellation = true;
            this.backgroundWorkerBulk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBulk_DoWork);
            this.backgroundWorkerBulk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerBulk_ProgressChanged);
            this.backgroundWorkerBulk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBulk_RunWorkerCompleted);
            // 
            // GUIWithBulkOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(668, 458);
            this.Name = "GUIWithBulkOCR";
            this.splitContainerImage.Panel2.ResumeLayout(false);
            this.splitContainerImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerBulk;
    }
}
