namespace pratica
{
    partial class SecondFilho
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
            this.cb_option3 = new System.Windows.Forms.CheckBox();
            this.cb_option2 = new System.Windows.Forms.CheckBox();
            this.cb_option1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_option3
            // 
            this.cb_option3.AutoSize = true;
            this.cb_option3.Location = new System.Drawing.Point(12, 60);
            this.cb_option3.Name = "cb_option3";
            this.cb_option3.Size = new System.Drawing.Size(67, 17);
            this.cb_option3.TabIndex = 5;
            this.cb_option3.Text = "Opção 3";
            this.cb_option3.UseVisualStyleBackColor = true;
            this.cb_option3.CheckedChanged += new System.EventHandler(this.cb_option3_CheckedChanged);
            // 
            // cb_option2
            // 
            this.cb_option2.AutoSize = true;
            this.cb_option2.Location = new System.Drawing.Point(12, 36);
            this.cb_option2.Name = "cb_option2";
            this.cb_option2.Size = new System.Drawing.Size(67, 17);
            this.cb_option2.TabIndex = 4;
            this.cb_option2.Text = "Opção 2";
            this.cb_option2.UseVisualStyleBackColor = true;
            this.cb_option2.CheckedChanged += new System.EventHandler(this.cb_option2_CheckedChanged);
            // 
            // cb_option1
            // 
            this.cb_option1.AutoSize = true;
            this.cb_option1.Location = new System.Drawing.Point(12, 12);
            this.cb_option1.Name = "cb_option1";
            this.cb_option1.Size = new System.Drawing.Size(67, 17);
            this.cb_option1.TabIndex = 3;
            this.cb_option1.Text = "Opção 1";
            this.cb_option1.UseVisualStyleBackColor = true;
            this.cb_option1.CheckedChanged += new System.EventHandler(this.cb_option1_CheckedChanged);
            // 
            // SecondFilho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_option3);
            this.Controls.Add(this.cb_option2);
            this.Controls.Add(this.cb_option1);
            this.Name = "SecondFilho";
            this.Text = "SecondFilho";
            this.Load += new System.EventHandler(this.SecondFilho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cb_option3;
        public System.Windows.Forms.CheckBox cb_option2;
        public System.Windows.Forms.CheckBox cb_option1;
    }
}