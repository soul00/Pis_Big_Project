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
        }

        private void ДокументиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Document().ShowDialog();
        }

        private void ЗамовникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zamovnik().ShowDialog();
        }

        private void ТорговіПредставникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Torg_Predst().ShowDialog();
        }

        private void ТовариToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Tovar().ShowDialog();
        }

        private void НакладніToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Nakladni().ShowDialog();
        }

        private void ГрафікиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Grafik().ShowDialog();
        }

        private void ПошукЗамовникаЗаТипомГрафікуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zapyt_Zamov_Grafik().ShowDialog();
        }

        private void ЗапитЗамовникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zamov_Document().ShowDialog();
        }

        private void ЗамовникиЗЗапитомВід200ТисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zamovn_vid_200_tis().ShowDialog();
        }

        private void ТорговіПредставникиТаЇхЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Torgov_Document().ShowDialog();
        }

        private void ЗамовленняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zamovlennya().ShowDialog();
        }

        private void РахункифактуриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Rahunki().ShowDialog();
        }

        private void ПошукДокументівЗаДатоюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Zapyt_Data_Poshuk().ShowDialog();
        }

        private void ZvitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }
    }
}
