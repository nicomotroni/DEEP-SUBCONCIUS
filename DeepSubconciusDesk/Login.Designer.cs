namespace DeepSubconciusDesk
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Design_sem_nome__11_;
            pictureBox1.Location = new Point(246, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(459, 357);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(177, 161, 237);
            label1.Font = new Font("Candara", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(97, 65, 172);
            label1.Location = new Point(419, 85);
            label1.Name = "label1";
            label1.Size = new Size(102, 42);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.FromArgb(97, 65, 172);
            textBox1.Location = new Point(326, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 33);
            textBox1.TabIndex = 2;
            textBox1.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.FromArgb(97, 65, 172);
            textBox2.Location = new Point(326, 277);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 33);
            textBox2.TabIndex = 5;
            textBox2.Text = "Senha";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = Color.FromArgb(97, 65, 172);
            textBox3.Location = new Point(326, 350);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 33);
            textBox3.TabIndex = 6;
            textBox3.Text = " Psicólogo/Paciente";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(177, 161, 237);
            pictureBox2.Image = Properties.Resources.Design_sem_nome__12_1;
            pictureBox2.Location = new Point(441, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Design_sem_nome__13_;
            pictureBox3.Location = new Point(30, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(126, 111);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 506);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}