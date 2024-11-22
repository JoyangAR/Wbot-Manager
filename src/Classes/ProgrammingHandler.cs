using System;
using System.Collections.Generic;
using System.IO;

namespace WbotMgr
{
    internal class ProgrammingHandler
    {
        public Dictionary<DayOfWeek, string> GetDaysFileNames()
        {
            return new Dictionary<DayOfWeek, string>
            {
                { DayOfWeek.Monday, "botJson_Monday.bak" },
                { DayOfWeek.Tuesday, "botJson_Tuesday.bak" },
                {DayOfWeek.Wednesday, "botJson_Wednesday.bak" },
                { DayOfWeek.Thursday, "botJson_Thursday.bak" },
                { DayOfWeek.Friday, "botJson_Friday.bak" },
                { DayOfWeek.Saturday, "botJson_Saturday.bak" },
                { DayOfWeek.Sunday, "botJson_Sunday.bak" },
            };
        }

        public Dictionary<string, string> GetWeeklyNames()
        {
            return new Dictionary<string, string>
            {
                 { "MonToFrid", "botJson_Weekdays.bak" },  // Monday to Friday
                { "SatAndSun", "botJson_Weekend.bak" }   // Saturday & Sunday
            };
        }

        public static bool CreateProgramming(string filePath, string folderPath, string pgmname, out string errorMsg)
        {
            // Check if the original file exists
            if (File.Exists(filePath))
            {
                //
                string pgmFilePath = Path.Combine(folderPath, pgmname); // Full path to the backup file
                if (File.Exists(pgmFilePath))
                {
                    errorMsg = $"The file {pgmFilePath} already exist in the specified path.";
                    return false;
                }
                try
                {
                    // Copy the original file to create a backup
                    File.Copy(filePath, pgmFilePath);
                    errorMsg = null;
                    return true;
                }
                catch (Exception ex)
                {
                    errorMsg = ex.Message;
                    return false;
                }
            }
            else
            {
                errorMsg = $"The file {filePath} does not exist in the specified path.";
                return false;
            }
        }

        public static bool UpdateProgramming(string filePath, string folderPath, string pgmname, out string errorMsg)
        {
            // Check if the original file exists
            if (File.Exists(filePath))
            {
                //
                string pgmFilePath = Path.Combine(folderPath, pgmname); // Full path to the backup file
                if (File.Exists(pgmFilePath))
                {
                    try
                    {
                        // Copy the original file to create a backup
                        File.Copy(filePath, pgmFilePath, true);
                        errorMsg = null;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        errorMsg = ex.Message;
                        return false;
                    }
                }
                else
                {
                    errorMsg = $"The file {pgmFilePath} does not exist in the specified path.";
                    return false;
                }
            }
            else
            {
                errorMsg = $"The file {filePath} does not exist in the specified path.";
                return false;
            }
        }

        public static bool DeleteProgramming(string filePath, out string errorMsg)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    errorMsg = null;
                    return true;
                }
                catch (Exception ex)
                {
                    errorMsg = ex.Message;
                    return false;
                }
            }
            else
            {
                errorMsg = $"The file {filePath} does not exist in the specified path.";
                return false;
            }
        }

        public static bool SetProgramming(string oldFilePath, string newFilePath, out string errorMsg)
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
                errorMsg = null;
                return true;
            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                return false;
            }
        }
    }
}