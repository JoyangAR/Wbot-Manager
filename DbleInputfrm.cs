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
        public DbleInputfrm()
        {
            InitializeComponent();
        }

        public void BtnOk_Click(object sender, EventArgs e)
        {
            UserInput1 = TextBoxInput1.Text;
            UserInput2 = TextBoxInput2.Text;
            Close();
        }

        public void BtnCancel_Click(object sender, EventArgs e)
        {
            UserInput1 = null;
            UserInput2 = null;
            Close();
        }
    }
}
