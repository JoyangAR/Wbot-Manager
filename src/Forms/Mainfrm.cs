﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WbotMgr.src;
using WbotMgr.src.Classes;
using Formatting = Newtonsoft.Json.Formatting;

namespace WbotMgr
{
    public partial class Mainfrm : Form
    {
        public BotConfiguration botConfig;
        private List<string> sectionItems = new List<string>();
        private List<string> groupItems = new List<string>();
        private List<string> generatedNames = new List<string>();

        public Mainfrm()
        {
            InitializeComponent();
            this.FormClosed += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Read the content of the JSON file
                string jsonContent = File.ReadAllText(GlobalSettings.jsonFilePath);

                // Deserialize the JSON into a BotConfiguration object
                botConfig = JsonConvert.DeserializeObject<BotConfiguration>(jsonContent);

                // Make sure 'server' is initialized after deserializing 'botConfig'
                if (botConfig.appconfig.server == null)
                {
                    botConfig.appconfig.server = new ServerConfig
                    {
                        // Here you can assign default values if you wish
                        username = "admin",
                        password = "admin",
                        port = 8080
                    };
                }

                bool hasGroups = botConfig.bot.Any(section => section.sectiongroup != null);

                // Check each section in "bot" and add "sectionname" if it does not exist
                foreach (var section in botConfig.bot)
                {
                    if (string.IsNullOrEmpty(section.sectionname))
                    {
                        section.sectionname = "DefaultName"; // Default name if it does not exist
                    }

                    // Check if a similar name already exists in the ListBox and generate a new one if necessary
                    string uniqueName = GetUniqueSectionName(section.sectionname);
                    section.sectionname = uniqueName;

                    // Add the section name to the corresponding list only if the sectiongroup is null
                    if (section.sectiongroup == null)
                    {
                        sectionItems.Add(section.sectionname);
                    }
                    // Replace null webhook by "" to avoid wbot error
                    if (section.webhook == null)
                    {
                        section.webhook = "";
                    }
                }

                // Add "...." at the end of sections as show all sections button only if there are groups
                if (hasGroups)
                {
                    sectionItems.Add("....");
                    // Add "-----Groups-----" as a division between sections & groups
                    sectionItems.Add("----------------Groups-----------------");
                }

                // Add the section groups to the ListBox at the end
                foreach (var section in botConfig.bot)
                {
                    if (section.sectiongroup != null && !groupItems.Contains(section.sectiongroup))
                    {
                        groupItems.Add(section.sectiongroup);
                    }
                }

                // Update the ListBox with the items
                UpdateListBox();

                // Load the names of existing groups into the ComboBox only if there are groups available
                if (hasGroups)
                {
                    CmbGroupEdit.Items.Clear();
                    CmbGroupEdit.Items.AddRange(groupItems.ToArray());
                }
                else
                {
                    // Handle the case where there are no groups available
                    BtnMoveUp.Enabled = true;
                    BtnMoveDown.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error loading configuration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Create INIHandler to read the INI file
            INIHandler iniHandler = new INIHandler(GlobalSettings.iniFilePath);

            // Enable Auto Scheduling
            if (iniHandler.ReadBoolean("Configuration", "Auto Scheduling", false))
            {
                LabelAutoScheduler.Text = "Auto Scheduler ON";
                LabelAutoScheduler.ForeColor = Color.Green; // Set the text color to green
                StartAutoScheduler();
            }           
        }

        private string GetUniqueSectionName(string sectionName)
        {
            // If the name does not exist in the list, return it as is
            if (!generatedNames.Contains(sectionName))
            {
                generatedNames.Add(sectionName);
                return sectionName;
            }

            // Generate a new unique name
            int counter = 1;
            while (generatedNames.Contains($"{sectionName}{counter}"))
            {
                counter++;
            }

            string uniqueName = $"{sectionName}{counter}";
            generatedNames.Add(uniqueName);
            return uniqueName;
        }

        private string GetUniqueSectionName2(string baseName)
        {
            // Check if there is already a section with the base name
            var existingNames = botConfig.bot.Select(section => section.sectionname).ToList();
            string uniqueName = baseName;

            // Find a unique suffix
            int suffix = 1;
            while (existingNames.Contains(uniqueName))
            {
                uniqueName = $"{baseName}_{suffix}";
                suffix++;
            }

            return uniqueName;
        }

        private void LoadSectionsAndGroups()
        {
            // Clear sectionItems and groupItems
            sectionItems.Clear();
            groupItems.Clear();

            // Add sections with group null
            var sectionsWithNullGroup = botConfig.bot
                .Where(section => section.sectiongroup == null)
                .Select(section => section.sectionname)
                .ToList();

            sectionItems.AddRange(sectionsWithNullGroup);

            // Add groups
            groupItems.AddRange(botConfig.bot
                .Where(section => section.sectiongroup != null)
                .Select(section => section.sectiongroup)
                .Distinct());
            // Add "...." at the end of sections as show all sections button
            sectionItems.Add("....");
            // Add "----------------Groups-----------------" at the end of sections as division
            sectionItems.Add("----------------Groups-----------------");

            // Update the ListBox with the items
            UpdateListBox();
            BtnMoveUp.Enabled = false;
            BtnMoveDown.Enabled = false;

            CmbGroupEdit.Items.Clear();
            CmbGroupEdit.Items.AddRange(groupItems.ToArray());
        }

        private void LoadAllSections()
        {
            // Clear sectionItems and groupItems
            sectionItems.Clear();
            groupItems.Clear();

            // Add all sections regardless of their group
            sectionItems.AddRange(botConfig.bot.Select(section => section.sectionname));

            bool hasGroups = botConfig.bot.Any(section => section.sectiongroup != null);

            // Add "..." at the end of sections as show groups button only if there are groups
            if (hasGroups)
            {
                sectionItems.Add("...");
            }

            // Update the ListBox with the items
            UpdateListBox();
            BtnMoveUp.Enabled = true;
            BtnMoveDown.Enabled = true;
        }

        private void UpdateListBox()
        {
            // Detach the event handler temporarily to avoid triggering the event
            NameListBox.SelectedIndexChanged -= NameListBox_SelectedIndexChanged;

            // Clear the ListBox
            NameListBox.Items.Clear();

            // Add section items
            NameListBox.Items.AddRange(sectionItems.ToArray());

            // Add group items
            NameListBox.Items.AddRange(groupItems.ToArray());

            // Reattach the event handler
            NameListBox.SelectedIndexChanged += NameListBox_SelectedIndexChanged;

            // Set the selected index to the first item
            NameListBox.SelectedIndex = 0;
        }

        private void LoadSectionData(BotSection selectedSection)
        {
            // Load data into the corresponding controls for a section
            if (selectedSection != null)
            {
                TxtNameEdit.Text = selectedSection.sectionname;
                // Selects the corresponding group in the ComboBox
                CmbGroupEdit.Text = selectedSection.sectiongroup;
                ContainsListBox.Items.Clear();
                if (selectedSection.contains != null)
                {
                    ContainsListBox.Items.AddRange(selectedSection.contains.ToArray());
                }
                ExactListBox.Items.Clear();
                if (selectedSection.exact != null)
                {
                    ExactListBox.Items.AddRange(selectedSection.exact.ToArray());
                }

                TxtReply.Text = selectedSection.response;
                ChkBoxCaption.Checked = false;
                AttachedFilesListBox.Items.Clear();
                if (selectedSection.file != null)
                {
                    AttachedFilesListBox.Items.AddRange(selectedSection.file.ToArray());
                }

                TxtSecconds.Text = selectedSection.afterseconds.ToString();
                ChkBoxCaption.Checked = selectedSection.responseAsCaption;
                TxtWebhook.Text = selectedSection.webhook;
            }
            else
            {
                // Clear controls if no section is selected
                TxtNameEdit.Text = "";
                CmbGroupEdit.Text = "";
                ContainsListBox.Items.Clear();
                ExactListBox.Items.Clear();
                TxtReply.Text = "";
                ChkBoxCaption.Checked = false;
                AttachedFilesListBox.Items.Clear();
                TxtSecconds.Text = "";
                TxtWebhook.Text = "";
            }
        }

        public void ApplyChanges()
        {
            try
            {
                // Get the name of the selected section in the ListBox
                string selectedSectionName = NameListBox.Text;

                // Find the current section in botConfig.bot using the section name
                BotSection selectedSection = botConfig.bot.FirstOrDefault(section =>
                    (section.sectiongroup == null && section.sectionname == selectedSectionName) ||
                    (section.sectiongroup != null && section.sectionname == selectedSectionName));

                // Check if the section is found before making changes
                if (selectedSection != null)
                {
                    // Check if there are changes in sectiongroup or sectionname
                    bool sectionGroupChanged = selectedSection.sectiongroup != CmbGroupEdit.Text;
                    bool sectionNameChanged = selectedSection.sectionname != TxtNameEdit.Text;

                    // Check if the new section group is equal to any existing section name
                    bool isSectionGroupUsedAsSectionName = botConfig.bot.Any(section =>
                        section.sectiongroup == null && section.sectionname == CmbGroupEdit.Text);

                    // Display a message if the section group is already used as a section name
                    if (isSectionGroupUsedAsSectionName)
                    {
                        MessageBox.Show("The selected section group cannot be used because it is already in use as a section name. Please choose a different name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Update the data in the selected section
                    selectedSection.sectionname = TxtNameEdit.Text;

                    // Convert an empty section group to null
                    selectedSection.sectiongroup = string.IsNullOrEmpty(CmbGroupEdit.Text) ? null : CmbGroupEdit.Text;
                    selectedSection.contains = new List<string>(ContainsListBox.Items?.Cast<string>() ?? Enumerable.Empty<string>());
                    selectedSection.exact = new List<string>(ExactListBox.Items?.Cast<string>() ?? Enumerable.Empty<string>());
                    selectedSection.response = TxtReply.Text;
                    selectedSection.file = new List<string>(AttachedFilesListBox.Items?.Cast<string>() ?? Enumerable.Empty<string>());
                    selectedSection.webhook = TxtWebhook.Text;
                    selectedSection.responseAsCaption = ChkBoxCaption.Checked;

                    // Update the "afterSeconds" property in the section with the value from TxtSeconds
                    if (int.TryParse(TxtSecconds.Text, out int seconds))
                    {
                        selectedSection.afterseconds = seconds;
                    }
                    else
                    {
                        // Handle the case where the value of TxtSeconds is not a valid number
                        MessageBox.Show("The value in 'Afert Seconds' isn't valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        selectedSection.afterseconds = 0;
                    }

                    // Serialize the modified object back to JSON
                    string updatedJson = JsonConvert.SerializeObject(botConfig, Formatting.Indented);

                    // Write the updated JSON back to the file
                    File.WriteAllText(GlobalSettings.jsonFilePath, updatedJson);

                    // Reload the lists and refresh the ListBox only if there are changes in sectiongroup or sectionname
                    if (sectionGroupChanged || sectionNameChanged)
                    {
                        bool hasGroups = botConfig.bot.Any(section => section.sectiongroup != null);

                        // Add "..." at the end of sections as show groups button only if there are groups
                        if (hasGroups)
                        {
                            LoadSectionsAndGroups();
                        }
                        else
                        {
                            LoadAllSections();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error applying changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NameAdd.Enabled = true;
            NameListBox.Enabled = true;
        }

        private void MoveSection(int offset)
        {
            // Get the name of the selected section in the ListBox
            string selectedSectionName = NameListBox.SelectedItem?.ToString();

            // Find the current section in botConfig.bot using the section name
            BotSection selectedSection = botConfig.bot.FirstOrDefault(section =>
                section.sectionname == selectedSectionName);

            // Check if the section was found before making changes
            if (selectedSection != null)
            {
                // Get the index of the selected section
                int selectedIndex = botConfig.bot.IndexOf(selectedSection);

                // Check if the new index is within the list bounds
                int newIndex = selectedIndex + offset;
                if (newIndex >= 0 && newIndex < botConfig.bot.Count)
                {
                    // Save the selected name before making the move
                    string previousSelectedName = selectedSectionName;

                    // Swap the positions of the sections
                    SwapSections(selectedIndex, newIndex);

                    // Reload the lists and refresh the ListBox
                    LoadAllSections();

                    // Reset the selection to the moved element by name
                    NameListBox.SelectedItem = previousSelectedName;
                }
            }
        }

        private void SwapSections(int indexA, int indexB)
        {
            // Swap the positions of the sections in botConfig.bot
            BotSection temp = botConfig.bot[indexA];
            botConfig.bot[indexA] = botConfig.bot[indexB];
            botConfig.bot[indexB] = temp;

            // Serialize the modified object back to JSON
            string updatedJson = JsonConvert.SerializeObject(botConfig, Formatting.Indented);

            // Write the updated JSON back to the file
            File.WriteAllText(GlobalSettings.jsonFilePath, updatedJson);
        }

        private void NameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected index in the ListBox
            int selectedIndex = NameListBox.SelectedIndex;

            // Check if an item has been selected
            if (selectedIndex >= 0)
            {
                // Get the selected item from the ListBox
                string selectedItem = NameListBox.Items[selectedIndex].ToString();

                // Check if the selected item is "..."
                if (selectedItem == "...")
                {
                    // Show sections with group null and groups again
                    LoadSectionsAndGroups();
                }
                else
                {
                    if (selectedItem == "....")
                    {
                        // Show sections with group null and groups again
                        LoadAllSections();
                    }
                    else
                    {
                        // Check if the selected item is a group or a section
                        if (groupItems.Contains(selectedItem))
                        {
                            // Selected item is a group
                            // Filter the sections that belong to the selected group
                            var sectionsInGroup = botConfig.bot
                                .Where(section => section.sectiongroup == selectedItem)
                                .Select(section => section.sectionname)
                                .ToList();

                            // Clear the sectionItems and add the group and sections to them
                            sectionItems.Clear();
                            sectionItems.AddRange(sectionsInGroup);
                            sectionItems.Add("...");

                            // Update the ListBox with the items
                            UpdateListBox();
                        }
                        else
                        {
                            // Selected item is a section
                            // Load data into the corresponding controls for a section
                            BotSection selectedSection = botConfig.bot.FirstOrDefault(section =>
                                (section.sectiongroup == null && section.sectionname == selectedItem) ||
                                (section.sectiongroup != null && section.sectionname == selectedItem));

                            // Load data into the controls for the selected section
                            LoadSectionData(selectedSection);
                        }
                    }
                }
            }
        }

        public void ApplyChanges_Click(object sender, EventArgs e)
        {
            int countname = 0;

            foreach (var section in sectionItems)
            {
                if (section == TxtNameEdit.Text)
                {
                    countname++;
                }
            }

            if (countname > 1)
            {
                MessageBox.Show("Section Name already in use!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                countname = 0;
            }
            else
            {
                if (!string.IsNullOrEmpty(TxtNameEdit.Text))
                {
                    // Save the selected name before applying changes
                    string TxtName = TxtNameEdit.Text;
                    ApplyChanges();
                    // Reset the selection to the previous selected element by name
                    NameListBox.SelectedItem = TxtName;
                }
                else
                {
                    MessageBox.Show("Section Name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ExactAdd_Click(object sender, EventArgs e)
        {
            using (var inputForm = new Inputfrm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string newWord = inputForm.UserInput;
                    if (!string.IsNullOrEmpty(newWord))
                    {
                        //13_01_2024
                        newWord = newWord.ToLower(); // Convert to lowercase
                        ExactListBox.Items.Add(newWord);
                    }
                }
            }
        }

        private void ContainsAdd_Click(object sender, EventArgs e)
        {
            using (var inputForm = new Inputfrm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    string newWord = inputForm.UserInput;
                    if (!string.IsNullOrEmpty(newWord))
                    {
                        //13_01_2024
                        newWord = newWord.ToLower(); // Convert to lowercase
                        ContainsListBox.Items.Add(newWord);
                    }
                }
            }
        }

        private void ExactRemove_Click(object sender, EventArgs e)
        {
            // Check if an item has been selected in the ListBox
            if (ExactListBox.SelectedIndex != -1)
            {
                // Remove the selected item
                ExactListBox.Items.RemoveAt(ExactListBox.SelectedIndex);
            }
        }

        private void ContainsRemove_Click(object sender, EventArgs e)
        {
            // Check if an item has been selected in the ListBox
            if (ContainsListBox.SelectedIndex != -1)
            {
                // Remove the selected item
                ContainsListBox.Items.RemoveAt(ContainsListBox.SelectedIndex);
            }
        }

        private void BtnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select a file";
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    // Add the new file to the list
                    AttachedFilesListBox.Items.Add(Path.GetFileName(selectedFilePath));

                    // Move the selected file to the application's location

                    string destinationPath = Path.Combine(GlobalSettings.baseDirectory, Path.GetFileName(selectedFilePath));

                    try
                    {
                        File.Copy(selectedFilePath, destinationPath, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    // Update the "file" property in the "bot" section of the configuration object
                    int selectedIndex = NameListBox.SelectedIndex;
                    if (selectedIndex >= 0 && selectedIndex < botConfig.bot.Count)
                    {
                        // Check if the list already exists, if not, create it
                        if (botConfig.bot[selectedIndex].file == null)
                        {
                            botConfig.bot[selectedIndex].file = new List<string>();
                        }

                        // Add the file path to the list
                        botConfig.bot[selectedIndex].file.Add(Path.GetFileName(destinationPath));
                    }
                }
            }
        }

        private void ChkBoxCaption_CheckedChanged(object sender, EventArgs e)
        {
            // Get the current state of the CheckBox
            bool isChecked = ChkBoxCaption.Checked;

            // You can handle the CheckBox state change if needed
        }

        private void NameAdd_Click(object sender, EventArgs e)
        {
            string varsectiongroup;
            if (!string.IsNullOrEmpty(CmbGroupEdit.Text))
            {
                varsectiongroup = CmbGroupEdit.Text;
            }
            else
            {
                varsectiongroup = null;
            }

            // Create a new instance of BotSection
            BotSection newSection = new BotSection
            {
                sectionname = GetUniqueSectionName2("DefaultName"), // Get a unique name
                sectiongroup = varsectiongroup,
                contains = new List<string>(),
                exact = new List<string>(),
                response = "",
                file = new List<string>(),
                afterseconds = 0,
                responseAsCaption = false // Or adjust the default value as needed
            };

            // Check if there is already a section with "..." or "...."
            int indexToInsert = NameListBox.Items.Count; // Default: insert at the end

            for (int i = 0; i < NameListBox.Items.Count; i++)
            {
                string itemName = NameListBox.Items[i].ToString();
                if (itemName == "..." || itemName == "....")
                {
                    indexToInsert = i;
                    break;
                }
            }

            // Insert the new section at the appropriate position
            botConfig.bot.Insert(indexToInsert, newSection);

            // Add the name of the new section to the ListBox
            NameListBox.Items.Insert(indexToInsert, newSection.sectionname);

            // Select the new section in the ListBox
            NameListBox.SelectedItem = newSection.sectionname;

            sectionItems.Add(newSection.sectionname);

            NameAdd.Enabled = false;
            NameListBox.Enabled = false;
        }

        private void NameRemove_Click(object sender, EventArgs e)
        {
            // Get the selected item in the ListBox
            object selectedItem = NameListBox.SelectedItem;

            // Check if an item has been selected
            if (selectedItem != null)
            {
                // Convert the selected item to a string (assuming it contains text)
                string selectedSectionName = selectedItem.ToString();

                // Find the section in botConfig.bot using the section name
                BotSection selectedSection = botConfig.bot.FirstOrDefault(section => section.sectionname == selectedSectionName);

                // Check if the section was found before making changes
                if (selectedSection != null)
                {
                    // Remove the selected section from the bot list
                    botConfig.bot.Remove(selectedSection);

                    // Serialize the modified object back to JSON
                    string updatedJson = JsonConvert.SerializeObject(botConfig, Formatting.Indented);

                    // Write the updated JSON back to the file
                    File.WriteAllText(GlobalSettings.jsonFilePath, updatedJson);

                    // Remove the section name from the ListBox
                    NameListBox.Items.Remove(selectedItem);

                    // Select the item immediately above in the ListBox
                    if (NameListBox.Items.Count > 0)
                    {
                        int selectedIndex = Math.Max(0, NameListBox.Items.IndexOf(selectedItem));
                        NameListBox.SelectedIndex = Math.Min(selectedIndex, NameListBox.Items.Count - 1);
                    }
                    else
                    {
                        // If the last item was removed, clear the selection
                        NameListBox.SelectedIndex = -1;
                    }

                    NameAdd.Enabled = true;
                    NameListBox.Enabled = true;
                }
            }
            else
            {
                // Show a warning message if no item is selected
                MessageBox.Show("Please select a section to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void blockedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an existing instance of the Blockedfrm form is already open
                Blockedfrm blockedForm = Application.OpenForms.OfType<Blockedfrm>().FirstOrDefault();

                if (blockedForm == null)
                {
                    // If there is no existing instance, create a new one
                    blockedForm = new Blockedfrm();
                    blockedForm.BotConfig = botConfig; // Assign the botConfig object
                    blockedForm.ParentForm = this; // Assign a reference to the main form
                    blockedForm.Show(); // Show the blockedForm
                }
                else
                {
                    // If an instance already exists, bring it to the front
                    blockedForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error opening the blocked form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if an existing instance of the Helpfrm form is already open
            Helpfrm helpForm = Application.OpenForms.OfType<Helpfrm>().FirstOrDefault();

            if (helpForm == null)
            {
                // If there is no existing instance, create a new one
                helpForm = new Helpfrm();
                helpForm.Show(); // Show the helpForm
            }
            else
            {
                // If an instance already exists, bring it to the front
                helpForm.BringToFront();
            }
        }

        public void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Check if an existing instance of the Toolsfrm form is already open
            Toolsfrm toolsForm = Application.OpenForms.OfType<Toolsfrm>().FirstOrDefault();

            if (toolsForm == null)
            {
                // If there is no existing instance, create a new one
                toolsForm = new Toolsfrm();
                toolsForm.ParentForm2 = this; // Assign a reference to the main form
                toolsForm.Show(); // Show the toolsForm
            }
            else
            {
                // If an instance already exists, bring it to the front
                toolsForm.BringToFront();
            }
        }

        public void UpdateAppConfig(Toolsfrm toolsForm)
        {
            // Updates the application configuration (botConfig) with values from Toolsfrm

            // You can also save the configuration to the JSON file if needed
            string updatedJson = JsonConvert.SerializeObject(botConfig, Formatting.Indented);
            File.WriteAllText(GlobalSettings.jsonFilePath, updatedJson);
        }

        private void BtnDettach_Click(object sender, EventArgs e)
        {
            int selectedIndex = NameListBox.SelectedIndex;

            // Checks if a section has been selected
            if (selectedIndex >= 0 && selectedIndex < botConfig.bot.Count)
            {
                // Gets the path of the selected file in the ListBox
                string selectedFilePath = AttachedFilesListBox.SelectedItem as string;

                // Checks if a file has been selected
                if (!string.IsNullOrEmpty(selectedFilePath))
                {
                    // Removes the file from the list in the ListBox
                    AttachedFilesListBox.Items.Remove(selectedFilePath);

                    // Updates the "file" property in the "bot" section of the configuration object
                    botConfig.bot[selectedIndex].file.Remove(selectedFilePath);

                    // If the file list is empty, you can also set it to null if you prefer
                    if (botConfig.bot[selectedIndex].file.Count == 0)
                    {
                        botConfig.bot[selectedIndex].file = null;
                    }
                }
            }
        }

        private void noMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of InputForm
            Inputfrm inputForm = new Inputfrm();

            // Show the InputForm for the user to enter a value
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                // Get the value entered by the user
                string noMatchValue = inputForm.UserInput;

                // Assign the value to the noMatch variable
                botConfig.noMatch = noMatchValue;

                // You can display a message to indicate that the value has been updated
                MessageBox.Show($"noMatch updated to: {botConfig.noMatch}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // You can also apply changes in the main form (Form1) if necessary
                ApplyChanges_Click(this, EventArgs.Empty);
            }
        }

        private void BtnMoveUp_Click(object sender, EventArgs e)
        {
            MoveSection(-1); // Move the section up
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            MoveSection(1); // Move the section down
        }

        public void allowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an existing instance of the Allowedfrm form is already open
                Allowedfrm allowedForm = Application.OpenForms.OfType<Allowedfrm>().FirstOrDefault();

                if (allowedForm == null)
                {
                    // If there is no existing instance, create a new one
                    allowedForm = new Allowedfrm();
                    allowedForm.BotConfig = botConfig; // Assign the botConfig object
                    allowedForm.ParentForm = this; // Assign a reference to the main form
                    allowedForm.Show(); // Show the allowedForm
                }
                else
                {
                    // If an instance already exists, bring it to the front
                    allowedForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error opening the allowed form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHints_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hints for writing a response:\n\n" +
     "• *Bold Text*: Surround the text with asterisks (*).\n" +
     "• _Italic Text_: Surround the text with underscores (_).\n" +
     "• ~Strikethrough Text~: Surround the text with tildes (~).\n" +
     "• `Monospaced (Code) Text`: Enclose the text between three backticks (```).\n" +
     "• `Highlight in Gray`: Surround the text with single backticks (`).\n" +
     "• Unordered List: Use asterisks, hyphens, or plus signs at the beginning of each line.\n" +
     "• Ordered List: Use numbers followed by periods at the beginning of each line.\n" +
     "• Quote Text: Begin each line with the greater-than symbol (>).\n" +
     "• Mention All Group Participants: Use @all.\n" +
     "• Mention Sender's Name: Use [#name].\n" +
     "• Mention Sender's Phone Number: Use [#phoneNumber].\n" +
     "• `{op1|op2}` picks 'op1' or 'op2' or more.\n" +
     "•  To create a new line, simply press Enter",
    "WhatsApp Response Hints",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the current text from the text box
            string searchText = TxtSearch.Text.ToLower();

            // Filter the list based on the entered text
            var filteredItems = sectionItems.Where(item => item.ToLower().Contains(searchText)).ToList();

            // Update the ListBox with the filtered items
            NameListBox.Items.Clear();  // Clear current items
            foreach (var item in filteredItems)
            {
                NameListBox.Items.Add(item);  // Add each filtered item to the ListBox
            }
        }

        private void createBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (BackupsHandler.CreateBackup(GlobalSettings.jsonFilePath, GlobalSettings.backupsDirectory, out string errorMsg))
            {
                // Show Message if backup created
                MessageBox.Show("Backup created successfully");
            }
            else
            {
                // Show Message if backup could not be created
                MessageBox.Show($"Error while creating backup{Environment.NewLine}{errorMsg}");
            }
        }

        private void manageBackupstoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an existing instance of the Blockedfrm form is already open
                Backupsfrm backupsForm = Application.OpenForms.OfType<Backupsfrm>().FirstOrDefault();

                if (backupsForm == null)
                {
                    // If there is no existing instance, create a new one
                    backupsForm = new Backupsfrm();
                    backupsForm.Show(); // Show the backupsForm
                }
                else
                {
                    // If an instance already exists, bring it to the front
                    backupsForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error opening the backups form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtains de source control for ListboxesContextMenu
            Control originControl = ListboxesContextMenu.SourceControl;
            // Call button by originate control
            switch (originControl)
            {
                case ListBox listBox when listBox == NameListBox:
                    NameAdd_Click(sender, EventArgs.Empty);
                    break;

                case ListBox listBox when listBox == ExactListBox:
                    ExactAdd_Click(sender, EventArgs.Empty);
                    break;

                case ListBox listBox when listBox == ContainsListBox:
                    ContainsAdd_Click(sender, EventArgs.Empty);
                    break;
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Obtains de source control for ListboxesContextMenu
            Control originControl = ListboxesContextMenu.SourceControl;
            // Call button by originate control
            switch (originControl)
            {
                case ListBox listBox when listBox == NameListBox:
                    NameRemove_Click(sender, EventArgs.Empty);
                    break;

                case ListBox listBox when listBox == ExactListBox:
                    ExactRemove_Click(sender, EventArgs.Empty);
                    break;

                case ListBox listBox when listBox == ContainsListBox:
                    ContainsRemove_Click(sender, EventArgs.Empty);
                    break;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtReply.SelectedText.Length > 0)
            {
                TxtReply.Copy();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TxtReply.SelectedText.Length > 0)
            {
                TxtReply.Cut();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                TxtReply.Paste();
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TxtReply.SelectAll();
        }

        private void programmingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an existing instance of the Programmingfrm form is already open
                Programmingfrm ProgrammingForm = Application.OpenForms.OfType<Programmingfrm>().FirstOrDefault();

                if (ProgrammingForm == null)
                {
                    // If there is no existing instance, create a new one
                    ProgrammingForm = new Programmingfrm();
                    ProgrammingForm.Show(); // Show the ProgrammingForm
                }
                else
                {
                    // If an instance already exists, bring it to the front
                    ProgrammingForm.BringToFront();
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, for example, show an error message
                MessageBox.Show($"Error opening the programmings form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Timer autoSchedulerTimer;

        private void StartAutoScheduler()
        {
            // Initialize the Timer
            autoSchedulerTimer = new Timer();
            autoSchedulerTimer.Interval = 60000; // 1 minute (in milliseconds)
            autoSchedulerTimer.Tick += AutoSchedulerTimer_Tick;
            autoSchedulerTimer.Start();
        }

        private void AutoSchedulerTimer_Tick(object sender, EventArgs e)
        {
            // Get the current time
            DateTime now = DateTime.Now;

            // Check if it is 00:00 (or within a close range, such as ± 1 minute)
            if (now.Hour == 0 && now.Minute == 0)
            {
                CheckAndLoadScheduleForToday();
            }
        }

        private void CheckAndLoadScheduleForToday()
        {
            DateTime today = DateTime.Today;

            // Check if there is a schedule for today
            if (HasScheduleForDate(today))
            {
                LoadScheduleForDate(today);
                Application.Restart();
                Application.Exit();
            }
            else if (HasDailySchedule())
            {
                LoadDailySchedule();
                Application.Restart();
                Application.Exit();
            }
            else if (IsWeekend(today) && HasWeekendSchedule())
            {
                LoadWeekendSchedule();
                Application.Restart();
                Application.Exit();
            }
            else if (HasWeeklySchedule())
            {
                LoadWeeklySchedule();
                Application.Restart();
                Application.Exit();
            }
            else
            {
                // No schedule available
            }
        }

        private bool HasScheduleForDate(DateTime date)
        {
            // Generate the expected file name based on the date
            string fileName = $"botJson_{date:yyyy_MM_dd}.bak";

            // Build the full file path
            string filePath = Path.Combine(GlobalSettings.programmingDirectory, fileName);

            // Check if the file exists
            return File.Exists(filePath);
        }

        private void LoadScheduleForDate(DateTime date)
        {
            // Format the file based on the date
            string dateFileName = $"botJson_{date:yyyy_MM_dd}.bak";

            // Build the full file path
            string dateFilePath = Path.Combine(GlobalSettings.programmingDirectory, dateFileName);

            // Check if it exists and load the schedule
            if (File.Exists(dateFilePath))
            {
                ProgrammingHandler.SetProgramming(GlobalSettings.jsonFilePath, dateFilePath, out string errorMsg);
            }
        }

        private bool HasDailySchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();

            // Get the file name for the current day
            var fileNames = PgmHandler.GetDaysFileNames();
            DayOfWeek today = DateTime.Now.DayOfWeek;

            if (fileNames.TryGetValue(today, out string fileName))
            {
                // Check if the file exists in the programming directory
                string filePath = Path.Combine(GlobalSettings.programmingDirectory, fileName);
                return File.Exists(filePath);
            }

            return false; // If there is no associated file for the day
        }

        private void LoadDailySchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();
            // Get the file name corresponding to the current day of the week
            var dailyFileNames = PgmHandler.GetDaysFileNames();
            DayOfWeek today = DateTime.Now.DayOfWeek;
            dailyFileNames.TryGetValue(today, out string dailyFileName);

            // Build the full file path
            string dailyFilePath = Path.Combine(GlobalSettings.programmingDirectory, dailyFileName);

            // Check if it exists and load the schedule
            if (File.Exists(dailyFilePath))
            {
                ProgrammingHandler.SetProgramming(GlobalSettings.jsonFilePath, dailyFilePath, out string errorMsg);
            }
        }

        private bool IsWeekend(DateTime date)
        {
            // Check if the day is Saturday or Sunday
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        private bool HasWeekendSchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();
            // Get the names of the weekly files
            var weeklyNames = PgmHandler.GetWeeklyNames();

            // Check if the weekend file exists
            string weekendFileName = weeklyNames["SatAndSun"];
            string weekendFilePath = Path.Combine(GlobalSettings.programmingDirectory, weekendFileName);

            return File.Exists(weekendFilePath);
        }

        private void LoadWeekendSchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();

            // Get the names of the files
            var weeklyNames = PgmHandler.GetWeeklyNames();

            weeklyNames.TryGetValue("SatAndSun", out string weekendFileName);

            // Build the full path
            string weekendFilePath = Path.Combine(GlobalSettings.programmingDirectory, weekendFileName);

            if (File.Exists(weekendFilePath))
            {
                // Call SetProgramming to load the schedule
                ProgrammingHandler.SetProgramming(GlobalSettings.jsonFilePath, weekendFilePath, out string errorMsg);
            }
        }

        private bool HasWeeklySchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();
            // Get the names of the weekly files
            var weeklyNames = PgmHandler.GetWeeklyNames();

            // Check if the Monday to Friday file exists
            string weeklyFileName = weeklyNames["MonToFrid"];
            string weeklyFilePath = Path.Combine(GlobalSettings.programmingDirectory, weeklyFileName);

            return File.Exists(weeklyFilePath);
        }

        private void LoadWeeklySchedule()
        {
            ProgrammingHandler PgmHandler = new ProgrammingHandler();

            // Get the names of the files
            var weeklyNames = PgmHandler.GetWeeklyNames();

            weeklyNames.TryGetValue("MonToFrid", out string weeklyFileName);

            // Build the full path
            string weeklyFilePath = Path.Combine(GlobalSettings.programmingDirectory, weeklyFileName);

            if (File.Exists(weeklyFilePath))
            {
                // Call SetProgramming to load the schedule
                ProgrammingHandler.SetProgramming(GlobalSettings.jsonFilePath, weeklyFilePath, out string errorMsg);
            }
        }
    }
}