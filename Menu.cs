using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            main_Menu_Control1.BringToFront();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            document_Control1.BringToFront();            
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
        }
        private void Button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
        }
        private void Button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Document_Control1_Load(object sender, EventArgs e)
        {

        }
    }
}
