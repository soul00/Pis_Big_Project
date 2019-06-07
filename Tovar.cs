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
    public partial class Tovar : Form
    {
        public Tovar()
        {
            InitializeComponent();
        }

        private void ТоварBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Tovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.товарBindingSource.Filter = "(Виробник_товару='Рошен')";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.товарBindingSource.Filter = "(Виробник_товару='Мрія')";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            товарBindingSource.RemoveFilter();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
