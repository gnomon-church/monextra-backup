
namespace monextra_backup
{
    partial class Options
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
            this.buDrivesList = new System.Windows.Forms.TreeView();
            this.okayButton = new System.Windows.Forms.Button();
            this.dbLabel = new System.Windows.Forms.Label();
            this.driveLabel = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.selectDatabase = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buDrivesList
            // 
            this.buDrivesList.Location = new System.Drawing.Point(8, 74);
            this.buDrivesList.Name = "buDrivesList";
            this.buDrivesList.Size = new System.Drawing.Size(206, 190);
            this.buDrivesList.TabIndex = 2;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(8, 270);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(206, 25);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // dbLabel
            // 
            this.dbLabel.AutoSize = true;
            this.dbLabel.Location = new System.Drawing.Point(8, 5);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(107, 15);
            this.dbLabel.TabIndex = 5;
            this.dbLabel.Text = "Database Location:";
            // 
            // driveLabel
            // 
            this.driveLabel.AutoSize = true;
            this.driveLabel.Location = new System.Drawing.Point(8, 56);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(79, 15);
            this.driveLabel.TabIndex = 6;
            this.driveLabel.Text = "Backup Drive:";
            // 
            // browseButton
            // 
            this.browseButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.browseButton.ForeColor = System.Drawing.Color.Red;
            this.browseButton.Location = new System.Drawing.Point(8, 23);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(206, 25);
            this.browseButton.TabIndex = 7;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // selectDatabase
            // 
            this.selectDatabase.HelpRequest += new System.EventHandler(this.selectDatabase_HelpRequest);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "(support use only)";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.driveLabel);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.buDrivesList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView buDrivesList;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label driveLabel;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.FolderBrowserDialog selectDatabase;
        private System.Windows.Forms.Label label1;
    }
}