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
    public partial class Inputfrm : Form
    {
        public string UserInput { get; private set; }

        public Inputfrm()
        {
            InitializeComponent();
        }

        public void BtnOk_Click(object sender, EventArgs e)
        {
            UserInput = TextBoxInput.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            UserInput = null;
            Close();
        }

        private void TextBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnOk_Click(sender, e);
            }
        }
    }
}
