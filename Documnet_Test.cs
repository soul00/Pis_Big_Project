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
    public partial class Documnet_Test : Form
    {
        public Documnet_Test()
        {
            InitializeComponent();
        }

        private void ДокументBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.документBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Documnet_Test_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Торговий_представник". При необходимости она может быть перемещена или удалена.
            this.торговий_представникTableAdapter.Fill(this.big_16_04DataSet.Торговий_представник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовник". При необходимости она может быть перемещена или удалена.
            this.замовникTableAdapter.Fill(this.big_16_04DataSet.Замовник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Рядок_замовлення". При необходимости она может быть перемещена или удалена.
            this.рядок_замовленняTableAdapter.Fill(this.big_16_04DataSet.Рядок_замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Рахунок_фактура". При необходимости она может быть перемещена или удалена.
            this.рахунок_фактураTableAdapter.Fill(this.big_16_04DataSet.Рахунок_фактура);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Накладна_відправлення". При необходимости она может быть перемещена или удалена.
            this.накладна_відправленняTableAdapter.Fill(this.big_16_04DataSet.Накладна_відправлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовлення". При необходимости она может быть перемещена или удалена.
            this.замовленняTableAdapter.Fill(this.big_16_04DataSet.Замовлення);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.big_16_04DataSet.Документ);

        }
    }
}
