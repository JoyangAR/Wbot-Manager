using System;
using System.IO;
using System.Windows.Forms;

namespace WbotMgr
{
    internal class BackupsHandler
    {
        public static bool CreateBackup(string filePath, string folderPath)
        {
            // Check if the original file exists
            if (File.Exists(filePath))
            {
                // Format the date as yyyy_MM_dd
                string datePart = DateTime.Now.ToString("yyyy_MM_dd");
                string backupFileName = $"botJson_{datePart}.bak"; // Initial backup file name
                string backupFilePath = Path.Combine(folderPath, backupFileName); // Full path to the backup file

                int counter = 1;
                // If a backup file with the same name exists, add a counter to the name
                while (File.Exists(backupFilePath))
                {
                    backupFileName = $"botJson_{datePart}({counter}).bak";
                    backupFilePath = Path.Combine(folderPath, backupFileName);
                    counter++;
                }
                try
                {
                    // Copy the original file to create a backup
                    File.Copy(filePath, backupFilePath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show($"The file {filePath} does not exist in the specified path.");
                return false;
            }
        }

        public static bool DeleteBackup(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                MessageBox.Show($"The file {filePath} does not exist in the specified path.");
                return false;
            }
        }

        public static bool RestoreBackup(string oldFilePath, string newFilePath)
        {
            try
            {
                // Delete the existing file if it exists
                if (File.Exists(oldFilePath))
                {
                    File.Delete(oldFilePath);
                }

                // Copy the backup to the original file path
                File.Copy(newFilePath, oldFilePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}