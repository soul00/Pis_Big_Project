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
    public partial class Torg_Predst : Form
    {
        public Torg_Predst()
        {
            InitializeComponent();
        }

        private void Торговий_представникBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.торговий_представникBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Torg_Predst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Торговий_представник". При необходимости она может быть перемещена или удалена.
            this.торговий_представникTableAdapter.Fill(this.big_16_04DataSet.Торговий_представник);

        }
    }
}
