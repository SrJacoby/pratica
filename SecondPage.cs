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
    public partial class SecondPage : Form
    {
        List <CheckBox> options = new List <CheckBox> ();
        public SecondPage()
        {
            InitializeComponent();
            options.Add(cb_option1);
            options.Add(cb_option2);
            options.Add(cb_option3);
        }

        private void SecondPage_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (CheckBox o in options)
            {
                if (o.Checked)
                {
                    txt += o.Text + ", ";
                }
            }

            MessageBox.Show(txt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondFilho second = new SecondFilho();

            second.ShowDialog();
        }

        private void cb_option1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
