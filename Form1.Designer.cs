namespace pratica
{
    partial class F_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_add = new System.Windows.Forms.Button();
            this.tb_addProduct = new System.Windows.Forms.TextBox();
            this.tb_listaProdutos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.segundaPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(71, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(175, 34);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // tb_addProduct
            // 
            this.tb_addProduct.Location = new System.Drawing.Point(71, 375);
            this.tb_addProduct.Name = "tb_addProduct";
            this.tb_addProduct.Size = new System.Drawing.Size(175, 20);
            this.tb_addProduct.TabIndex = 1;
            // 
            // tb_listaProdutos
            // 
            this.tb_listaProdutos.Location = new System.Drawing.Point(12, 83);
            this.tb_listaProdutos.Multiline = true;
            this.tb_listaProdutos.Name = "tb_listaProdutos";
            this.tb_listaProdutos.ReadOnly = true;
            this.tb_listaProdutos.Size = new System.Drawing.Size(301, 269);
            this.tb_listaProdutos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Digite o que precisa comprar:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(71, 441);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(175, 34);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(71, 481);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(175, 34);
            this.btn_show.TabIndex = 0;
            this.btn_show.Text = "Ver";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segundaPáginaToolStripMenuItem,
            this.listViewToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(347, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // segundaPáginaToolStripMenuItem
            // 
            this.segundaPáginaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listViewToolStripMenuItem});
            this.segundaPáginaToolStripMenuItem.Name = "segundaPáginaToolStripMenuItem";
            this.segundaPáginaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.segundaPáginaToolStripMenuItem.Text = "Segunda Página";
            this.segundaPáginaToolStripMenuItem.Click += new System.EventHandler(this.segundaPáginaToolStripMenuItem_Click);
            // 
            // listViewToolStripMenuItem
            // 
            this.listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            this.listViewToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.listViewToolStripMenuItem.Text = "ListView";
            // 
            // listViewToolStripMenuItem1
            // 
            this.listViewToolStripMenuItem1.Name = "listViewToolStripMenuItem1";
            this.listViewToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.listViewToolStripMenuItem1.Text = "ListView";
            this.listViewToolStripMenuItem1.Click += new System.EventHandler(this.listViewToolStripMenuItem1_Click);
            // 
            // F_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_listaProdutos);
            this.Controls.Add(this.tb_addProduct);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Compras";
            this.Load += new System.EventHandler(this.F_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox tb_addProduct;
        private System.Windows.Forms.TextBox tb_listaProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem segundaPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listViewToolStripMenuItem1;
    }
}

