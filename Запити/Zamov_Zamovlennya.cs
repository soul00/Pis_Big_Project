using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project.Запити
{
    public partial class Zamov_Zamovlennya : Form
    {
        public Zamov_Zamovlennya()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.замовл_ЗамовнTableAdapter.Fill(this.big_16_04DataSet.Замовл_Замовн, nameZamovToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FillToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.замовл_ЗамовнTableAdapter.Fill(this.big_16_04DataSet.Замовл_Замовн, nameZamovToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
