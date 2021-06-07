
namespace monextra_backup
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backupProgress = new System.Windows.Forms.ProgressBar();
            this.backupButton = new System.Windows.Forms.Button();
            this.selectDriveButton = new System.Windows.Forms.Button();
            this.buLabel = new System.Windows.Forms.Label();
            this.selectedBuLabel = new System.Windows.Forms.Label();
            this.compressionWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // backupProgress
            // 
            this.backupProgress.Location = new System.Drawing.Point(13, 112);
            this.backupProgress.Name = "backupProgress";
            this.backupProgress.Size = new System.Drawing.Size(376, 23);
            this.backupProgress.TabIndex = 1;
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backupButton.Location = new System.Drawing.Point(206, 36);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(105, 65);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Run Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // selectDriveButton
            // 
            this.selectDriveButton.Location = new System.Drawing.Point(92, 36);
            this.selectDriveButton.Name = "selectDriveButton";
            this.selectDriveButton.Size = new System.Drawing.Size(105, 65);
            this.selectDriveButton.TabIndex = 3;
            this.selectDriveButton.Text = "Options";
            this.selectDriveButton.UseVisualStyleBackColor = true;
            this.selectDriveButton.Click += new System.EventHandler(this.selectDriveButton_Click);
            // 
            // buLabel
            // 
            this.buLabel.AutoSize = true;
            this.buLabel.ForeColor = System.Drawing.Color.Red;
            this.buLabel.Location = new System.Drawing.Point(13, 9);
            this.buLabel.Name = "buLabel";
            this.buLabel.Size = new System.Drawing.Size(79, 15);
            this.buLabel.TabIndex = 4;
            this.buLabel.Text = "Backup Drive:";
            // 
            // selectedBuLabel
            // 
            this.selectedBuLabel.AutoSize = true;
            this.selectedBuLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectedBuLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedBuLabel.ForeColor = System.Drawing.Color.Red;
            this.selectedBuLabel.Location = new System.Drawing.Point(98, 9);
            this.selectedBuLabel.Name = "selectedBuLabel";
            this.selectedBuLabel.Size = new System.Drawing.Size(14, 15);
            this.selectedBuLabel.TabIndex = 5;
            this.selectedBuLabel.Text = "C";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 145);
            this.Controls.Add(this.selectedBuLabel);
            this.Controls.Add(this.buLabel);
            this.Controls.Add(this.selectDriveButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.backupProgress);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Computerlink Backup Utility";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar backupProgress;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button selectDriveButton;
        private System.Windows.Forms.Label buLabel;
        private System.Windows.Forms.Label selectedBuLabel;
        private System.ComponentModel.BackgroundWorker compressionWorker;
    }
}

