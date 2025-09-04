namespace DeepSubconciusDesk
{
    partial class frmCadastroDeClientes
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
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox7
            // 
            textBox7.ForeColor = Color.FromArgb(97, 65, 172);
            textBox7.Location = new Point(448, 225);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(310, 101);
            textBox7.TabIndex = 19;
            textBox7.Text = "O QUE TE INCENTIVOU BUSCAR TERAPIA?";
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.FromArgb(97, 65, 172);
            textBox6.Location = new Point(72, 187);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 23);
            textBox6.TabIndex = 18;
            textBox6.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.FromArgb(97, 65, 172);
            textBox5.Location = new Point(72, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 23);
            textBox5.TabIndex = 17;
            textBox5.Text = "Telefone";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.FromArgb(97, 65, 172);
            textBox4.Location = new Point(72, 316);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 23);
            textBox4.TabIndex = 16;
            textBox4.Text = "Endereço";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(97, 65, 172);
            textBox3.Location = new Point(448, 135);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 23);
            textBox3.TabIndex = 15;
            textBox3.Text = "RG";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(97, 65, 172);
            textBox2.Location = new Point(448, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 14;
            textBox2.Text = "CPF";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(97, 65, 172);
            textBox1.Location = new Point(72, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 13;
            textBox1.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(177, 161, 237);
            label1.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(97, 65, 172);
            label1.Location = new Point(337, 56);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 12;
            label1.Text = "Cadastre-se";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Logo_subconcius;
            pictureBox2.Location = new Point(709, 359);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 99);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Design_sem_nome__15_;
            pictureBox3.Location = new Point(654, 332);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(176, 137);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // frmCadastroDeClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(177, 161, 237);
            ClientSize = new Size(830, 470);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmCadastroDeClientes";
            Text = "FrmCadastrarCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}