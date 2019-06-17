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
    public partial class Nakladna2 : Form
    {
        public Nakladna2()
        {
            InitializeComponent();
        }

        private void ТоварBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.товарBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Nakladna2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Накладна_відправлення". При необходимости она может быть перемещена или удалена.
            this.накладна_відправленняTableAdapter.Fill(this.big_16_04DataSet.Накладна_відправлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Накладна_відправлення". При необходимости она может быть перемещена или удалена.
            this.накладна_відправленняTableAdapter.Fill(this.big_16_04DataSet.Накладна_відправлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);

        }

        private void Код_НакладноїTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Код_НакладноїLabel_Click(object sender, EventArgs e)
        {

        }

        private void Код_документуLabel_Click(object sender, EventArgs e)
        {

        }

        private void Код_документуTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Накладна_відправленняBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.накладна_відправленняBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void ПечатьToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
