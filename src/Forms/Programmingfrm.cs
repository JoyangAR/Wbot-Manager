using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WbotMgr.src.Classes;

namespace WbotMgr.src
{
    public partial class Programmingfrm : Form
    {
        // Global dictionary associating RadioButtons with file names
        private Dictionary<RadioButton, string> radioButtonPatterns;

        // Initialize the dictionary for RadioButton patterns
        private void InitializeRadioButtonPatterns()
        {
            radioButtonPatterns = new Dictionary<RadioButton, string>
            {
                { RadMonday, "botJson_Monday.bak" },
                { RadTuesday, "botJson_Tuesday.bak" },
                { RadWednesday, "botJson_Wednesday.bak" },
                { RadThursday, "botJson_Thursday.bak" },
                { RadFriday, "botJson_Friday.bak" },
                { RadSaturday, "botJson_Saturday.bak" },
                { RadSunday, "botJson_Sunday.bak" },
                { RadMonToFrid, "botJson_Weekdays.bak" },  // Monday to Friday
                { RadSatAndSun, "botJson_Weekend.bak" }   // Saturday & Sunday
            };
        }

        // Constructor
        public Programmingfrm()
        {
            InitializeComponent();
            InitializeRadioButtonPatterns();
        }

        // Load event handler
        private void Programmingfrm_Load(object sender, EventArgs e)
        {
            // Update RadioButton states on form load
            LoadRadioButtons();

            // Create an INIHandler to manage the INI file
            INIHandler iniHandler = new INIHandler(GlobalSettings.iniFilePath);

            // Read the current state of "Auto Scheduling" and update the menu text accordingly
            bool isAutoSchedulingEnabled = iniHandler.ReadBoolean("Configuration", "Auto Scheduling", false);

            // Update the menu item's text based on the current state
            autoSchedulerToolStripMenuItem.Text = isAutoSchedulingEnabled
                ? "Auto Scheduling ON"
                : "Auto Scheduling OFF";

        }

        // Update RadioButtons based on the existence of files
        private void LoadRadioButtons()
        {
            foreach (var entry in radioButtonPatterns)
            {
                RadioButton radioButton = entry.Key;
                string fileName = entry.Value;
                string filePath = Path.Combine(GlobalSettings.programmingDirectory, fileName);

                // Check if the file exists and update font color
                radioButton.ForeColor = File.Exists(filePath) ? Color.Black : Color.LightGray;
            }
        }

        // Apply button click handler
        private void BtnApply_Click(object sender, EventArgs e)
        {
            // Attempt to get the programming file name based on the selected tab
            string programmingName = GetSelectedProgrammingName();

            if (string.IsNullOrEmpty(programmingName))
            {
                // If no valid file name is found, the method already handles showing an error message
                return;
            }

            // Destination path for the programming file
            string destinationPath = Path.Combine(GlobalSettings.programmingDirectory, programmingName);

            // Call the handler to set the programming
            if (ProgrammingHandler.SetProgramming(GlobalSettings.jsonFilePath, destinationPath, out string errorMsg))
            {
                MessageBox.Show("Programming set successfully. It will be available after restarting Wbot Manager.");
                Application.Restart();
                Application.Exit();
            }
            else
            {
                MessageBox.Show($"Error while setting programming: {Environment.NewLine}{errorMsg}");
            }
        }

        // Save button click handler
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Attempt to get the programming file name based on the selected tab
            string programmingName = GetSelectedProgrammingName();

            if (string.IsNullOrEmpty(programmingName))
            {
                // If no valid file name is found, the method already handles showing an error message
                return;
            }

            // Destination path for the programming file
            string destinationPath = Path.Combine(GlobalSettings.programmingDirectory, programmingName);
            string errorMsg;

            // Determine whether to create or update the file
            bool success = File.Exists(destinationPath)
                ? ProgrammingHandler.UpdateProgramming(GlobalSettings.jsonFilePath, GlobalSettings.programmingDirectory, programmingName, out errorMsg)
                : ProgrammingHandler.CreateProgramming(GlobalSettings.jsonFilePath, GlobalSettings.programmingDirectory, programmingName, out errorMsg);

