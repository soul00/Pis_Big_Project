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
    public partial class Baton : Form
    {
        public Baton()
        {
            InitializeComponent();
        }

        private void БатончикBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.батончикBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Baton_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Батончик". При необходимости она может быть перемещена или удалена.
            this.батончикTableAdapter.Fill(this.big_16_04DataSet.Батончик);

        }
    }
}
