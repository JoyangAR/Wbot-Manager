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
    public partial class InputForm : Form
    {
        public string UserInput { get; private set; }

        public InputForm()
        {
            InitializeComponent();
        }

        public void BtnOk_Click(object sender, EventArgs e)
        {
            UserInput = TextBoxInput.Text;
            Close();
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            UserInput = null;
            Close();
        }

        
    }
}
