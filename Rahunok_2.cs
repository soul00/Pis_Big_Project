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
    public partial class Rahunok_2 : Form
    {
        public Rahunok_2()
        {
            InitializeComponent();
        }

        private void Рахунок_фактураBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рахунок_фактураBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Rahunok_2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Рахунок_фактура". При необходимости она может быть перемещена или удалена.
            this.рахунок_фактураTableAdapter.Fill(this.big_16_04DataSet.Рахунок_фактура);

        }

        private void Код_рахункуTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Код_рахункуLabel_Click(object sender, EventArgs e)
        {

        }

        private void Код_документуLabel_Click(object sender, EventArgs e)
        {

        }

        private void Код_документуTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Сумарна_вартістьLabel_Click(object sender, EventArgs e)
        {

        }

        private void Сумарна_вартістьTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Термін_Дії_доLabel_Click(object sender, EventArgs e)
        {

        }

        private void Термін_Дії_доDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ПідставаLabel_Click(object sender, EventArgs e)
        {

        }

        private void ПідставаTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
