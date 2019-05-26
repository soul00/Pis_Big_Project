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
    public partial class Zvit_User_Control : UserControl
    {
        public Zvit_User_Control()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Звіти.Zvit_document().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Запити.Zvit_vid_sum().ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Звіти.Zvit_zamovn().ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Звіти.Zvit_Torg_Predst().ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Звіти.Zvit_Tovary().ShowDialog();

        }
    }
}
