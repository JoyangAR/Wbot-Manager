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
            this.ChkGroupReply.Location = new System.Drawing.Point(12, 53);
            this.ChkGroupReply.Name = "ChkGroupReply";
            this.ChkGroupReply.Size = new System.Drawing.Size(85, 17);
            this.ChkGroupReply.TabIndex = 1;
            this.ChkGroupReply.Text = "Group Reply";
            this.ChkGroupReply.UseVisualStyleBackColor = true;
            // 
            // ChkReplyUnread
            // 
            this.ChkReplyUnread.AutoSize = true;
            this.ChkReplyUnread.Location = new System.Drawing.Point(12, 76);
            this.ChkReplyUnread.Name = "ChkReplyUnread";
            this.ChkReplyUnread.Size = new System.Drawing.Size(137, 17);
            this.ChkReplyUnread.TabIndex = 2;
            this.ChkReplyUnread.Text = "Reply Unread Message";
            this.ChkReplyUnread.UseVisualStyleBackColor = true;
            // 
            // ChkDownload
            // 
            this.ChkDownload.AutoSize = true;
            this.ChkDownload.Location = new System.Drawing.Point(12, 99);
            this.ChkDownload.Name = "ChkDownload";
            this.ChkDownload.Size = new System.Drawing.Size(106, 17);
            this.ChkDownload.TabIndex = 3;
            this.ChkDownload.Text = "Download Media";
            this.ChkDownload.UseVisualStyleBackColor = true;
            // 
            // BtnApplyTools
            // 
            this.BtnApplyTools.Location = new System.Drawing.Point(48, 145);
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
            this.ChkQuote.Location = new System.Drawing.Point(12, 122);
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
            // Toolsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(174, 181);
            this.Controls.Add(this.BtnAllowedTools);
            this.Controls.Add(this.ChkQuote);
            this.Controls.Add(this.BtnApplyTools);
            this.Controls.Add(this.ChkDownload);
            this.Controls.Add(this.ChkReplyUnread);
            this.Controls.Add(this.ChkGroupReply);
            this.Controls.Add(this.BtnBlockedTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(190, 220);
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
    }
}