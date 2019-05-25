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
    public partial class Zapyt_Zamov_Grafik : Form
    {
        public Zapyt_Zamov_Grafik()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.запит_замовник___ГрафікTableAdapter.Fill(this.big_16_04DataSet._Запит_замовник___Графік, typeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void TypeToolStripLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
