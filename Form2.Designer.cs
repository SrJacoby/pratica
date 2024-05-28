namespace pratica
{
    partial class F_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_textLista = new System.Windows.Forms.Label();
            this.tb_list = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_textLista
            // 
            this.lbl_textLista.AutoSize = true;
            this.lbl_textLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textLista.Location = new System.Drawing.Point(179, 9);
            this.lbl_textLista.Name = "lbl_textLista";
            this.lbl_textLista.Size = new System.Drawing.Size(303, 26);
            this.lbl_textLista.TabIndex = 0;
            this.lbl_textLista.Text = "Itens adicionados na sua lista:";
            // 
            // tb_list
            // 
            this.tb_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_list.Location = new System.Drawing.Point(109, 38);
            this.tb_list.Multiline = true;
            this.tb_list.Name = "tb_list";
            this.tb_list.ReadOnly = true;
            this.tb_list.Size = new System.Drawing.Size(433, 386);
            this.tb_list.TabIndex = 1;
            // 
            // F_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.tb_list);
            this.Controls.Add(this.lbl_textLista);
            this.Name = "F_List";
            this.Text = "Lista de Compras";
            this.Load += new System.EventHandler(this.F_List_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textLista;
        private System.Windows.Forms.TextBox tb_list;
    }
}