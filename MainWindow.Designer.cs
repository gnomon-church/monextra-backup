
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backupButton = new System.Windows.Forms.Button();
            this.selectDriveButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.driveLetterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 127);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backupButton.Location = new System.Drawing.Point(206, 45);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(105, 65);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Run Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // selectDriveButton
            // 
            this.selectDriveButton.Location = new System.Drawing.Point(92, 45);
            this.selectDriveButton.Name = "selectDriveButton";
            this.selectDriveButton.Size = new System.Drawing.Size(105, 65);
            this.selectDriveButton.TabIndex = 3;
            this.selectDriveButton.Text = "Options";
            this.selectDriveButton.UseVisualStyleBackColor = true;
            this.selectDriveButton.Click += new System.EventHandler(this.selectDriveButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.ForeColor = System.Drawing.Color.Red;
            this.descriptionLabel.Location = new System.Drawing.Point(13, 13);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(136, 15);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = "Currently Selected Drive:";
            // 
            // driveLetterLabel
            // 
            this.driveLetterLabel.AutoSize = true;
            this.driveLetterLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.driveLetterLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.driveLetterLabel.ForeColor = System.Drawing.Color.Red;
            this.driveLetterLabel.Location = new System.Drawing.Point(148, 13);
            this.driveLetterLabel.Name = "driveLetterLabel";
            this.driveLetterLabel.Size = new System.Drawing.Size(0, 15);
            this.driveLetterLabel.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 163);
            this.Controls.Add(this.driveLetterLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.selectDriveButton);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.progressBar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Computerlink Backup Utility";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button backupButton;
        private System.Windows.Forms.Button selectDriveButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label driveLetterLabel;
    }
}

