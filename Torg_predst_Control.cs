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
    public partial class Torg_predst_Control : UserControl
    {
        public Torg_predst_Control()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Torg_Predst().ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Torgov_Document().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Запити.Torgoviy_Zamovnik().ShowDialog();
        }
    }
}
