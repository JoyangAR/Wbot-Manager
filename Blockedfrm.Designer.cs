namespace WbotMgr
{
    partial class Blockedfrm
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
            this.BlockedList = new System.Windows.Forms.ListBox();
            this.BlockRemove = new System.Windows.Forms.Button();
            this.BlockAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.peekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlockedList
            // 
            this.BlockedList.FormattingEnabled = true;
            this.BlockedList.Location = new System.Drawing.Point(9, 39);
            this.BlockedList.Name = "BlockedList";
            this.BlockedList.Size = new System.Drawing.Size(198, 381);
            this.BlockedList.TabIndex = 0;
            this.BlockedList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlockedList_MouseClick);
            this.BlockedList.DoubleClick += new System.EventHandler(this.BlockedList_DoubleClick);
            // 
            // BlockRemove
            // 
            this.BlockRemove.Location = new System.Drawing.Point(178, 426);
            this.BlockRemove.Name = "BlockRemove";
            this.BlockRemove.Size = new System.Drawing.Size(29, 25);
            this.BlockRemove.TabIndex = 22;
            this.BlockRemove.Text = "-";
            this.BlockRemove.UseVisualStyleBackColor = true;
            this.BlockRemove.Click += new System.EventHandler(this.BlockRemove_Click);
            // 
            // BlockAdd
            // 
            this.BlockAdd.Location = new System.Drawing.Point(143, 426);
            this.BlockAdd.Name = "BlockAdd";
            this.BlockAdd.Size = new System.Drawing.Size(29, 25);
            this.BlockAdd.TabIndex = 21;
            this.BlockAdd.Text = "+";
            this.BlockAdd.UseVisualStyleBackColor = true;
            this.BlockAdd.Click += new System.EventHandler(this.BlockAdd_Click);
            this.BlockAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BlockedList_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Blocked numbers";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(9, 426);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(47, 25);
            this.BtnApply.TabIndex = 24;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(62, 426);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(47, 25);
            this.BtnEdit.TabIndex = 25;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peekToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.addToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            // 
            // peekToolStripMenuItem
            // 
            this.peekToolStripMenuItem.Name = "peekToolStripMenuItem";
            this.peekToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.peekToolStripMenuItem.Text = "Peek";
            this.peekToolStripMenuItem.Click += new System.EventHandler(this.peekToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // Blockedfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 463);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BlockRemove);
            this.Controls.Add(this.BlockAdd);
            this.Controls.Add(this.BlockedList);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(235, 502);
            this.MinimumSize = new System.Drawing.Size(235, 502);
            this.Name = "Blockedfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blocked";
            this.Load += new System.EventHandler(this.Blockedfrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.ListBox BlockedList;
        private System.Windows.Forms.Button BlockRemove;
        private System.Windows.Forms.Button BlockAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peekToolStripMenuItem;
    }
}