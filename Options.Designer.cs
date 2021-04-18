
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
            this.dbDrivesList = new System.Windows.Forms.TreeView();
            this.dbLabel = new System.Windows.Forms.Label();
            this.driveLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buDrivesList
            // 
<<<<<<< HEAD
=======
            this.buDrivesList.CheckBoxes = true;
>>>>>>> main
            this.buDrivesList.Location = new System.Drawing.Point(8, 234);
            this.buDrivesList.Name = "buDrivesList";
            this.buDrivesList.Size = new System.Drawing.Size(195, 190);
            this.buDrivesList.TabIndex = 2;
<<<<<<< HEAD
=======
            this.buDrivesList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.buDrivesList_AfterCheck);
>>>>>>> main
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(8, 427);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(195, 25);
            this.okayButton.TabIndex = 3;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // dbDrivesList
            // 
            this.dbDrivesList.Location = new System.Drawing.Point(8, 23);
            this.dbDrivesList.Name = "dbDrivesList";
            this.dbDrivesList.Size = new System.Drawing.Size(195, 190);
            this.dbDrivesList.TabIndex = 4;
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
            this.driveLabel.Location = new System.Drawing.Point(8, 216);
            this.driveLabel.Name = "driveLabel";
            this.driveLabel.Size = new System.Drawing.Size(79, 15);
            this.driveLabel.TabIndex = 6;
            this.driveLabel.Text = "Backup Drive:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 460);
            this.Controls.Add(this.driveLabel);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.dbDrivesList);
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
        private System.Windows.Forms.TreeView dbDrivesList;
        private System.Windows.Forms.Label dbLabel;
        private System.Windows.Forms.Label driveLabel;
    }
}