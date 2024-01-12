namespace WbotMgr
{
    partial class DbleInputfrm
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
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.TextBoxInput1 = new System.Windows.Forms.TextBox();
            this.TextBoxInput2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(112, 105);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(56, 33);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(12, 105);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(56, 33);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "Okey";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // TextBoxInput1
            // 
            this.TextBoxInput1.Location = new System.Drawing.Point(12, 25);
            this.TextBoxInput1.Name = "TextBoxInput1";
            this.TextBoxInput1.Size = new System.Drawing.Size(156, 20);
            this.TextBoxInput1.TabIndex = 3;
            // 
            // TextBoxInput2
            // 
            this.TextBoxInput2.Location = new System.Drawing.Point(12, 65);
            this.TextBoxInput2.Name = "TextBoxInput2";
            this.TextBoxInput2.Size = new System.Drawing.Size(156, 20);
            this.TextBoxInput2.TabIndex = 6;
            // 
            // DbleInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 150);
            this.ControlBox = false;
            this.Controls.Add(this.TextBoxInput2);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.TextBoxInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DbleInputForm";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnOk;
        public System.Windows.Forms.TextBox TextBoxInput1;
        public System.Windows.Forms.TextBox TextBoxInput2;
    }
}