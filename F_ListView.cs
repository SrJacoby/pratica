using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratica
{
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if(tb_id.Text == "" || tb_name.Text == "" || tb_dn.Text == "" || tb_phone.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else {
                string[] dp = new string[4];

                dp[0] = tb_id.Text;
                dp[1] = tb_name.Text;
                dp[2] = tb_dn.Text;
                dp[3] = tb_phone.Text;

                ListViewItem l = new ListViewItem(dp);
                lv_register.Items.Add(l);

                clear();
            }
        }

        private void clear()
        {
            tb_id.Clear();
            tb_name.Clear();
            tb_dn.Clear();
            tb_phone.Clear();
            tb_id.Focus();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if(lv_register.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro para removê-lo");
                return;
            }
            else { 
            lv_register.Items.RemoveAt(lv_register.SelectedIndices[0]);
            }
        }

        private void lv_register_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lv_register.SelectedItems.Count > 0) { 
                tb_id.Text = lv_register.SelectedItems[0].SubItems[0].Text;
                tb_name.Text = lv_register.SelectedItems[0].SubItems[1].Text;
                tb_dn.Text = lv_register.SelectedItems[0].SubItems[2].Text;
                tb_phone.Text = lv_register.SelectedItems[0].SubItems[3].Text;
            }
        }
    }
}
