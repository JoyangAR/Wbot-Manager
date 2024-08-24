using AssistingClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WbotMgr
{
    public partial class Allowedfrm : Form
    {
        // Property to store a reference to the Mainfrm form
        public new MainForm ParentForm { get; set; }

        // Add a property to store the botConfig object
        public BotConfiguration BotConfig { get; set; }

        // Declare a list to store current items
        public List<string> currentItems = new List<string>();

        // Declare a new list for odd items
        private List<string> oddItems = new List<string>();

        public Allowedfrm()
        {
            InitializeComponent();
        }

        private void Allowedfrm_Load(object sender, EventArgs e)
        {
            // Associate the context menu with the ListBox
            AllowedList.ContextMenuStrip = contextMenuStrip1;

            // Call the method to load allowed items into the ListBox
            LoadAllowedItems();

            // If it doesn't have a name above, add it if necessary
            AddUniqueNameIfNeeded();

            // Save the current ListBox items in the currentItems list
            foreach (string item in AllowedList.Items)
            {
                currentItems.Add(item);
            }

            // Update botConfig with the current items
            BotConfig.allowed = currentItems.ToList();

            // Apply changes in the main form
            ParentForm.ApplyChanges();

            // Filter odd items and update ListBox
            FilterOddItems();
            AllowedList.Items.Clear();
            AllowedList.Items.AddRange(oddItems.ToArray());
        }

        private void LoadAllowedItems()
        {
            // Check if a BotConfig object is provided
            if (BotConfig != null)
            {
                // Load all items into the ListBox
                List<string> allowedItems = BotConfig.allowed.Cast<string>().ToList();

                // Clear the ListBox before loading new items
                AllowedList.Items.Clear();

                // Add each item to the ListBox
                foreach (string item in allowedItems)
                {
                    AllowedList.Items.Add(item);
                }
            }
        }

        private void AddUniqueNameIfNeeded()
        {
            // Iterate through the items in the ListBox
            for (int i = 1; i < AllowedList.Items.Count; i += 2)
            {
                // Check if the previous item is null or is a number
                if (AllowedList.Items[i - 1] == null || IsValidPhoneNumber(AllowedList.Items[i - 1].ToString()))
                {
                    // Add "Perenganito" above the number with a unique name
                    AllowedList.Items.Insert(i - 1, GetUniqueName("John Doe"));
                }
            }

            // If the last item is a number, add a unique name above it
            if (AllowedList.Items.Count % 2 == 1 && IsValidPhoneNumber(AllowedList.Items[AllowedList.Items.Count - 1].ToString()))
            {
                // Use Insert to add a unique name above the last item with a unique name
                AllowedList.Items.Insert(AllowedList.Items.Count - 1, GetUniqueName("John Doe"));
            }
        }

        private void FilterOddItems()
        {
            oddItems.Clear();

            // Add odd items to the new list
            for (int i = 0; i < AllowedList.Items.Count; i += 2)
            {
                if (AllowedList.Items[i] != null)
                {
                    oddItems.Add(AllowedList.Items[i].ToString());
                }
            }
        }

        private bool IsValidName(string name)
        {
            //13_01_2024
            // Check if the name is only numeric or starts with a "+"
            return !name.All(char.IsDigit) && !(name.StartsWith("+") && name.Substring(1).All(char.IsDigit));
        }

        private string CleanNumber(string number)
        {
            //13_01_2024
            // Remove leading "+" and any occurrence of "-" or " " from the number
            return number.TrimStart('+').Replace("-", "").Replace(" ", "");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            //13_01_2024
            // Check if the phoneNumber is a valid number (contains only digits, may start with '+' and can contain '-')
            return !string.IsNullOrEmpty(phoneNumber) && phoneNumber.All(c => char.IsDigit(c) || c == '+' || c == '-' || c == ' ');
        }

        private string GetUniqueName(string baseName)
        {
            // Counter to generate unique names
            int counter = 1;

            // Generate a new unique name until it does not exist in the ListBox
            while (AllowedList.Items.Contains($"{baseName}{counter}"))
            {
                counter++;
            }

            return $"{baseName}{counter}";
        }

        private void UpdateListBox()
        {
            // Update the ListBox with items from currentItems
            AllowedList.Items.Clear();
            foreach (string item in currentItems)
            {
                AllowedList.Items.Add(item);
            }

            // Filter odd items and update ListBox
            FilterOddItems();
            AllowedList.Items.Clear();
            AllowedList.Items.AddRange(oddItems.ToArray());
        }

        private void AllowRemove_Click(object sender, EventArgs e)
        {
            if (AllowedList.SelectedIndex != -1)
            {
                string selectedName = AllowedList.SelectedItem.ToString();
                int selectedIndex = currentItems.IndexOf(selectedName);

                // Get the number immediately below
                string phoneNumber = currentItems[selectedIndex + 1];

                // Remove selected name and the associated number
                currentItems.RemoveAt(selectedIndex);
                currentItems.Remove(phoneNumber);

                // Update ListBox
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("An item must be selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AllowAdd_Click(object sender, EventArgs e)
        {
            //13_01_2024
            // Create and show an instance of DbleInputForm for the user to enter contact values
            DbleInputfrm contactInputForm = new DbleInputfrm();
            contactInputForm.Text = "Contact Data";
            contactInputForm.TextBoxInput1.Text = "Name";
            contactInputForm.TextBoxInput2.Text = "Number";
            contactInputForm.delatfrstclic = true;
            contactInputForm.ShowDialog();

            if (!string.IsNullOrEmpty(contactInputForm.UserInput1) && !string.IsNullOrEmpty(contactInputForm.UserInput2))
            {
                // Get the name entered by the user
                string allowedName = contactInputForm.UserInput1;

                // Get the number entered by the user
                string allowedNumber = contactInputForm.UserInput2;

                // Check if the name is valid
                if (IsValidName(allowedName))
                {
                    // Check if the number is valid
                    if (IsValidPhoneNumber(allowedNumber))
                    {
                        // Clean the number by removing invalid characters
                        allowedNumber = CleanNumber(allowedNumber);

                        // Add the name and number to the blocked list in botConfig
                        currentItems.Add(allowedName);
                        currentItems.Add(allowedNumber);

                        // Update ListBox with the new items
                        UpdateListBox();
                    }
                    else
                    {
                        // Handle the case where the entered number is not valid
                        MessageBox.Show("The entered number is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Handle the case where the entered name is not valid
                    MessageBox.Show("The entered name is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AllowedList_DoubleClick(object sender, EventArgs e)
        {
            if (AllowedList.SelectedIndex != -1)
            {
                // Get the contact name selected
                string selectedName = AllowedList.SelectedItem.ToString();
                int selectedIndex = currentItems.IndexOf(selectedName);

                // Get the number immediately below
                string phoneNumber = currentItems[selectedIndex + 1];

                //12_01_2024
                // Create and show an instance of DbleInputForm for the user to enter contact values
                DbleInputfrm contactInputForm = new DbleInputfrm();
                contactInputForm.Text = "Contact Data";
                contactInputForm.TextBoxInput1.Text = selectedName;
                contactInputForm.TextBoxInput2.Text = phoneNumber;
                contactInputForm.ShowDialog();

                //13_01_2024
                if (!string.IsNullOrEmpty(contactInputForm.UserInput1) & !string.IsNullOrEmpty(contactInputForm.UserInput2))
                {
                    // Check if the name is valid
                    if (IsValidName(contactInputForm.UserInput1))
                    {
                        // Check if the number is valid
                        if (IsValidPhoneNumber(contactInputForm.UserInput2))
                        {
                            // Modify the name in currentItems
                            currentItems[selectedIndex] = contactInputForm.UserInput1;

                            // Modify the number in currentItems
                            currentItems[selectedIndex + 1] = contactInputForm.UserInput2;

                            // You can update the ListBox with the new data if necessary
                            UpdateListBox();
                        }
                        else
                        {
                            // Handle the case where the entered number is not valid
                            MessageBox.Show("The entered number is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Handle the case where the entered name is not valid
                        MessageBox.Show("The entered name is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("An item must be selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            // Update botConfig with the current items and apply changes in the main form
            BotConfig.allowed = currentItems.ToList();
            ParentForm.ApplyChanges();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            // Trigger the DoubleClick event to edit the selected item
            AllowedList_DoubleClick(this, EventArgs.Empty);
        }

        private void AllowedList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Show the context menu
                contextMenuStrip1.Show(AllowedList, e.Location);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trigger the DoubleClick event to edit the selected item
            AllowedList_DoubleClick(this, EventArgs.Empty);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trigger the Remove Click event to delete the selected item
            AllowRemove_Click(this, EventArgs.Empty);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trigger the Add Click event to add a new item
            AllowAdd_Click(this, EventArgs.Empty);
        }

        private void peekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AllowedList.SelectedIndex != -1)
            {
                // Peek at the selected item's number
                string selectedName = AllowedList.SelectedItem.ToString();
                int selectedIndex = currentItems.IndexOf(selectedName);

                // Get the number immediately below
                string phoneNumber = currentItems[selectedIndex + 1];

                // Show another form to get the new number
                Inputfrm numberInputForm = new Inputfrm();
                numberInputForm.Text = "Contact Number";
                numberInputForm.TextBoxInput.Text = phoneNumber;
                numberInputForm.ShowDialog();

                if (!string.IsNullOrEmpty(numberInputForm.UserInput))
                {
                    // Modify the number in currentItems
                    currentItems[selectedIndex + 1] = numberInputForm.UserInput;

                    // You can update the ListBox with the new data if necessary
                    UpdateListBox();
                }
            }
            else
            {
                MessageBox.Show("An item must be selected!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}