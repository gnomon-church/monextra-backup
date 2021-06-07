using System;
using System.IO;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace monextra_backup
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            browseButton.Text = ConfigurationManager.AppSettings["DatabaseLocation"];

            DriveInfo[] ListAllDrives = DriveInfo.GetDrives();

            int counter = 0;
            foreach (DriveInfo Drive in ListAllDrives)
            {
                if (Drive.DriveType == DriveType.Removable)
                {
                    TreeNode newNode = new TreeNode(Drive.Name + " - " + Drive.VolumeLabel + " (" + Drive.DriveType + ")");
                    buDrivesList.Nodes.Add(newNode);

                    if (Drive.Name + " - " + Drive.VolumeLabel + " (" + Drive.DriveType + ")" == ConfigurationManager.AppSettings["BackupDrive"])
                    {
                        buDrivesList.SelectedNode = buDrivesList.Nodes[counter];
                    }

                    counter++;
                }
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("DatabaseLocation");
            config.AppSettings.Settings.Add("DatabaseLocation", browseButton.Text);
            config.AppSettings.Settings.Remove("BackupDrive");
            config.AppSettings.Settings.Add("BackupDrive", buDrivesList.SelectedNode.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            this.Close();
        }

        private void selectDatabase_HelpRequest(object sender, EventArgs e)
        {

        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            DialogResult result = folderDlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                browseButton.Text = folderDlg.SelectedPath;
                browseButton.Refresh();
            }
        }
    }
}
