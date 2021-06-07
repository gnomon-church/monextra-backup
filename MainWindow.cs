using System;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
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
            if (ConfigurationManager.AppSettings["BackupDrive"] == null || !Directory.Exists(ConfigurationManager.AppSettings["BackupDrive"].Split(' ')[0]))
            {
                MessageBox.Show("Backup drive not detected. Please select the correct drive in the following screen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Options slctDrv = new Options();
                slctDrv.ShowDialog(this);
                RefreshLabel();
            }
            
            if (ConfigurationManager.AppSettings["DatabaseLocation"] == null || !Directory.Exists(ConfigurationManager.AppSettings["DatabaseLocation"]))
            {
                MessageBox.Show("Database directory not detected. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            RefreshLabel();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Application.DoEvents();

            string backupDriveLetter = ConfigurationManager.AppSettings["BackupDrive"].Split(' ')[0];

            DateTime date = DateTime.Now.Date;
            string fileName = date.Year.ToString() + "-" + date.Month.ToString().PadLeft(2, '0') + "-" + date.Day.ToString().PadLeft(2, '0') + ".zip";

            string[] files = Directory.GetFiles(backupDriveLetter);

            Regex re = new Regex(@"\d+-\d+-\d+");

            foreach (string file in files)
            {
                if (file == backupDriveLetter + fileName)
                {
                    File.Delete(file);
                }

                if (DateTime.Compare(DateTime.Parse(re.Match(file).Value), DateTime.Parse(re.Match(fileName).Value).AddMonths(-1)) < 0)
                {
                    File.Delete(file);
                }
            }
            

            using (ZipFile zip = new ZipFile(backupDriveLetter + fileName))
            {
                zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestCompression;
                zip.SaveProgress += zipProgress;
                zip.AddDirectory(ConfigurationManager.AppSettings["DatabaseLocation"]);
                zip.Save();
            }

            Cursor.Current = Cursors.Default;

            DialogResult successDialog = MessageBox.Show("Computerlink backup completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (successDialog == DialogResult.OK)
            {
                Application.ExitThread();
            }
        }

        private void selectDriveButton_Click(object sender, EventArgs e)
        {
            Options slctDrv = new Options();
            slctDrv.ShowDialog(this);
            RefreshLabel();
        }

        private void zipProgress(object sender, SaveProgressEventArgs e)
        {
            if (e.EventType == ZipProgressEventType.Saving_AfterWriteEntry)
            {
                backupProgress.Value = e.EntriesSaved * 100 / e.EntriesTotal;
                this.Text = "Computerlink Backup Utility - " + backupProgress.Value + "% complete";
            }
        }
    }
}
