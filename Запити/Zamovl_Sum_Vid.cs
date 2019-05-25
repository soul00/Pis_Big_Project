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
    public partial class Zamovl_Sum_Vid : Form
    {
        public Zamovl_Sum_Vid()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.замовлення_відTableAdapter.Fill(this.big_16_04DataSet.Замовлення_від, new System.Nullable<int>(((int)(System.Convert.ChangeType(sumToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
