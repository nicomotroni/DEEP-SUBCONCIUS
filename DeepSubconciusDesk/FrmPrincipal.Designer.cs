namespace DeepSubconciusDesk
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            button7 = new Button();
            button8 = new Button();
            button10 = new Button();
            button9 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(2288, 122);
            panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(238, 238, 238);
            pictureBox2.Image = Properties.Resources.Logo_subconcius;
            pictureBox2.Location = new Point(0, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(121, 99);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 238, 238);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(1, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 1023);
            panel2.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Location = new Point(0, 104);
            button1.Name = "button1";
            button1.Size = new Size(171, 56);
            button1.TabIndex = 0;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(238, 238, 238);
            button5.Location = new Point(0, 318);
            button5.Name = "button5";
            button5.Size = new Size(165, 56);
            button5.TabIndex = 33;
            button5.Text = "PERFIL";
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(238, 238, 238);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(-9, 211);
            button2.Name = "button2";
            button2.Size = new Size(174, 56);
            button2.TabIndex = 30;
            button2.Text = "RELATÓRIOS DE CLIENTES";
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(238, 238, 238);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(0, 265);
            button4.Name = "button4";
            button4.Size = new Size(165, 58);
            button4.TabIndex = 32;
            button4.Text = "ATIVIDADES SOLICITADAS";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(238, 238, 238);
            button3.Location = new Point(-9, 157);
            button3.Name = "button3";
            button3.Size = new Size(174, 56);
            button3.TabIndex = 31;
            button3.Text = "CADASTRAR";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Location = new Point(409, 210);
            button7.Name = "button7";
            button7.Size = new Size(282, 173);
            button7.TabIndex = 24;
            button7.Text = "Histórico de sessões dos clientes ";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.LightGray;
            button8.Location = new Point(743, 205);
            button8.Name = "button8";
            button8.Size = new Size(282, 173);
            button8.TabIndex = 27;
            button8.Text = "Registro diários dos clientes";
            button8.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.LightGray;
            button10.Location = new Point(409, 404);
            button10.Name = "button10";
            button10.Size = new Size(282, 173);
            button10.TabIndex = 28;
            button10.Text = "Agendamentos do dia";
            button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.LightGray;
            button9.Location = new Point(743, 404);
            button9.Name = "button9";
            button9.Size = new Size(282, 173);
            button9.TabIndex = 29;
            button9.Text = "Atividades dos clientes";
            button9.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1725, 894);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmPrincipal";
            Text = "FrmInicio";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button button1;
        private Button button7;
        private Button button8;
        private Button button10;
        private Button button9;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
    }


}

