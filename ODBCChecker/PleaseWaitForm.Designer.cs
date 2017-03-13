namespace ODBCChecker
{
    partial class PleaseWaitForm
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
            this.lbl_generating = new System.Windows.Forms.Label();
            this.progressBarComputers = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lbl_generating
            // 
            this.lbl_generating.AutoSize = true;
            this.lbl_generating.Location = new System.Drawing.Point(73, 30);
            this.lbl_generating.Name = "lbl_generating";
            this.lbl_generating.Size = new System.Drawing.Size(68, 13);
            this.lbl_generating.TabIndex = 0;
            this.lbl_generating.Text = "Generating...";
            // 
            // progressBarComputers
            // 
            this.progressBarComputers.Location = new System.Drawing.Point(58, 46);
            this.progressBarComputers.Name = "progressBarComputers";
            this.progressBarComputers.Size = new System.Drawing.Size(100, 23);
            this.progressBarComputers.TabIndex = 1;
            // 
            // PleaseWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 93);
            this.Controls.Add(this.progressBarComputers);
            this.Controls.Add(this.lbl_generating);
            this.Name = "PleaseWaitForm";
            this.Text = "Generating...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_generating;
        private System.Windows.Forms.ProgressBar progressBarComputers;
    }
}