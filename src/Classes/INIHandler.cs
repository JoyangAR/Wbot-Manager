using System;

namespace WbotMgr.src.Classes
{
    internal class INIHandler
    {
        // Windows API functions for INI files
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(String lpApplicationName, String lpKeyName, String lpDefault, System.Text.StringBuilder lpReturnedString, int nSize, String lpFileName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern int WritePrivateProfileString(String lpApplicationName, String lpKeyName, String lpString, String lpFileName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileInt(String lpApplicationName, String lpKeyName, int nDefault, String lpFileName);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern int FlushPrivateProfileString(int lpApplicationName, int lpKeyName, int lpString, String lpFileName);

        private string strFilename;

        // Constructor to accept the INI file
        public INIHandler(string Filename)
        {
            strFilename = Filename;
        }

        // Read-only property for the file name
        public string FileName
        {
            get
            {
                return strFilename;
            }
        }

        // Function to read a string from the INI file
        public string ReadString(string Section, string Key, string Default)
        {
            int intCharCount;
            System.Text.StringBuilder objResult = new System.Text.StringBuilder(256);

            intCharCount = GetPrivateProfileString(Section, Key, Default, objResult, objResult.Capacity, strFilename);

            if (intCharCount > 0)
                return objResult.ToString().Substring(0, intCharCount);
            else
                return string.Empty;
        }

        // Function to read an integer value from the INI file
        public int ReadInteger(String Section, String Key, int Default)
        {
            return GetPrivateProfileInt(Section, Key, Default, strFilename);
        }

        // Function to read a boolean value from the INI file
        public bool ReadBoolean(String Section, String Key, bool Default)
        {
            int intCharCount;
            System.Text.StringBuilder objResult = new System.Text.StringBuilder(256);
            intCharCount = GetPrivateProfileString(Section, Key, Default.ToString(), objResult, objResult.Capacity, strFilename);
            return bool.Parse(objResult.ToString());
        }

        // Function to write a string value to the INI file
        public void WriteString(String Section, String Key, String Value)
        {
            WritePrivateProfileString(Section, Key, Value, strFilename);
        }

        // Function to write an integer value to the INI file
        public void WriteInteger(string Section, string Key, int Value)
        {
            // Convert the integer value to a hexadecimal string
            string hexValue = Value.ToString("X"); // "X" formats the integer as a hexadecimal string
            WriteString(Section, Key, hexValue);
        }

        // Function to write a boolean value to the INI file
        public void WriteBoolean(String Section, String Key, bool Value)
        {
            // Writes a boolean to your INI file
            WriteString(Section, Key, Value.ToString());
        }
    }
}