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
using Ionic.Zip;

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
            selectedBuLabel.Text = ConfigurationManager.AppSettings["BackupDrive"];
            selectedBuLabel.Refresh();

        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshLabel();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            compressionWorker.RunWorkerAsync();
        }

        private void selectDriveButton_Click(object sender, EventArgs e)
        {
            Options slctDrv = new Options();
            slctDrv.ShowDialog(this);
            RefreshLabel();
        }

        private void BackgroundProcessLogicMethod(BackgroundWorker bw)
        {
            string backupDriveLetter = ConfigurationManager.AppSettings["BackupDrive"].Split(' ')[0];
            
            using (ZipFile zip = new ZipFile(backupDriveLetter + "nldata.zip"))
            {
                zip.AddDirectory(ConfigurationManager.AppSettings["DatabaseLocation"]);
                zip.Save();
            }
        }

        private void compressionWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker helperBW = sender as BackgroundWorker;
            BackgroundProcessLogicMethod(helperBW);
        }

        private void compressionWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("Cancelled");
            } else if (e.Error != null)
            {
                MessageBox.Show("Error");
            } else
            {
                MessageBox.Show("Computerlink backup completed successfully!");
            }
        }

        private void compressionWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            backupProgress.Value = e.ProgressPercentage;
        }
    }
}
