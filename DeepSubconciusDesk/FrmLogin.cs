using DeepSubconciusClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeepSubconciusDesk
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Program.UsuarioLogado = Usuario.EfetuarLogin(txtEmail.Text, txtSenha.Text);
            this.Close();
        }

        private void llblResetarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
