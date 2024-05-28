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
    public partial class F_Principal : Form
    {
        public F_Principal()
        {
            InitializeComponent();
        }

        private void F_Principal_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_addProduct.Text == "")
            {
                MessageBox.Show("Adicione produtos na lista");
                tb_addProduct.Focus();
                return;

            }

            tb_listaProdutos.Text += tb_addProduct.Text + ", ";
            tb_addProduct.Clear();
            tb_addProduct.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_listaProdutos.Clear();
            tb_addProduct.Clear();
            tb_addProduct.Focus();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            F_List f_List = new F_List(tb_listaProdutos.Text);

            f_List.Show();
        }

        private void segundaPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondPage secondPage = new SecondPage();
            secondPage.Show();
        }

        private void listViewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();
        }
    }
}
