using System;
using System.IO;
using System.Windows.Forms;

namespace WbotMgr
{
    public partial class Backupsfrm : Form
    {
        public Backupsfrm()
        {
            InitializeComponent();
        }

        private void Backupsfrm_Load(object sender, EventArgs e)
        {
            // Fill ListBox on load
            FillBackupsListBox();
        }

        private void FillBackupsListBox()
        {
            string searchPattern = "botJson_*.bak"; // Pattern to match backup files
            string[] backupFiles = Directory.GetFiles(GlobalSettings.backupsDirectory, searchPattern); // Get all backup files

            // Add each backup file name to the ListBox
            foreach (string backupFile in backupFiles)
            {
                BackupsListBox.Items.Add(Path.GetFileName(backupFile));
            }
        }

        private void BtnCreateBackup_Click(object sender, EventArgs e)
        {
            if (BackupsHandler.CreateBackup(GlobalSettings.jsonFilePath, GlobalSettings.backupsDirectory, out string errorMsg))
            {
                MessageBox.Show("Backup created successfully");
                // Refill Listbox
                BackupsListBox.Items.Clear();
                FillBackupsListBox();
            }
            else
            {
                MessageBox.Show($"Error while creating backup{Environment.NewLine}{errorMsg}");
            }
        }

        private void BtnDeleteBackup_Click(object sender, EventArgs e)
        {
            if (BackupsListBox.SelectedIndex != -1)
            {
                string backupToDelete = Path.Combine(GlobalSettings.backupsDirectory, BackupsListBox.SelectedItem.ToString());
                if (BackupsHandler.DeleteBackup(backupToDelete, out string errorMsg))
                {
                    // Remove from ListBox too
                    BackupsListBox.Items.Remove(BackupsListBox.SelectedItem.ToString());
                    // Refill Listbox
                    BackupsListBox.Items.Clear();
                    FillBackupsListBox();
                }
                else
                {
                    MessageBox.Show($"Error while deleting backup{Environment.NewLine}{errorMsg}");
                }
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void BtnRestoreBackup_Click(object sender, EventArgs e)
        {
            if (BackupsListBox.SelectedIndex != -1)
            {
                string backupToRestore = Path.Combine(GlobalSettings.backupsDirectory, BackupsListBox.SelectedItem.ToString());
                if (BackupsHandler.RestoreBackup(GlobalSettings.jsonFilePath, backupToRestore, out string errorMsg))
                {
                    // If restored close application
                    MessageBox.Show("Backup restored successfully. Will be aviable when Wbot Manager starts again.");
                    Application.Restart();
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Error while restoring backup{Environment.NewLine}{errorMsg}");
                }
            }
            else
            {
                MessageBox.Show("No file selected");
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDeleteBackup_Click(this, EventArgs.Empty);
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnRestoreBackup_Click(this, EventArgs.Empty);
        }
    }
}