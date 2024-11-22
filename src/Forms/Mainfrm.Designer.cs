using System.Windows.Forms;

namespace WbotMgr
{
    partial class Mainfrm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainfrm));
            this.TxtNameEdit = new System.Windows.Forms.TextBox();
            this.ExactListBox = new System.Windows.Forms.ListBox();
            this.ListboxesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExactAdd = new System.Windows.Forms.Button();
            this.ContainsListBox = new System.Windows.Forms.ListBox();
            this.ContainsRemove = new System.Windows.Forms.Button();
            this.ContainsAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnApply = new System.Windows.Forms.Button();
            this.ChkBoxCaption = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSecconds = new System.Windows.Forms.TextBox();
            this.BtnAttach = new System.Windows.Forms.Button();
            this.NameRemove = new System.Windows.Forms.Button();
            this.NameAdd = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noMatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBackupstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttachedFilesListBox = new System.Windows.Forms.ListBox();
            this.BtnDettach = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtReply = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbGroupEdit = new System.Windows.Forms.ComboBox();
            this.BtnMoveDown = new System.Windows.Forms.Button();
            this.BtnMoveUp = new System.Windows.Forms.Button();
            this.NameListBox = new System.Windows.Forms.ListBox();
            this.ExactRemove = new System.Windows.Forms.Button();
            this.BtnHints = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtWebhook = new System.Windows.Forms.TextBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.LabelAutoScheduler = new System.Windows.Forms.Label();
            this.ListboxesContextMenu.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.RichTextBoxContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtNameEdit
            // 
            this.TxtNameEdit.Location = new System.Drawing.Point(207, 72);
            this.TxtNameEdit.Name = "TxtNameEdit";
            this.TxtNameEdit.Size = new System.Drawing.Size(85, 20);
            this.TxtNameEdit.TabIndex = 1;
            // 
            // ExactListBox
            // 
            this.ExactListBox.ContextMenuStrip = this.ListboxesContextMenu;
            this.ExactListBox.FormattingEnabled = true;
            this.ExactListBox.Location = new System.Drawing.Point(207, 113);
            this.ExactListBox.Name = "ExactListBox";
            this.ExactListBox.Size = new System.Drawing.Size(85, 355);
            this.ExactListBox.TabIndex = 2;
            // 
            // ListboxesContextMenu
            // 
            this.ListboxesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.ListboxesContextMenu.Name = "ListboxesContextMenu";
            this.ListboxesContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ListboxesContextMenu.Size = new System.Drawing.Size(118, 48);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ExactAdd
            // 
            this.ExactAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExactAdd.Location = new System.Drawing.Point(298, 113);
            this.ExactAdd.Name = "ExactAdd";
            this.ExactAdd.Size = new System.Drawing.Size(29, 25);
            this.ExactAdd.TabIndex = 3;
            this.ExactAdd.Text = "+";
            this.ExactAdd.UseVisualStyleBackColor = true;
            this.ExactAdd.Click += new System.EventHandler(this.ExactAdd_Click);
            // 
            // ContainsListBox
            // 
            this.ContainsListBox.ContextMenuStrip = this.ListboxesContextMenu;
            this.ContainsListBox.FormattingEnabled = true;
            this.ContainsListBox.Location = new System.Drawing.Point(360, 113);
            this.ContainsListBox.Name = "ContainsListBox";
            this.ContainsListBox.Size = new System.Drawing.Size(85, 355);
            this.ContainsListBox.TabIndex = 5;
            // 
            // ContainsRemove
            // 
            this.ContainsRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainsRemove.Location = new System.Drawing.Point(451, 144);
            this.ContainsRemove.Name = "ContainsRemove";
            this.ContainsRemove.Size = new System.Drawing.Size(29, 25);
            this.ContainsRemove.TabIndex = 7;
            this.ContainsRemove.Text = "-";
            this.ContainsRemove.UseVisualStyleBackColor = true;
            this.ContainsRemove.Click += new System.EventHandler(this.ContainsRemove_Click);
            // 
            // ContainsAdd
            // 
            this.ContainsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainsAdd.Location = new System.Drawing.Point(451, 113);
            this.ContainsAdd.Name = "ContainsAdd";
            this.ContainsAdd.Size = new System.Drawing.Size(29, 25);
            this.ContainsAdd.TabIndex = 6;
            this.ContainsAdd.Text = "+";
            this.ContainsAdd.UseVisualStyleBackColor = true;
            this.ContainsAdd.Click += new System.EventHandler(this.ContainsAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contains";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Exact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Section Name";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(841, 440);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(49, 25);
            this.BtnApply.TabIndex = 13;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.ApplyChanges_Click);
            // 
            // ChkBoxCaption
            // 
            this.ChkBoxCaption.AutoSize = true;
            this.ChkBoxCaption.Location = new System.Drawing.Point(498, 346);
            this.ChkBoxCaption.Name = "ChkBoxCaption";
            this.ChkBoxCaption.Size = new System.Drawing.Size(127, 17);
            this.ChkBoxCaption.TabIndex = 14;
            this.ChkBoxCaption.Text = "Response as Caption";
            this.ChkBoxCaption.UseVisualStyleBackColor = true;
            this.ChkBoxCaption.CheckedChanged += new System.EventHandler(this.ChkBoxCaption_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "After Secconds";
            // 
            // TxtSecconds
            // 
            this.TxtSecconds.Location = new System.Drawing.Point(574, 320);
            this.TxtSecconds.Name = "TxtSecconds";
            this.TxtSecconds.Size = new System.Drawing.Size(51, 20);
            this.TxtSecconds.TabIndex = 16;
            // 
            // BtnAttach
            // 
            this.BtnAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttach.Location = new System.Drawing.Point(631, 349);
            this.BtnAttach.Name = "BtnAttach";
            this.BtnAttach.Size = new System.Drawing.Size(27, 25);
            this.BtnAttach.TabIndex = 17;
            this.BtnAttach.Text = "+";
            this.BtnAttach.UseVisualStyleBackColor = true;
            this.BtnAttach.Click += new System.EventHandler(this.BtnAttach_Click);
            // 
            // NameRemove
            // 
            this.NameRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRemove.Location = new System.Drawing.Point(163, 131);
            this.NameRemove.Name = "NameRemove";
            this.NameRemove.Size = new System.Drawing.Size(29, 25);
            this.NameRemove.TabIndex = 20;
            this.NameRemove.Text = "-";
            this.NameRemove.UseVisualStyleBackColor = true;
            this.NameRemove.Click += new System.EventHandler(this.NameRemove_Click);
            // 
            // NameAdd
            // 
            this.NameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameAdd.Location = new System.Drawing.Point(163, 100);
            this.NameAdd.Name = "NameAdd";
            this.NameAdd.Size = new System.Drawing.Size(29, 25);
            this.NameAdd.TabIndex = 19;
            this.NameAdd.Text = "+";
            this.NameAdd.UseVisualStyleBackColor = true;
            this.NameAdd.Click += new System.EventHandler(this.NameAdd_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otherToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenuStrip.Size = new System.Drawing.Size(910, 24);
            this.MainMenuStrip.TabIndex = 22;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blockedToolStripMenuItem,
            this.allowedToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.noMatchToolStripMenuItem,
            this.createBackupToolStripMenuItem,
            this.manageBackupstoolStripMenuItem,
            this.programmingsToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // blockedToolStripMenuItem
            // 
            this.blockedToolStripMenuItem.Name = "blockedToolStripMenuItem";
            this.blockedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blockedToolStripMenuItem.Text = "Blocked";
            this.blockedToolStripMenuItem.Click += new System.EventHandler(this.blockedToolStripMenuItem_Click);
            // 
            // allowedToolStripMenuItem
            // 
            this.allowedToolStripMenuItem.Name = "allowedToolStripMenuItem";
            this.allowedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allowedToolStripMenuItem.Text = "Allowed";
            this.allowedToolStripMenuItem.Click += new System.EventHandler(this.allowedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // noMatchToolStripMenuItem
            // 
            this.noMatchToolStripMenuItem.Name = "noMatchToolStripMenuItem";
            this.noMatchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.noMatchToolStripMenuItem.Text = "No Match";
            this.noMatchToolStripMenuItem.Click += new System.EventHandler(this.noMatchToolStripMenuItem_Click);
            // 
            // createBackupToolStripMenuItem
            // 
            this.createBackupToolStripMenuItem.Name = "createBackupToolStripMenuItem";
            this.createBackupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createBackupToolStripMenuItem.Text = "Create Backup";
            this.createBackupToolStripMenuItem.Click += new System.EventHandler(this.createBackupToolStripMenuItem_Click);
            // 
            // manageBackupstoolStripMenuItem
            // 
            this.manageBackupstoolStripMenuItem.Name = "manageBackupstoolStripMenuItem";
            this.manageBackupstoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageBackupstoolStripMenuItem.Text = "Manage Backups";
            this.manageBackupstoolStripMenuItem.Click += new System.EventHandler(this.manageBackupstoolStripMenuItem_Click);
            // 
            // programmingsToolStripMenuItem
            // 
            this.programmingsToolStripMenuItem.Name = "programmingsToolStripMenuItem";
            this.programmingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programmingsToolStripMenuItem.Text = "Programmings";
            this.programmingsToolStripMenuItem.Click += new System.EventHandler(this.programmingsToolStripMenuItem_Click);
            // 
            // AttachedFilesListBox
            // 
            this.AttachedFilesListBox.FormattingEnabled = true;
            this.AttachedFilesListBox.Location = new System.Drawing.Point(664, 349);
            this.AttachedFilesListBox.Name = "AttachedFilesListBox";
            this.AttachedFilesListBox.Size = new System.Drawing.Size(171, 82);
            this.AttachedFilesListBox.TabIndex = 23;
            // 
            // BtnDettach
            // 
            this.BtnDettach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDettach.Location = new System.Drawing.Point(631, 380);
            this.BtnDettach.Name = "BtnDettach";
            this.BtnDettach.Size = new System.Drawing.Size(27, 25);
            this.BtnDettach.TabIndex = 24;
            this.BtnDettach.Text = "-";
            this.BtnDettach.UseVisualStyleBackColor = true;
            this.BtnDettach.Click += new System.EventHandler(this.BtnDettach_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(661, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Files Attached";
            // 
            // TxtReply
            // 
            this.TxtReply.ContextMenuStrip = this.RichTextBoxContextMenu;
            this.TxtReply.Location = new System.Drawing.Point(498, 72);
            this.TxtReply.Name = "TxtReply";
            this.TxtReply.Size = new System.Drawing.Size(392, 238);
            this.TxtReply.TabIndex = 26;
            this.TxtReply.Text = "";
            // 
            // RichTextBoxContextMenu
            // 
            this.RichTextBoxContextMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RichTextBoxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.RichTextBoxContextMenu.Name = "RichTextBoxContextMenu";
            this.RichTextBoxContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.RichTextBoxContextMenu.Size = new System.Drawing.Size(123, 92);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(317, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Section Group";
            // 
            // CmbGroupEdit
            // 
            this.CmbGroupEdit.FormattingEnabled = true;
            this.CmbGroupEdit.Location = new System.Drawing.Point(320, 71);
            this.CmbGroupEdit.Name = "CmbGroupEdit";
            this.CmbGroupEdit.Size = new System.Drawing.Size(85, 21);
            this.CmbGroupEdit.TabIndex = 29;
            // 
            // BtnMoveDown
            // 
            this.BtnMoveDown.Enabled = false;
            this.BtnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveDown.Location = new System.Drawing.Point(163, 211);
            this.BtnMoveDown.Name = "BtnMoveDown";
            this.BtnMoveDown.Size = new System.Drawing.Size(29, 25);
            this.BtnMoveDown.TabIndex = 31;
            this.BtnMoveDown.Text = "🔽";
            this.BtnMoveDown.UseVisualStyleBackColor = true;
            this.BtnMoveDown.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // BtnMoveUp
            // 
            this.BtnMoveUp.Enabled = false;
            this.BtnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveUp.Location = new System.Drawing.Point(163, 180);
            this.BtnMoveUp.Name = "BtnMoveUp";
            this.BtnMoveUp.Size = new System.Drawing.Size(29, 25);
            this.BtnMoveUp.TabIndex = 30;
            this.BtnMoveUp.Text = "🔼";
            this.BtnMoveUp.UseVisualStyleBackColor = true;
            this.BtnMoveUp.Click += new System.EventHandler(this.BtnMoveUp_Click);
            // 
            // NameListBox
            // 
            this.NameListBox.ContextMenuStrip = this.ListboxesContextMenu;
            this.NameListBox.FormattingEnabled = true;
            this.NameListBox.Location = new System.Drawing.Point(17, 100);
            this.NameListBox.Name = "NameListBox";
            this.NameListBox.Size = new System.Drawing.Size(140, 368);
            this.NameListBox.TabIndex = 32;
            this.NameListBox.SelectedIndexChanged += new System.EventHandler(this.NameListBox_SelectedIndexChanged);
            // 
            // ExactRemove
            // 
            this.ExactRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExactRemove.Location = new System.Drawing.Point(298, 144);
            this.ExactRemove.Name = "ExactRemove";
            this.ExactRemove.Size = new System.Drawing.Size(29, 25);
            this.ExactRemove.TabIndex = 4;
            this.ExactRemove.Text = "-";
            this.ExactRemove.UseVisualStyleBackColor = true;
            this.ExactRemove.Click += new System.EventHandler(this.ExactRemove_Click);
            // 
            // BtnHints
            // 
            this.BtnHints.Location = new System.Drawing.Point(864, 316);
            this.BtnHints.Name = "BtnHints";
            this.BtnHints.Size = new System.Drawing.Size(25, 25);
            this.BtnHints.TabIndex = 33;
            this.BtnHints.Text = "🛈";
            this.BtnHints.UseVisualStyleBackColor = true;
            this.BtnHints.Click += new System.EventHandler(this.BtnHints_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(495, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Webhook:";
            // 
            // TxtWebhook
            // 
            this.TxtWebhook.Location = new System.Drawing.Point(558, 437);
            this.TxtWebhook.Name = "TxtWebhook";
            this.TxtWebhook.Size = new System.Drawing.Size(277, 20);
            this.TxtWebhook.TabIndex = 35;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(17, 72);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(140, 20);
            this.TxtSearch.TabIndex = 36;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Search:";
            // 
            // LabelAutoScheduler
            // 
            this.LabelAutoScheduler.AutoSize = true;
            this.LabelAutoScheduler.ForeColor = System.Drawing.Color.Red;
            this.LabelAutoScheduler.Location = new System.Drawing.Point(20, 33);
            this.LabelAutoScheduler.Name = "LabelAutoScheduler";
            this.LabelAutoScheduler.Size = new System.Drawing.Size(103, 13);
            this.LabelAutoScheduler.TabIndex = 38;
            this.LabelAutoScheduler.Text = "Auto Scheduler OFF";
            // 
            // Mainfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 476);
            this.Controls.Add(this.LabelAutoScheduler);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.TxtWebhook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnHints);
            this.Controls.Add(this.NameListBox);
            this.Controls.Add(this.BtnMoveDown);
            this.Controls.Add(this.BtnMoveUp);
            this.Controls.Add(this.CmbGroupEdit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtReply);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnDettach);
            this.Controls.Add(this.AttachedFilesListBox);
            this.Controls.Add(this.NameRemove);
            this.Controls.Add(this.NameAdd);
            this.Controls.Add(this.BtnAttach);
            this.Controls.Add(this.TxtSecconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChkBoxCaption);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ContainsRemove);
            this.Controls.Add(this.ContainsAdd);
            this.Controls.Add(this.ContainsListBox);
            this.Controls.Add(this.ExactRemove);
            this.Controls.Add(this.ExactAdd);
            this.Controls.Add(this.ExactListBox);
            this.Controls.Add(this.TxtNameEdit);
            this.Controls.Add(this.MainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Mainfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wbot Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ListboxesContextMenu.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.RichTextBoxContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtNameEdit;
        private System.Windows.Forms.ListBox ExactListBox;
        private System.Windows.Forms.Button ExactAdd;
        private System.Windows.Forms.ListBox ContainsListBox;
        private System.Windows.Forms.Button ContainsRemove;
        private System.Windows.Forms.Button ContainsAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.CheckBox ChkBoxCaption;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSecconds;
        private System.Windows.Forms.Button BtnAttach;
        private System.Windows.Forms.Button NameRemove;
        private System.Windows.Forms.Button NameAdd;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ListBox AttachedFilesListBox;
        private System.Windows.Forms.Button BtnDettach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem noMatchToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TxtReply;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbGroupEdit;
        private System.Windows.Forms.Button BtnMoveDown;
        private System.Windows.Forms.Button BtnMoveUp;
        private System.Windows.Forms.ListBox NameListBox;
        private System.Windows.Forms.Button ExactRemove;
        private ToolStripMenuItem allowedToolStripMenuItem;
        private Button BtnHints;
        private Label label8;
        private TextBox TxtWebhook;
        private TextBox TxtSearch;
        private Label label9;
        private ToolStripMenuItem createBackupToolStripMenuItem;
        private ToolStripMenuItem manageBackupstoolStripMenuItem;
        private ContextMenuStrip ListboxesContextMenu;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ContextMenuStrip RichTextBoxContextMenu;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem programmingsToolStripMenuItem;
        private Label LabelAutoScheduler;
    }
}

