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
<<<<<<< HEAD
            
            
=======
>>>>>>> main
            DriveInfo[] ListAllDrives = DriveInfo.GetDrives();

            int counterA = 0;
            foreach (DriveInfo Drive in ListAllDrives)
            {
                if (Drive.DriveType != DriveType.Removable)
                {
                    TreeNode newNode = new TreeNode(Drive.Name + "NLDATA " + " (" + Drive.DriveType + ")");
                    dbDrivesList.Nodes.Add(newNode);

                    if (Drive.Name + "NLDATA " + " (" + Drive.DriveType + ")" == ConfigurationManager.AppSettings["DatabaseDrive"])
                    {
                        dbDrivesList.SelectedNode = dbDrivesList.Nodes[counterA];
                    }

                    counterA++;
                }
            }

            int counterB = 0;
            foreach (DriveInfo Drive in ListAllDrives)
            {
                if (Drive.DriveType == DriveType.Removable)
                {
                    TreeNode newNode = new TreeNode(Drive.Name + " " + Drive.VolumeLabel + " (" + Drive.DriveType + ")");
                    buDrivesList.Nodes.Add(newNode);

                    if (Drive.Name + " " + Drive.VolumeLabel + " (" + Drive.DriveType + ")" == ConfigurationManager.AppSettings["BackupDrive"])
                    {
                        buDrivesList.SelectedNode = buDrivesList.Nodes[counterB];
                    }

                    counterB++;
                }
            }
        }

        static void ShowConfig()
        {

            // For read access you do not need to call OpenExeConfiguraton
            foreach (string key in ConfigurationManager.AppSettings)
            {
                string value = ConfigurationManager.AppSettings[key];
                MessageBox.Show("Key: " + key + ", Value: " + value);
            }
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("BackupDrive");
            config.AppSettings.Settings.Add("BackupDrive", buDrivesList.SelectedNode.Text);
            config.AppSettings.Settings.Remove("DatabaseDrive");
            config.AppSettings.Settings.Add("DatabaseDrive", dbDrivesList.SelectedNode.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            // ShowConfig();
            MainWindow mw = new MainWindow();
            mw.RefreshLabel();
            this.Close();
        }
<<<<<<< HEAD
=======

        CheckBox lastChecked;
        private void buDrivesList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            CheckBox activeCheckBox = sender as CheckBox;
            //if (activeCheckBox != lastChecked && lastChecked != null)
            //{
            //    lastChecked.Checked = false;
            //}
            lastChecked = activeCheckBox.Checked ? activeCheckBox : null;
        }
>>>>>>> main
    }
}
