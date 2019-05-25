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
    public partial class Chocolate : Form
    {
        public Chocolate()
        {
            InitializeComponent();
        }

        private void ШоколадBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.шоколадBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Chocolate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Шоколад". При необходимости она может быть перемещена или удалена.
            this.шоколадTableAdapter.Fill(this.big_16_04DataSet.Шоколад);

        }
    }
}
