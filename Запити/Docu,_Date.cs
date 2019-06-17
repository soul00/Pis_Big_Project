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
    public partial class Docu__Date : Form
    {
        public Docu__Date()
        {
            InitializeComponent();
        }

        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.дата_ДокументTableAdapter.Fill(this.big_16_04DataSet.Дата_Документ, new System.Nullable<System.DateTime>(((System.DateTime)(System.Convert.ChangeType(dateVidvToolStripTextBox.Text, typeof(System.DateTime))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
