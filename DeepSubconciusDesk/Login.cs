using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace DeepSubconciusDesk
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }
        void ArredondarControle(Control c, int raio)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(c.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(c.Width - raio, c.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, c.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            c.Region = new Region(path);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
