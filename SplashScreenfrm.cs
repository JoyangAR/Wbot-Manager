using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace WbotMgr
{
    partial class SplashScreenfrm : Form
    {
        public static string jsonFilePathSP = null;
        public static string BaseDirectorySP = null;
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
                       
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // When the timer expires, show the main form and stop the timer
            timer.Stop();
            ShowMainForm();
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
            mainForm.Show();
            this.Hide();
            mainForm.Focus();
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
        #endregion

        private void SplashScreenfrm_Load(object sender, EventArgs e)
        {
            // Check if WMgrConfig.xml exists
            if (File.Exists("WMgrConfig.xml"))
            {
                // Load existing WMgrConfig.xml to retrieve jsonFilePathSP
                XmlDocument existingConfigXml = new XmlDocument();
                existingConfigXml.Load("WMgrConfig.xml");

                XmlNode filePathNode = existingConfigXml.SelectSingleNode("/Configuration/jsonFilePath");

                // Retrieve jsonFilePathSP from existing WMgrConfig.xml
                jsonFilePathSP = filePathNode.InnerText;
                if (filePathNode != null)
                {
                   
                    if (!File.Exists(jsonFilePathSP))
                    {
                        // Show a warning message if the file does not exist
                        MessageBox.Show("The bot.json file was not found in the configured location.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        OpenFileBrowser();
                        return;
                    }

                    // Set the base directory of MainForm to the location of jsonFilePath
                    SetMainFormBaseDirectory();

                    // Show the MainForm
                    StartCountDown();
                    return; // Exit the method to avoid showing OpenFileDialog
                }

                OpenFileBrowser();
            }

          
        }

        private void OpenFileBrowser()
        {

            // Configure the file dialog to open files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All files|*.*";

            // Show the file dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string selectedFilePath = openFileDialog.FileName;

                // Save File Path as a variable
                jsonFilePathSP = selectedFilePath;

                // Set the base directory of MainForm to the location of jsonFilePath
                SetMainFormBaseDirectory();

                // Create a new XML document
                XmlDocument xmlDoc = new XmlDocument();

                // Create the root element
                XmlElement rootElement = xmlDoc.CreateElement("Configuration");

                // Create the "FilePath" element and set its value as the selected file path
                XmlElement filePathElement = xmlDoc.CreateElement("jsonFilePath");
                filePathElement.InnerText = selectedFilePath;

                // Attach the "FilePath" element to the root element
                rootElement.AppendChild(filePathElement);

                // Attach the root element to the XML document
                xmlDoc.AppendChild(rootElement);

                // Save the XML document to a file
                xmlDoc.Save("WMgrConfig.xml");

                // Show the MainForm
                StartCountDown();
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
                }
            }
        }

    }
}
