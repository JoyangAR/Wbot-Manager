using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using WbotMgr.src.Classes;
using Timer = System.Windows.Forms.Timer;

namespace WbotMgr
{
    internal partial class SplashScreenfrm : Form
    {
        public static string jsonFilePathSP = null;
        public static string BaseDirectorySP = null;
        public static string backupsDirectorySP = null;
        public static string programmingDirectorySP = null;
        private string iniFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.ini");
        private Timer timer;

        public SplashScreenfrm()
        {
            InitializeComponent();
            Instance = this;
            this.Text = String.Format(AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            VerifyNecesaryDll();
            StartCountDown();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // When the timer expires, show the main form and stop the timer
            timer.Stop();
            LoadConfiguration();
        }

        public static SplashScreenfrm Instance { get; private set; }

        private void StartCountDown()
        {
            // Set up the timer
            timer = new Timer();
            timer.Interval = 1000; // Set the interval to 1 second (you can adjust this)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void ShowMainForm()
        {
            // Create an instance of the MainForm, show it, and hide the SplashScreen
            MainForm mainForm = new MainForm();
            MainForm.jsonBaseDirectory = BaseDirectorySP; // Assign the jsonBaseDirectory string
            MainForm.jsonFilePath = jsonFilePathSP; // Assign the jsonFilePath string
            MainForm.backupsDirectory = backupsDirectorySP;
            MainForm.programmingDirectory = programmingDirectorySP;
            mainForm.Show();
            this.Hide();
            mainForm.Focus();
            if (IsAppRunning())
            {
                MessageBox.Show("The application is already running.");
                this.Close();
            }
        }

        private bool IsAppRunning()
        {
            string appName = Process.GetCurrentProcess().ProcessName;
            // Get the number of processes with the same name as this one
            return Process.GetProcessesByName(appName).Length > 1;
        }

        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }

        #endregion Descriptores de acceso de atributos de ensamblado

        private void LoadConfiguration()
        {
            // Check if the INI file exists
            if (File.Exists(iniFilePath))
            {
                // Create INIHandler to read the INI file
                INIHandler iniHandler = new INIHandler(iniFilePath);

                // Retrieve jsonFilePath from the INI file
                jsonFilePathSP = iniHandler.ReadString("Configuration", "jsonFilePath", string.Empty);

                if (!string.IsNullOrEmpty(jsonFilePathSP) && File.Exists(jsonFilePathSP))
                {
                    // The jsonFilePathSP is valid, set the base directory of MainForm and show the MainForm
                    SetMainFormBaseDirectory();
                    ShowMainForm();
                    return; // Exit the method to avoid showing OpenFileDialog
                }
            }

            // If INI file doesn't exist or jsonFilePathSP is invalid, check for bot.json in the app's startup location
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;
            string botJsonPath = Path.Combine(startupPath, "bot.json");

            if (File.Exists(botJsonPath))
            {
                // Set jsonFilePath
                jsonFilePathSP = botJsonPath;

                // Save bot.json path to the INI file
                SaveJsonPathToIni(botJsonPath);

                // Set the base directory of MainForm to the location of bot.json
                SetMainFormBaseDirectory();

                // Show the MainForm
                ShowMainForm();
                return; // Exit the method to avoid showing OpenFileDialog
            }

            // If neither the INI file nor bot.json is found, open the file browser
            OpenFileBrowser();
        }

        private void SaveJsonPathToIni(string jsonPath)
        {
            INIHandler iniHandler = new INIHandler(iniFilePath);

            // Write the jsonFilePath to the INI file
            iniHandler.WriteString("Configuration", "jsonFilePath", jsonPath);
        }

        private void OpenFileBrowser()
        {
            // Configure the file dialog to open files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select desired bot.json";
            openFileDialog.Filter = "json files|*.json";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                // Verify that the file has a .json extension
                string fileExtension = Path.GetExtension(openFileDialog.FileName);

                if (string.Equals(fileExtension, ".json", StringComparison.OrdinalIgnoreCase))
                {
                    // Save File Path as a variable
                    jsonFilePathSP = selectedFilePath;

                    // Set the base directory of MainForm to the location of jsonFilePath
                    SetMainFormBaseDirectory();

                    // Save the jsonFilePath to the INI file
                    SaveJsonPathToIni(selectedFilePath);

                    // Show the MainForm
                    ShowMainForm();
                }
                else
                {
                    // Handle the case where the selected file does not have the correct extension
                    MessageBox.Show("Please select a valid JSON file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    OpenFileBrowser();
                }
            }
            else
            {
                // Handle the case where the user canceled file selection
                MessageBox.Show("No file selected. Exiting the application.");
                Application.Exit();
            }
        }

        private void SetMainFormBaseDirectory()
        {
            // Set the base directory of MainForm to the location of jsonFilePath
            if (!string.IsNullOrEmpty(jsonFilePathSP))
            {
                string directory = Path.GetDirectoryName(jsonFilePathSP);
                if (Directory.Exists(directory))
                {
                    BaseDirectorySP = directory;
                    backupsDirectorySP = Path.Combine(BaseDirectorySP, "Config Backups");
                    programmingDirectorySP = Path.Combine(BaseDirectorySP, "Programmings");
                    CreateBackupsFolder();
                    CreateProgrammingFolder();
                }
            }
        }

        private void VerifyNecesaryDll()
        {
            // Check if the file Newtonsoft.Json.dll exists in the execution location
            string dllFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Newtonsoft.Json.dll");

            if (!File.Exists(dllFilePath))
            {
                // Show a warning message if the file does not exist
                MessageBox.Show("The Newtonsoft.Json.dll file was not found in the application location.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void CreateBackupsFolder()
        {
            if (!Directory.Exists(backupsDirectorySP))
            {
                Directory.CreateDirectory(backupsDirectorySP);
            }
        }

        private void CreateProgrammingFolder()
        {
            if (!Directory.Exists(programmingDirectorySP))
            {
                Directory.CreateDirectory(programmingDirectorySP);
            }
        }
    }
}