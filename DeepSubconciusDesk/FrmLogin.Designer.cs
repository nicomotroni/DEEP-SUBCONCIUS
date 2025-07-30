namespace DeepSubconciusDesk
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            btnFechar = new Button();
            txtEmail = new TextBox();
            picLogo = new PictureBox();
            picLogin = new PictureBox();
            lblLogin = new Label();
            txtSenha = new TextBox();
            btnEntrar = new Button();
            llblResetarSenha = new LinkLabel();
            btnCadastro = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFechar.BackColor = Color.Transparent;
            btnFechar.BackgroundImageLayout = ImageLayout.None;
            btnFechar.ForeColor = Color.FromArgb(97, 65, 172);
            btnFechar.Location = new Point(506, 20);
            btnFechar.Margin = new Padding(0);
            btnFechar.Name = "btnFechar";
            btnFechar.Padding = new Padding(1, 0, 0, 0);
            btnFechar.Size = new Size(24, 24);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(97, 65, 172);
            txtEmail.Location = new Point(65, 173);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail";
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.Size = new Size(400, 36);
            txtEmail.TabIndex = 1;
            txtEmail.Tag = "1";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(12, 0);
            picLogo.Name = "picLogo";
            picLogo.Padding = new Padding(2);
            picLogo.Size = new Size(128, 128);
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // picLogin
            // 
            picLogin.BackColor = Color.Transparent;
            picLogin.BackgroundImageLayout = ImageLayout.Center;
            picLogin.Image = (Image)resources.GetObject("picLogin.Image");
            picLogin.Location = new Point(245, 102);
            picLogin.Margin = new Padding(0);
            picLogin.Name = "picLogin";
            picLogin.Size = new Size(64, 64);
            picLogin.TabIndex = 3;
            picLogin.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Segoe UI Variable Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.FromArgb(97, 65, 172);
            lblLogin.Location = new Point(232, 47);
            lblLogin.Margin = new Padding(0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(95, 38);
            lblLogin.TabIndex = 4;
            lblLogin.Text = "Login";
            lblLogin.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtSenha
            // 
            txtSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.ForeColor = Color.FromArgb(97, 65, 172);
            txtSenha.Location = new Point(65, 235);
            txtSenha.Margin = new Padding(2);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.Size = new Size(400, 36);
            txtSenha.TabIndex = 1;
            txtSenha.Tag = "2";
            txtSenha.UseSystemPasswordChar = true;
            // 
            // btnEntrar
            // 
            btnEntrar.AccessibleRole = AccessibleRole.None;
            btnEntrar.Anchor = AnchorStyles.Left;
            btnEntrar.BackColor = Color.FromArgb(97, 65, 172);
            btnEntrar.BackgroundImageLayout = ImageLayout.None;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.ForeColor = Color.White;
            btnEntrar.Location = new Point(168, 294);
            btnEntrar.Margin = new Padding(2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(225, 44);
            btnEntrar.TabIndex = 5;
            btnEntrar.Tag = "3";
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // llblResetarSenha
            // 
            llblResetarSenha.AutoSize = true;
            llblResetarSenha.DisabledLinkColor = Color.FromArgb(97, 65, 172);
            llblResetarSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llblResetarSenha.LinkBehavior = LinkBehavior.NeverUnderline;
            llblResetarSenha.LinkColor = Color.FromArgb(97, 65, 172);
            llblResetarSenha.Location = new Point(208, 409);
            llblResetarSenha.Name = "llblResetarSenha";
            llblResetarSenha.Size = new Size(168, 21);
            llblResetarSenha.TabIndex = 6;
            llblResetarSenha.TabStop = true;
            llblResetarSenha.Text = "Esqueceu sua senha?";
            llblResetarSenha.LinkClicked += llblResetarSenha_LinkClicked;
            // 
            // btnCadastro
            // 
            btnCadastro.AccessibleRole = AccessibleRole.None;
            btnCadastro.Anchor = AnchorStyles.Left;
            btnCadastro.BackColor = Color.FromArgb(97, 65, 172);
            btnCadastro.BackgroundImageLayout = ImageLayout.None;
            btnCadastro.FlatAppearance.BorderSize = 0;
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(220, 363);
            btnCadastro.Margin = new Padding(2);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(124, 37);
            btnCadastro.TabIndex = 7;
            btnCadastro.Tag = "3";
            btnCadastro.Text = "Registrar-se";
            btnCadastro.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(97, 64, 172);
            label1.Location = new Point(262, 337);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "________";
            // 
            // FrmLogin
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(177, 161, 237);
            CancelButton = btnFechar;
            ClientSize = new Size(550, 450);
            ControlBox = false;
            Controls.Add(btnCadastro);
            Controls.Add(llblResetarSenha);
            Controls.Add(btnEntrar);
            Controls.Add(picLogin);
            Controls.Add(lblLogin);
            Controls.Add(picLogo);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(btnFechar);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtEmail;
        private PictureBox picLogo;
        private PictureBox picLogin;
        private Label lblLogin;
        private TextBox txtSenha;
        private Button btnEntrar;
        private LinkLabel llblResetarSenha;
        private Button btnCadastro;
        private Label label1;
    }
}