namespace WbotMgr
{
    partial class Toolsfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnBlockedTools = new System.Windows.Forms.Button();
            this.ChkGroupReply = new System.Windows.Forms.CheckBox();
            this.ChkReplyUnread = new System.Windows.Forms.CheckBox();
            this.ChkDownload = new System.Windows.Forms.CheckBox();
            this.BtnApplyTools = new System.Windows.Forms.Button();
            this.ChkQuote = new System.Windows.Forms.CheckBox();
            this.BtnAllowedTools = new System.Windows.Forms.Button();
            this.BtnServerTools = new System.Windows.Forms.Button();
            this.ChkHeadless = new System.Windows.Forms.CheckBox();
            this.BtnInjection = new System.Windows.Forms.Button();
            this.BtnWebhook = new System.Windows.Forms.Button();
            this.BtnBackups = new System.Windows.Forms.Button();
            this.BtnProgramming = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnBlockedTools
            // 
            this.BtnBlockedTools.Location = new System.Drawing.Point(12, 12);
            this.BtnBlockedTools.Name = "BtnBlockedTools";
            this.BtnBlockedTools.Size = new System.Drawing.Size(70, 26);
            this.BtnBlockedTools.TabIndex = 0;
            this.BtnBlockedTools.Text = "Blocked";
            this.BtnBlockedTools.UseVisualStyleBackColor = true;
            this.BtnBlockedTools.Click += new System.EventHandler(this.BtnBlockedTools_Click);
            // 
            // ChkGroupReply
            // 
            this.ChkGroupReply.AutoSize = true;
            this.ChkGroupReply.Location = new System.Drawing.Point(10, 138);
            this.ChkGroupReply.Name = "ChkGroupReply";
            this.ChkGroupReply.Size = new System.Drawing.Size(85, 17);
            this.ChkGroupReply.TabIndex = 1;
            this.ChkGroupReply.Text = "Group Reply";
            this.ChkGroupReply.UseVisualStyleBackColor = true;
            // 
            // ChkReplyUnread
            // 
            this.ChkReplyUnread.AutoSize = true;
            this.ChkReplyUnread.Location = new System.Drawing.Point(10, 161);
            this.ChkReplyUnread.Name = "ChkReplyUnread";
            this.ChkReplyUnread.Size = new System.Drawing.Size(137, 17);
            this.ChkReplyUnread.TabIndex = 2;
            this.ChkReplyUnread.Text = "Reply Unread Message";
            this.ChkReplyUnread.UseVisualStyleBackColor = true;
            // 
            // ChkDownload
            // 
            this.ChkDownload.AutoSize = true;
            this.ChkDownload.Location = new System.Drawing.Point(10, 184);
            this.ChkDownload.Name = "ChkDownload";
            this.ChkDownload.Size = new System.Drawing.Size(106, 17);
            this.ChkDownload.TabIndex = 3;
            this.ChkDownload.Text = "Download Media";
            this.ChkDownload.UseVisualStyleBackColor = true;
            // 
            // BtnApplyTools
            // 
            this.BtnApplyTools.Location = new System.Drawing.Point(46, 253);
            this.BtnApplyTools.Name = "BtnApplyTools";
            this.BtnApplyTools.Size = new System.Drawing.Size(70, 26);
            this.BtnApplyTools.TabIndex = 4;
            this.BtnApplyTools.Text = "Apply";
            this.BtnApplyTools.UseVisualStyleBackColor = true;
            this.BtnApplyTools.Click += new System.EventHandler(this.BtnApplyTools_Click);
            // 
            // ChkQuote
            // 
            this.ChkQuote.AutoSize = true;
            this.ChkQuote.Location = new System.Drawing.Point(10, 207);
            this.ChkQuote.Name = "ChkQuote";
            this.ChkQuote.Size = new System.Drawing.Size(142, 17);
            this.ChkQuote.TabIndex = 5;
            this.ChkQuote.Text = "Quote Message in Reply";
            this.ChkQuote.UseVisualStyleBackColor = true;
            // 
            // BtnAllowedTools
            // 
            this.BtnAllowedTools.Location = new System.Drawing.Point(92, 12);
            this.BtnAllowedTools.Name = "BtnAllowedTools";
            this.BtnAllowedTools.Size = new System.Drawing.Size(70, 26);
            this.BtnAllowedTools.TabIndex = 6;
            this.BtnAllowedTools.Text = "Allowed";
            this.BtnAllowedTools.UseVisualStyleBackColor = true;
            this.BtnAllowedTools.Click += new System.EventHandler(this.BtnAllowedTools_Click);
            // 
            // BtnServerTools
            // 
            this.BtnServerTools.Location = new System.Drawing.Point(12, 44);
            this.BtnServerTools.Name = "BtnServerTools";
            this.BtnServerTools.Size = new System.Drawing.Size(70, 26);
            this.BtnServerTools.TabIndex = 7;
            this.BtnServerTools.Text = "Server";
            this.BtnServerTools.UseVisualStyleBackColor = true;
            this.BtnServerTools.Click += new System.EventHandler(this.BtnServerTools_Click);
            // 
            // ChkHeadless
            // 
            this.ChkHeadless.AutoSize = true;
            this.ChkHeadless.Location = new System.Drawing.Point(10, 230);
            this.ChkHeadless.Name = "ChkHeadless";
            this.ChkHeadless.Size = new System.Drawing.Size(70, 17);
            this.ChkHeadless.TabIndex = 8;
            this.ChkHeadless.Text = "Headless";
            this.ChkHeadless.UseVisualStyleBackColor = true;
            // 
            // BtnInjection
            // 
            this.BtnInjection.Location = new System.Drawing.Point(92, 44);
            this.BtnInjection.Name = "BtnInjection";
            this.BtnInjection.Size = new System.Drawing.Size(70, 26);
            this.BtnInjection.TabIndex = 9;
            this.BtnInjection.Text = "Injection";
            this.BtnInjection.UseVisualStyleBackColor = true;
            this.BtnInjection.Click += new System.EventHandler(this.BtnInjection_Click);
            // 
            // BtnWebhook
            // 
            this.BtnWebhook.Location = new System.Drawing.Point(12, 76);
            this.BtnWebhook.Name = "BtnWebhook";
            this.BtnWebhook.Size = new System.Drawing.Size(70, 26);
            this.BtnWebhook.TabIndex = 10;
            this.BtnWebhook.Text = "Webhook";
            this.BtnWebhook.UseVisualStyleBackColor = true;
            this.BtnWebhook.Click += new System.EventHandler(this.BtnWebhook_Click);
            // 
            // BtnBackups
            // 
            this.BtnBackups.Location = new System.Drawing.Point(92, 76);
            this.BtnBackups.Name = "BtnBackups";
            this.BtnBackups.Size = new System.Drawing.Size(70, 26);
            this.BtnBackups.TabIndex = 11;
            this.BtnBackups.Text = "Backups";
            this.BtnBackups.UseVisualStyleBackColor = true;
            // 
            // BtnProgramming
            // 
            this.BtnProgramming.Location = new System.Drawing.Point(10, 108);
            this.BtnProgramming.Name = "BtnProgramming";
            this.BtnProgramming.Size = new System.Drawing.Size(152, 26);
            this.BtnProgramming.TabIndex = 12;
            this.BtnProgramming.Text = "Programming";
            this.BtnProgramming.UseVisualStyleBackColor = true;
            // 
            // Toolsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 291);
            this.Controls.Add(this.BtnProgramming);
            this.Controls.Add(this.BtnBackups);
            this.Controls.Add(this.BtnWebhook);
            this.Controls.Add(this.BtnInjection);
            this.Controls.Add(this.ChkHeadless);
            this.Controls.Add(this.BtnServerTools);
            this.Controls.Add(this.BtnAllowedTools);
            this.Controls.Add(this.ChkQuote);
            this.Controls.Add(this.BtnApplyTools);
            this.Controls.Add(this.ChkDownload);
            this.Controls.Add(this.ChkReplyUnread);
            this.Controls.Add(this.ChkGroupReply);
            this.Controls.Add(this.BtnBlockedTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(190, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(190, 220);
            this.Name = "Toolsfrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            this.Load += new System.EventHandler(this.Toolsfrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBlockedTools;
        private System.Windows.Forms.CheckBox ChkGroupReply;
        private System.Windows.Forms.CheckBox ChkReplyUnread;
        private System.Windows.Forms.CheckBox ChkDownload;
        private System.Windows.Forms.Button BtnApplyTools;
        private System.Windows.Forms.CheckBox ChkQuote;
        private System.Windows.Forms.Button BtnAllowedTools;
        private System.Windows.Forms.Button BtnServerTools;
        private System.Windows.Forms.CheckBox ChkHeadless;
        private System.Windows.Forms.Button BtnInjection;
        private System.Windows.Forms.Button BtnWebhook;
        private System.Windows.Forms.Button BtnBackups;
        private System.Windows.Forms.Button BtnProgramming;
    }
}