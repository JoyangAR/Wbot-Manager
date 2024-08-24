using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WbotMgr
{
    public partial class Backupsfrm : Form
    {
        public Backupsfrm()
        {
            InitializeComponent();
        }

        // local form strings from MainForm
        public string tempJsonBaseDirectory;

        public string tempJsonFilePath;

        private void BtnCreateBackup_Click(object sender, EventArgs e)
        {
            if (BackupsHandler.CreateBackup(tempJsonFilePath, tempJsonBaseDirectory))
            {
                MessageBox.Show("Backup created successfully");
                // Refill Listbox
                BackupsListBox.Items.Clear();
                FillBackupsListBox();
            }
            else
            {
                MessageBox.Show("Error while creating backup");
            }
        }

        private void Backupsfrm_Load(object sender, EventArgs e)
        {
            // Fill ListBox on load
            FillBackupsListBox();
        }

        private void FillBackupsListBox()
        {
            string searchPattern = "botJson_*.bak"; // Pattern to match backup files
            string[] backupFiles = Directory.GetFiles(tempJsonBaseDirectory, searchPattern); // Get all backup files

            // Add each backup file name to the ListBox
            foreach (string backupFile in backupFiles)
            {
                BackupsListBox.Items.Add(Path.GetFileName(backupFile));
            }
        }

        private void BtnDeleteBackup_Click(object sender, EventArgs e)
        {
            string backupToDelete = Path.Combine(tempJsonBaseDirectory, BackupsListBox.SelectedItem.ToString());
            if (BackupsHandler.DeleteBackup(backupToDelete))
            {
                // Remove from ListBox too
                BackupsListBox.Items.Remove(BackupsListBox.SelectedItem.ToString());
                // Refill Listbox
                BackupsListBox.Items.Clear();
                FillBackupsListBox();
            }
            else
            {
                MessageBox.Show("Error while deleting backup");
            }
        }

        private void BtnRestoreBackup_Click(object sender, EventArgs e)
        {
            string backupToRestore = Path.Combine(tempJsonBaseDirectory, BackupsListBox.SelectedItem.ToString());
            if (BackupsHandler.RestoreBackup(tempJsonFilePath, backupToRestore))
            {
                // If restored close application
                MessageBox.Show("Backup restored successfully. Will be aviable when Wbot Manager starts again.");
                SplashScreenfrm SplashForm = Application.OpenForms.OfType<SplashScreenfrm>().FirstOrDefault();
                SplashForm.Close();
            }
            else
            {
                MessageBox.Show("Error while restoring backup");
            }
        }
    }
}