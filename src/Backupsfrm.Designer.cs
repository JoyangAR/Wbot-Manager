namespace WbotMgr
{
    partial class Backupsfrm
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
            this.components = new System.ComponentModel.Container();
            this.BackupsListBox = new System.Windows.Forms.ListBox();
            this.BtnCreateBackup = new System.Windows.Forms.Button();
            this.BtnDeleteBackup = new System.Windows.Forms.Button();
            this.BtnRestoreBackup = new System.Windows.Forms.Button();
            this.BackupsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupsContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupsListBox
            // 
            this.BackupsListBox.ContextMenuStrip = this.BackupsContextMenuStrip;
            this.BackupsListBox.FormattingEnabled = true;
            this.BackupsListBox.Location = new System.Drawing.Point(12, 12);
            this.BackupsListBox.Name = "BackupsListBox";
            this.BackupsListBox.Size = new System.Drawing.Size(270, 394);
            this.BackupsListBox.TabIndex = 0;
            // 
            // BtnCreateBackup
            // 
            this.BtnCreateBackup.Location = new System.Drawing.Point(288, 12);
            this.BtnCreateBackup.Name = "BtnCreateBackup";
            this.BtnCreateBackup.Size = new System.Drawing.Size(59, 25);
            this.BtnCreateBackup.TabIndex = 1;
            this.BtnCreateBackup.Text = "Create";
            this.BtnCreateBackup.UseVisualStyleBackColor = true;
            this.BtnCreateBackup.Click += new System.EventHandler(this.BtnCreateBackup_Click);
            // 
            // BtnDeleteBackup
            // 
            this.BtnDeleteBackup.Location = new System.Drawing.Point(288, 43);
            this.BtnDeleteBackup.Name = "BtnDeleteBackup";
            this.BtnDeleteBackup.Size = new System.Drawing.Size(59, 25);
            this.BtnDeleteBackup.TabIndex = 2;
            this.BtnDeleteBackup.Text = "Delete";
            this.BtnDeleteBackup.UseVisualStyleBackColor = true;
            this.BtnDeleteBackup.Click += new System.EventHandler(this.BtnDeleteBackup_Click);
            // 
            // BtnRestoreBackup
            // 
            this.BtnRestoreBackup.Location = new System.Drawing.Point(288, 74);
            this.BtnRestoreBackup.Name = "BtnRestoreBackup";
            this.BtnRestoreBackup.Size = new System.Drawing.Size(59, 25);
            this.BtnRestoreBackup.TabIndex = 3;
            this.BtnRestoreBackup.Text = "Restore";
            this.BtnRestoreBackup.UseVisualStyleBackColor = true;
            this.BtnRestoreBackup.Click += new System.EventHandler(this.BtnRestoreBackup_Click);
            // 
            // BackupsContextMenuStrip
            // 
            this.BackupsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.BackupsContextMenuStrip.Name = "BackupsContextMenuStrip";
            this.BackupsContextMenuStrip.Size = new System.Drawing.Size(181, 70);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreToolStripMenuItem.Text = "Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // Backupsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 417);
            this.Controls.Add(this.BtnRestoreBackup);
            this.Controls.Add(this.BtnDeleteBackup);
            this.Controls.Add(this.BtnCreateBackup);
            this.Controls.Add(this.BackupsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Backupsfrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup Manager";
            this.Load += new System.EventHandler(this.Backupsfrm_Load);
            this.BackupsContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BackupsListBox;
        private System.Windows.Forms.Button BtnCreateBackup;
        private System.Windows.Forms.Button BtnDeleteBackup;
        private System.Windows.Forms.Button BtnRestoreBackup;
        private System.Windows.Forms.ContextMenuStrip BackupsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
    }
}