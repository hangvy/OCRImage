namespace VietOCR.NET
{
    partial class GUIWithOCR
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
            this.backgroundWorkerOcr = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImage)).BeginInit();
            this.splitContainerImage.Panel2.SuspendLayout();
            this.splitContainerImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Size = new System.Drawing.Size(638, 654);
            this.textBox1.WordWrap = true;
            // 
            // splitContainerImage
            // 
            this.splitContainerImage.Size = new System.Drawing.Size(616, 654);
            // 
            // backgroundWorkerOcr
            // 
            this.backgroundWorkerOcr.WorkerReportsProgress = true;
            this.backgroundWorkerOcr.WorkerSupportsCancellation = true;
            this.backgroundWorkerOcr.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerOcr_DoWork);
            this.backgroundWorkerOcr.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerOcr_ProgressChanged);
            this.backgroundWorkerOcr.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerOcr_RunWorkerCompleted);
            // 
            // GUIWithOCR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1284, 741);
            this.Name = "GUIWithOCR";
            this.splitContainerImage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImage)).EndInit();
            this.splitContainerImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorkerOcr;
    }
}
