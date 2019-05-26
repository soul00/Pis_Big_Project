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
    public partial class Zamovlen_Zamovn : Form
    {
        public Zamovlen_Zamovn()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.замовлення_ЗамовникаTableAdapter.Fill(this.big_16_04DataSet.Замовлення_Замовника, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
