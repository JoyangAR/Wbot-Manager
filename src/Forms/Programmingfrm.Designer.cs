namespace WbotMgr.src
{
    partial class Programmingfrm
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
            this.PgmTabControl = new System.Windows.Forms.TabControl();
            this.DateTabPage = new System.Windows.Forms.TabPage();
            this.LabelExistence = new System.Windows.Forms.Label();
            this.PgmMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.WeeklyTabPage = new System.Windows.Forms.TabPage();
            this.RadSunday = new System.Windows.Forms.RadioButton();
            this.RadSaturday = new System.Windows.Forms.RadioButton();
            this.RadSatAndSun = new System.Windows.Forms.RadioButton();
            this.RadFriday = new System.Windows.Forms.RadioButton();
            this.RadThursday = new System.Windows.Forms.RadioButton();
            this.RadWednesday = new System.Windows.Forms.RadioButton();
            this.RadTuesday = new System.Windows.Forms.RadioButton();
            this.RadMonday = new System.Windows.Forms.RadioButton();
            this.RadMonToFrid = new System.Windows.Forms.RadioButton();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PgmMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSchedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PgmTabControl.SuspendLayout();
            this.DateTabPage.SuspendLayout();
            this.WeeklyTabPage.SuspendLayout();
            this.PgmMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PgmTabControl
            // 
            this.PgmTabControl.Controls.Add(this.DateTabPage);
            this.PgmTabControl.Controls.Add(this.WeeklyTabPage);
            this.PgmTabControl.Location = new System.Drawing.Point(12, 43);
            this.PgmTabControl.Name = "PgmTabControl";
            this.PgmTabControl.SelectedIndex = 0;
            this.PgmTabControl.Size = new System.Drawing.Size(287, 301);
            this.PgmTabControl.TabIndex = 4;
            // 
            // DateTabPage
            // 
            this.DateTabPage.Controls.Add(this.LabelExistence);
            this.DateTabPage.Controls.Add(this.PgmMonthCalendar);
            this.DateTabPage.Location = new System.Drawing.Point(4, 22);
            this.DateTabPage.Name = "DateTabPage";
            this.DateTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DateTabPage.Size = new System.Drawing.Size(279, 275);
            this.DateTabPage.TabIndex = 0;
            this.DateTabPage.Text = "By Date";
            this.DateTabPage.UseVisualStyleBackColor = true;
            // 
            // LabelExistence
            // 
            this.LabelExistence.AutoSize = true;
            this.LabelExistence.Location = new System.Drawing.Point(11, 183);
            this.LabelExistence.Name = "LabelExistence";
            this.LabelExistence.Size = new System.Drawing.Size(53, 13);
            this.LabelExistence.TabIndex = 5;
            this.LabelExistence.Text = "Existence";
            // 
            // PgmMonthCalendar
            // 
            this.PgmMonthCalendar.Location = new System.Drawing.Point(14, 12);
            this.PgmMonthCalendar.Name = "PgmMonthCalendar";
            this.PgmMonthCalendar.TabIndex = 4;
            this.PgmMonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.PgmMonthCalendar_DateChanged);
            // 
            // WeeklyTabPage
            // 
            this.WeeklyTabPage.Controls.Add(this.RadSunday);
            this.WeeklyTabPage.Controls.Add(this.RadSaturday);
            this.WeeklyTabPage.Controls.Add(this.RadSatAndSun);
            this.WeeklyTabPage.Controls.Add(this.RadFriday);
            this.WeeklyTabPage.Controls.Add(this.RadThursday);
            this.WeeklyTabPage.Controls.Add(this.RadWednesday);
            this.WeeklyTabPage.Controls.Add(this.RadTuesday);
            this.WeeklyTabPage.Controls.Add(this.RadMonday);
            this.WeeklyTabPage.Controls.Add(this.RadMonToFrid);
            this.WeeklyTabPage.Location = new System.Drawing.Point(4, 22);
            this.WeeklyTabPage.Name = "WeeklyTabPage";
            this.WeeklyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.WeeklyTabPage.Size = new System.Drawing.Size(279, 275);
            this.WeeklyTabPage.TabIndex = 1;
            this.WeeklyTabPage.Text = "Weekly";
            this.WeeklyTabPage.UseVisualStyleBackColor = true;
            // 
            // RadSunday
            // 
            this.RadSunday.AutoSize = true;
            this.RadSunday.Location = new System.Drawing.Point(6, 220);
            this.RadSunday.Name = "RadSunday";
            this.RadSunday.Size = new System.Drawing.Size(61, 17);
            this.RadSunday.TabIndex = 15;
            this.RadSunday.Text = "Sunday";
            this.RadSunday.UseVisualStyleBackColor = true;
            // 
            // RadSaturday
            // 
            this.RadSaturday.AutoSize = true;
            this.RadSaturday.Location = new System.Drawing.Point(6, 197);
            this.RadSaturday.Name = "RadSaturday";
            this.RadSaturday.Size = new System.Drawing.Size(67, 17);
            this.RadSaturday.TabIndex = 14;
            this.RadSaturday.Text = "Saturday";
            this.RadSaturday.UseVisualStyleBackColor = true;
            // 
            // RadSatAndSun
            // 
            this.RadSatAndSun.AutoSize = true;
            this.RadSatAndSun.Location = new System.Drawing.Point(6, 174);
            this.RadSatAndSun.Name = "RadSatAndSun";
            this.RadSatAndSun.Size = new System.Drawing.Size(127, 17);
            this.RadSatAndSun.TabIndex = 13;
            this.RadSatAndSun.Text = "Saturday and Sunday";
            this.RadSatAndSun.UseVisualStyleBackColor = true;
            // 
            // RadFriday
            // 
            this.RadFriday.AutoSize = true;
            this.RadFriday.Location = new System.Drawing.Point(8, 137);
            this.RadFriday.Name = "RadFriday";
            this.RadFriday.Size = new System.Drawing.Size(53, 17);
            this.RadFriday.TabIndex = 12;
            this.RadFriday.Text = "Friday";
            this.RadFriday.UseVisualStyleBackColor = true;
            // 
            // RadThursday
            // 
            this.RadThursday.AutoSize = true;
            this.RadThursday.Location = new System.Drawing.Point(8, 114);
            this.RadThursday.Name = "RadThursday";
            this.RadThursday.Size = new System.Drawing.Size(69, 17);
            this.RadThursday.TabIndex = 11;
            this.RadThursday.Text = "Thursday";
            this.RadThursday.UseVisualStyleBackColor = true;
            // 
            // RadWednesday
            // 
            this.RadWednesday.AutoSize = true;
            this.RadWednesday.Location = new System.Drawing.Point(8, 91);
            this.RadWednesday.Name = "RadWednesday";
            this.RadWednesday.Size = new System.Drawing.Size(82, 17);
            this.RadWednesday.TabIndex = 10;
            this.RadWednesday.Text = "Wednesday";
            this.RadWednesday.UseVisualStyleBackColor = true;
            // 
            // RadTuesday
            // 
            this.RadTuesday.AutoSize = true;
            this.RadTuesday.Location = new System.Drawing.Point(8, 68);
            this.RadTuesday.Name = "RadTuesday";
            this.RadTuesday.Size = new System.Drawing.Size(66, 17);
            this.RadTuesday.TabIndex = 9;
            this.RadTuesday.Text = "Tuesday";
            this.RadTuesday.UseVisualStyleBackColor = true;
            // 
            // RadMonday
            // 
            this.RadMonday.AutoSize = true;
            this.RadMonday.Location = new System.Drawing.Point(8, 45);
            this.RadMonday.Name = "RadMonday";
            this.RadMonday.Size = new System.Drawing.Size(63, 17);
            this.RadMonday.TabIndex = 8;
            this.RadMonday.Text = "Monday";
            this.RadMonday.UseVisualStyleBackColor = true;
            // 
            // RadMonToFrid
            // 
            this.RadMonToFrid.AutoSize = true;
            this.RadMonToFrid.Checked = true;
            this.RadMonToFrid.Location = new System.Drawing.Point(8, 22);
            this.RadMonToFrid.Name = "RadMonToFrid";
            this.RadMonToFrid.Size = new System.Drawing.Size(106, 17);
            this.RadMonToFrid.TabIndex = 7;
            this.RadMonToFrid.TabStop = true;
            this.RadMonToFrid.Text = "Monday to Friday";
            this.RadMonToFrid.UseVisualStyleBackColor = true;
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(220, 350);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(75, 23);
            this.BtnApply.TabIndex = 5;
            this.BtnApply.Text = "Apply";
            this.BtnApply.UseVisualStyleBackColor = true;
            this.BtnApply.Click += new System.EventHandler(this.BtnApply_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(139, 350);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 350);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // PgmMenuStrip
            // 
            this.PgmMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.PgmMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.PgmMenuStrip.Name = "PgmMenuStrip";
            this.PgmMenuStrip.Size = new System.Drawing.Size(311, 24);
            this.PgmMenuStrip.TabIndex = 8;
            this.PgmMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoSchedulerToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // autoSchedulerToolStripMenuItem
            // 
            this.autoSchedulerToolStripMenuItem.Name = "autoSchedulerToolStripMenuItem";
            this.autoSchedulerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.autoSchedulerToolStripMenuItem.Text = "Auto Scheduler";
            this.autoSchedulerToolStripMenuItem.Click += new System.EventHandler(this.autoSchedulerToolStripMenuItem_Click);
            // 
            // Programmingfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 385);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.PgmTabControl);
            this.Controls.Add(this.PgmMenuStrip);
            this.MainMenuStrip = this.PgmMenuStrip;
            this.Name = "Programmingfrm";
            this.ShowIcon = false;
            this.Text = "Programming Manager";
            this.Load += new System.EventHandler(this.Programmingfrm_Load);
            this.PgmTabControl.ResumeLayout(false);
            this.DateTabPage.ResumeLayout(false);
            this.DateTabPage.PerformLayout();
            this.WeeklyTabPage.ResumeLayout(false);
            this.WeeklyTabPage.PerformLayout();
            this.PgmMenuStrip.ResumeLayout(false);
            this.PgmMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl PgmTabControl;
        private System.Windows.Forms.TabPage DateTabPage;
        private System.Windows.Forms.MonthCalendar PgmMonthCalendar;
        private System.Windows.Forms.TabPage WeeklyTabPage;
        private System.Windows.Forms.RadioButton RadSunday;
        private System.Windows.Forms.RadioButton RadSaturday;
        private System.Windows.Forms.RadioButton RadSatAndSun;
        private System.Windows.Forms.RadioButton RadFriday;
        private System.Windows.Forms.RadioButton RadThursday;
        private System.Windows.Forms.RadioButton RadWednesday;
        private System.Windows.Forms.RadioButton RadTuesday;
        private System.Windows.Forms.RadioButton RadMonday;
        private System.Windows.Forms.RadioButton RadMonToFrid;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label LabelExistence;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.MenuStrip PgmMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSchedulerToolStripMenuItem;
    }
}