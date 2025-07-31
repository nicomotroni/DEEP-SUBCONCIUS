namespace DeepSubconciusDesk
{
    partial class FrmCadastrar
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(177, 161, 237);
            label1.Font = new Font("Candara", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(97, 65, 172);
            label1.Location = new Point(316, 38);
            label1.Name = "label1";
            label1.Size = new Size(158, 36);
            label1.TabIndex = 2;
            label1.Text = "Cadastre-se";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(97, 65, 172);
            textBox1.Location = new Point(49, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Nome";
            // 
            // textBox2
            // 
            textBox2.ForeColor = Color.FromArgb(97, 65, 172);
            textBox2.Location = new Point(437, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(310, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "CPF";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.FromArgb(97, 65, 172);
            textBox3.Location = new Point(437, 116);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(310, 23);
            textBox3.TabIndex = 5;
            textBox3.Text = "RG";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.FromArgb(97, 65, 172);
            textBox4.Location = new Point(49, 339);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(310, 23);
            textBox4.TabIndex = 6;
            textBox4.Text = "Endereço";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.FromArgb(97, 65, 172);
            textBox5.Location = new Point(49, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 23);
            textBox5.TabIndex = 7;
            textBox5.Text = "Telefone";
            // 
            // textBox6
            // 
            textBox6.ForeColor = Color.FromArgb(97, 65, 172);
            textBox6.Location = new Point(49, 190);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 23);
            textBox6.TabIndex = 8;
            textBox6.Text = "Email";
            // 
            // textBox7
            // 
            textBox7.ForeColor = Color.FromArgb(97, 65, 172);
            textBox7.Location = new Point(437, 256);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(310, 23);
            textBox7.TabIndex = 9;
            textBox7.Text = "CRM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Design_sem_nome__15_;
            pictureBox1.Location = new Point(626, 311);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 141);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = Properties.Resources.Design_sem_nome__16_;
            pictureBox2.Location = new Point(679, 344);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 99);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // FrmCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(177, 161, 237);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FrmCadastrar";
            Text = "FrmCadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}