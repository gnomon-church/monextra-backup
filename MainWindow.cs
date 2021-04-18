using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monextra_backup
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RefreshLabel()
        {
            //MessageBox.Show(ConfigurationManager.AppSettings["BackupDrive"]);
            // driveLetterLabel.Text = ConfigurationManager.AppSettings["BackupDrive"];
            descriptionLabel.Text = "test";
            driveLetterLabel.Text = "test";
            driveLetterLabel.Refresh();
            descriptionLabel.Refresh();

        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            driveLetterLabel.Text = ConfigurationManager.AppSettings["BackupDrive"];
            // RefreshLabel();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {

        }

        private void selectDriveButton_Click(object sender, EventArgs e)
        {
            Options slctDrv = new Options();
            slctDrv.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
