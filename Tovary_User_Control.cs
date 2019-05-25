using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project
{
    public partial class Tovary_User_Control : UserControl
    {
        public Tovary_User_Control()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Tovar().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Chocolate().ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            new Candies().ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Cookies().ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            new Biscuit().ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Waffles().ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Baton().ShowDialog();
        }
    }
}
