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
    public partial class DbleInputfrm : Form
    {
        public string UserInput1 { get; private set; }
        public string UserInput2 { get; private set; }
        public bool delatfrstclic;
        public DbleInputfrm()
        {
            InitializeComponent();
        }

        public void BtnOk_Click(object sender, EventArgs e)
        {
            UserInput1 = TextBoxInput1.Text;
            UserInput2 = TextBoxInput2.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            UserInput1 = null;
            UserInput2 = null;
            Close();
        }

        private void TextBoxInput1_Click(object sender, EventArgs e)
        {
            if (delatfrstclic == true)
                {
                TextBoxInput1.Text = "";
                TextBoxInput2.Text = "";
                delatfrstclic = false;
            }
        }

        private void TextBoxInput1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBoxInput2.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxInput2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnOk_Click(sender, e);
            }
        }
    }
}
