using System;
using System.Windows.Forms;

namespace WbotMgr
{
    public partial class Toolsfrm : Form
    {
        // Property to store a reference to the MainForm form
        public MainForm ParentForm2 { get; set; }

        public Toolsfrm()
        {
            InitializeComponent();
        }

        private void Toolsfrm_Load(object sender, EventArgs e)
        {
            // Make sure to reflect the current state of AppConfig in the CheckBoxes
            ChkGroupReply.Checked = ParentForm2.botConfig.appconfig.isGroupReply;
            ChkDownload.Checked = ParentForm2.botConfig.appconfig.downloadMedia;
            ChkReplyUnread.Checked = ParentForm2.botConfig.appconfig.replyUnreadMsg;
            ChkQuote.Checked = ParentForm2.botConfig.appconfig.quoteMessageInReply;
        }

        private void BtnApplyTools_Click(object sender, EventArgs e)
        {
            if (ParentForm2 != null && ParentForm2.botConfig != null)
            {
                // Now you can safely access the properties of ParentForm and botConfig
                ParentForm2.botConfig.appconfig.isGroupReply = ChkGroupReply.Checked;
                ParentForm2.botConfig.appconfig.downloadMedia = ChkDownload.Checked;
                ParentForm2.botConfig.appconfig.replyUnreadMsg = ChkReplyUnread.Checked;
                ParentForm2.botConfig.appconfig.quoteMessageInReply = ChkQuote.Checked;
                ParentForm2.ApplyChanges(); // Apply the changes
                this.Close(); // Close the Toolsfrm form
            }
            else
            {
                // Handle the case where ParentForm or botConfig is null
                MessageBox.Show("ParentForm or botConfig is null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBlockedTools_Click(object sender, EventArgs e)
        {
            ParentForm2.blockedToolStripMenuItem_Click(sender, e);
        }

        private void BtnAllowedTools_Click(object sender, EventArgs e)
        {
            ParentForm2.allowedToolStripMenuItem_Click(sender, e);
        }

        private void BtnServerTools_Click(object sender, EventArgs e)
        {
            string usrnme = ParentForm2.botConfig.appconfig.server.username;
            string usrpwd = ParentForm2.botConfig.appconfig.server.password;
            // Create and show an instance of DbleInputForm for the user to enter server credentials
            DbleInputfrm credentialsInputForm = new DbleInputfrm();
            credentialsInputForm.Text = "Server Credentials";
            credentialsInputForm.TextBoxInput1.Text = usrnme;
            credentialsInputForm.TextBoxInput2.Text = usrpwd;
            credentialsInputForm.ShowDialog();

            if (!string.IsNullOrEmpty(credentialsInputForm.UserInput1) & !string.IsNullOrEmpty(credentialsInputForm.UserInput2))
            {
                ParentForm2.botConfig.appconfig.server.username = credentialsInputForm.UserInput1;
                ParentForm2.botConfig.appconfig.server.password = credentialsInputForm.UserInput2;
            }

            string svrport = ParentForm2.botConfig.appconfig.server.port.ToString();
            // Create and show an instance of DbleInputForm for the user to enter server port
            Inputfrm portInputForm = new Inputfrm();
            portInputForm.Text = "Server Port";
            portInputForm.TextBoxInput.Text = svrport;
            portInputForm.ShowDialog();

            if (!string.IsNullOrEmpty(portInputForm.UserInput))
            {
                // Try to convert the input value to an integer
                if (int.TryParse(portInputForm.UserInput, out int newPort))
                {
                    // If the conversion is successful and the value is a number, update the port
                    ParentForm2.botConfig.appconfig.server.port = newPort;
                }
                else
                {
                    // If the input value is not a number, display an error message
                    MessageBox.Show("Please enter a valid number for the port.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}