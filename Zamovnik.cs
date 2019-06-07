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
    public partial class Zamovnik : Form
    {
        public Zamovnik()
        {
            InitializeComponent();
        }

        private void ЗамовникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.замовникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void ЗамовникBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.замовникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Zamovnik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Графік". При необходимости она может быть перемещена или удалена.
            this.графікTableAdapter.Fill(this.big_16_04DataSet.Графік);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовник". При необходимости она может быть перемещена или удалена.
            this.замовникTableAdapter.Fill(this.big_16_04DataSet.Замовник);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int itemFound = this.замовникBindingSource.Find("Телефон", textBox1.Text);
            this.замовникBindingSource.Position = itemFound;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Grafik().ShowDialog();
        }
    }
}
