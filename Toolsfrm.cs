using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }

}