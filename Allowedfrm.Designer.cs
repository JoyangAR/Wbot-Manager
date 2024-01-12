namespace WbotMgr
{
    partial class Allowedfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AllowedList = new System.Windows.Forms.ListBox();
            this.AllowRemove = new System.Windows.Forms.Button();
            this.AllowAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnApply = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.peekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Allowed numbers";
            // 
            // AllowedList
            // 
            this.AllowedList.FormattingEnabled = true;
            this.AllowedList.Location = new System.Drawing.Point(9, 39);
            this.AllowedList.Name = "AllowedList";
            this.AllowedList.Size = new System.Drawing.Size(198, 381);
            this.AllowedList.TabIndex = 25;
            this.AllowedList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AllowedList_MouseClick);
            this.AllowedList.DoubleClick += new System.EventHandler(this.AllowedList_DoubleClick);
            // 
            // AllowRemove
            // 
            this.AllowRemove.Location = new System.Drawing.Point(178, 426);
            this.AllowRemove.Name = "AllowRemove";
            this.AllowRemove.Size = new System.Drawing.Size(29, 25);
            this.AllowRemove.TabIndex = 27;
            this.AllowRemove.Text = "-";
            this.AllowRemove.UseVisualStyleBackColor = true;
            this.AllowRemove.Click += new System.EventHandler(this.AllowRemove_Click);
            // 
            // AllowAdd
            // 
            this.AllowAdd.Location = new System.Drawing.Point(143, 426);
            this.AllowAdd.Name = "AllowAdd";
            this.AllowAdd.Size = new System.Drawing.Size(29, 25);
            this.AllowAdd.TabIndex = 26;
            this.AllowAdd.Text = "+";
            this.AllowAdd.UseVisualStyleBackColor = true;
            this.AllowAdd.Click += new System.EventHandler(this.AllowAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(62, 426);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(47, 25);
            this.BtnEdit.TabIndex = 29;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(9, 426);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(47, 25);
            this.BtnApply.TabIndex = 28;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
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
            // Allowedfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 463);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.AllowRemove);
            this.Controls.Add(this.AllowAdd);
            this.Controls.Add(this.AllowedList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(235, 502);
            this.MinimumSize = new System.Drawing.Size(235, 502);
            this.Name = "Allowedfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allowed";
            this.Load += new System.EventHandler(this.Allowedfrm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox AllowedList;
        private System.Windows.Forms.Button AllowRemove;
        private System.Windows.Forms.Button AllowAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
    }
}