
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
            this.buLabel = new System.Windows.Forms.Label();
            this.selectedBuLabel = new System.Windows.Forms.Label();
            this.selectedDbLabel = new System.Windows.Forms.Label();
            this.dbLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 130);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // backupButton
            // 
            this.backupButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backupButton.Location = new System.Drawing.Point(206, 52);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(105, 65);
            this.backupButton.TabIndex = 2;
            this.backupButton.Text = "Run Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // selectDriveButton
            // 
            this.selectDriveButton.Location = new System.Drawing.Point(92, 52);
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
            this.buLabel.Location = new System.Drawing.Point(41, 24);
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
            this.selectedBuLabel.Location = new System.Drawing.Point(120, 25);
            this.selectedBuLabel.Name = "selectedBuLabel";
            this.selectedBuLabel.Size = new System.Drawing.Size(14, 15);
            this.selectedBuLabel.TabIndex = 5;
            this.selectedBuLabel.Text = "C";
            // 
            // selectedDbLabel
            // 
            this.selectedDbLabel.AutoSize = true;
            this.selectedDbLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.selectedDbLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectedDbLabel.ForeColor = System.Drawing.Color.Red;
            this.selectedDbLabel.Location = new System.Drawing.Point(120, 9);
            this.selectedDbLabel.Name = "selectedDbLabel";
            this.selectedDbLabel.Size = new System.Drawing.Size(14, 15);
            this.selectedDbLabel.TabIndex = 7;
            this.selectedDbLabel.Text = "C";
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.ForeColor = System.Drawing.Color.Red;
            this.dbLabel.Location = new System.Drawing.Point(13, 9);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(107, 15);
            this.dbLabel.TabIndex = 6;
            this.dbLabel.Text = "Database Location:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 163);
            this.Controls.Add(this.selectedDbLabel);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.selectedBuLabel);
            this.Controls.Add(this.buLabel);
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
        private System.Windows.Forms.Label buLabel;
        private System.Windows.Forms.Label selectedBuLabel;
        private System.Windows.Forms.Label selectedDbLabel;
        private System.Windows.Forms.Label dbLabel;
    }
}