            // Handle the result
            if (success)
            {
                MessageBox.Show("The programming file was saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"An error occurred while saving the programming: {errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reload RadioButtons
            LoadRadioButtons();
        }

        // Handle date changes in the calendar
        private void PgmMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Get the selected date
            DateTime selectedDate = e.Start;

            // Format the expected file name
            string programmingFileName = $"botJson_{selectedDate:yyyy_MM_dd}.bak";
            string filePath = Path.Combine(GlobalSettings.programmingDirectory, programmingFileName);

            // Update label and calendar appearance based on file existence
            if (File.Exists(filePath))
            {
                LabelExistence.Text = $"Programming exists for {selectedDate:yyyy-MM-dd}";
                LabelExistence.ForeColor = Color.Green;
                PgmMonthCalendar.TitleBackColor = Color.LightGreen;
            }
            else
            {
                LabelExistence.Text = $"No programming found for {selectedDate:yyyy-MM-dd}";
                LabelExistence.ForeColor = Color.Red;
                PgmMonthCalendar.TitleBackColor = SystemColors.ActiveCaption;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Attempt to get the programming file name based on the selected tab
            string programmingName = GetSelectedProgrammingName();

            if (string.IsNullOrEmpty(programmingName))
            {
                // If no valid file name is found, the method already handles showing an error message
                return;
            }

            // Full path to the programming file
            string destinationPath = Path.Combine(GlobalSettings.programmingDirectory, programmingName);

            // Check if the file exists before attempting to delete
            if (!File.Exists(destinationPath))
            {
                MessageBox.Show("The selected programming file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Attempt to delete the programming file
            if (ProgrammingHandler.DeleteProgramming(destinationPath, out string errorMsg))
            {
                MessageBox.Show("Programming deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh UI after deletion
                LoadRadioButtons();
                PgmMonthCalendar_DateChanged(null, new DateRangeEventArgs(PgmMonthCalendar.SelectionRange.Start, PgmMonthCalendar.SelectionRange.End));
            }
            else
            {
                MessageBox.Show($"Error while deleting programming:{Environment.NewLine}{errorMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Reload RadioButtons
            LoadRadioButtons();
        }

        private string GetSelectedProgrammingName()
        {
            string programmingName = string.Empty;

            if (PgmTabControl.SelectedTab == WeeklyTabPage)
            {
                // Determine which RadioButton is selected
                var selectedButton = radioButtonPatterns.FirstOrDefault(rb => rb.Key.Checked);

                if (selectedButton.Key != null)
                {
                    // Get the file name corresponding to the selected RadioButton
                    programmingName = selectedButton.Value;
                }
                else
                {
                    MessageBox.Show("Please select a programming type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (PgmTabControl.SelectedTab == DateTabPage)
            {
                if (PgmMonthCalendar.SelectionRange.Start != DateTime.MinValue)
                {
                    // Use the selected calendar date
                    DateTime selectedDate = PgmMonthCalendar.SelectionRange.Start;
                    programmingName = $"botJson_{selectedDate:yyyy_MM_dd}.bak"; // Example: botJson_2024_11_20.bak
                }
                else
                {
                    MessageBox.Show("Please select a date in the calendar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return programmingName;
        }

        private void autoSchedulerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create INIHandler to read the INI file
            INIHandler iniHandler = new INIHandler(GlobalSettings.iniFilePath);

            // Read the current state of "Auto Scheduling"
            bool isAutoSchedulingEnabled = iniHandler.ReadBoolean("Configuration", "Auto Scheduling", false);

            // Display a confirmation message to the user
            string message = isAutoSchedulingEnabled
                ? "Are you sure you want to disable Auto Scheduling? The application will restart."
                : "Are you sure you want to enable Auto Scheduling? The application will restart.";

            DialogResult result = MessageBox.Show(message, "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Toggle the "Auto Scheduling" state in the INI file
                iniHandler.WriteBoolean("Configuration", "Auto Scheduling", !isAutoSchedulingEnabled);

                // Restart the application
                Application.Restart();
                Application.Exit();
            }
        }
    }
}