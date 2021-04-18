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
            selectedDbLabel.Text = ConfigurationManager.AppSettings["DatabaseDrive"];
            selectedBuLabel.Text = ConfigurationManager.AppSettings["BackupDrive"];
            selectedDbLabel.Refresh();
            selectedBuLabel.Refresh();

        }

        public void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshLabel();
        }

        private void backupButton_Click(object sender, EventArgs e)
        {

        }

        private void selectDriveButton_Click(object sender, EventArgs e)
        {
            Options slctDrv = new Options();
            slctDrv.Show();
        }
    }
}
