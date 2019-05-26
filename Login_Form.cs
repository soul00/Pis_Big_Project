using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pis_Big_Project
{
    public partial class Login_Form : Form
    {
        static int attempt = 3;

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = new Bitmap(@"D:\Education\Универ\4 курс\2019\ПІС\Pis_Project_\Pis_Big_Project\another icons\Menu images\Access.png");
            new Menu().ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
