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
    public partial class F_List : Form
    {
        public F_List(String i)
        {
            InitializeComponent();
            tb_list.Text = i;
        }

        private void F_List_Load(object sender, EventArgs e)
        {

        }
    }
}
