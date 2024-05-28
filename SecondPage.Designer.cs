namespace pratica
{
    partial class SecondPage
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
            this.cb_option1 = new System.Windows.Forms.CheckBox();
            this.cb_option2 = new System.Windows.Forms.CheckBox();
            this.cb_option3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_option1
            // 
            this.cb_option1.AutoSize = true;
            this.cb_option1.Location = new System.Drawing.Point(13, 13);
            this.cb_option1.Name = "cb_option1";
            this.cb_option1.Size = new System.Drawing.Size(67, 17);
            this.cb_option1.TabIndex = 0;
            this.cb_option1.Text = "Opção 1";
            this.cb_option1.UseVisualStyleBackColor = true;
            this.cb_option1.CheckedChanged += new System.EventHandler(this.cb_option1_CheckedChanged);
            // 
            // cb_option2
            // 
            this.cb_option2.AutoSize = true;
            this.cb_option2.Location = new System.Drawing.Point(13, 37);
            this.cb_option2.Name = "cb_option2";
            this.cb_option2.Size = new System.Drawing.Size(67, 17);
            this.cb_option2.TabIndex = 1;
            this.cb_option2.Text = "Opção 2";
            this.cb_option2.UseVisualStyleBackColor = true;
            // 
            // cb_option3
            // 
            this.cb_option3.AutoSize = true;
            this.cb_option3.Location = new System.Drawing.Point(13, 61);
            this.cb_option3.Name = "cb_option3";
            this.cb_option3.Size = new System.Drawing.Size(67, 17);
            this.cb_option3.TabIndex = 2;
            this.cb_option3.Text = "Opção 3";
            this.cb_option3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verificar\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Acessar Filho\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_option3);
            this.Controls.Add(this.cb_option2);
            this.Controls.Add(this.cb_option1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SecondPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecondPage";
            this.Load += new System.EventHandler(this.SecondPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox cb_option1;
        public System.Windows.Forms.CheckBox cb_option2;
        public System.Windows.Forms.CheckBox cb_option3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}