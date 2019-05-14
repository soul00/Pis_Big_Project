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
    public partial class Zamov_Document : Form
    {
        public Zamov_Document()
        {
            InitializeComponent();
        }

        private void Zamov_Document_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet._Замовник___документ". При необходимости она может быть перемещена или удалена.
            this.замовник___документTableAdapter.Fill(this.big_16_04DataSet._Замовник___документ);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           this.замовник___документBindingSource.Filter = "(Вид_документу='" + comboBox1.Text +"')";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.замовник___документBindingSource.RemoveFilter();
        }
    }
}
