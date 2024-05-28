using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica
{
    public partial class SecondFilho : Form
    {
        public SecondPage secondPage;
        public SecondFilho()
        {
            InitializeComponent();


            secondPage = Application.OpenForms["SecondPage"] as SecondPage;
            cb_option1.Checked = secondPage.cb_option1.Checked;
            cb_option2.Checked = secondPage.cb_option2.Checked;
            cb_option3.Checked = secondPage.cb_option3.Checked;
        }

        private void SecondFilho_Load(object sender, EventArgs e)
        {

        }

        private void cb_option1_CheckedChanged(object sender, EventArgs e)
        {
            secondPage.cb_option1.Checked = cb_option1.Checked;
        }

        private void cb_option2_CheckedChanged(object sender, EventArgs e)
        {
            secondPage.cb_option2.Checked = cb_option2.Checked;
        }

        private void cb_option3_CheckedChanged(object sender, EventArgs e)
        {
            secondPage.cb_option3.Checked = cb_option3.Checked;
        }
    }
}
