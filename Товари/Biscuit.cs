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
    public partial class Biscuit : Form
    {
        public Biscuit()
        {
            InitializeComponent();
        }

        private void БісквітиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.бісквітиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Biscuit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Бісквіти". При необходимости она может быть перемещена или удалена.
            this.бісквітиTableAdapter.Fill(this.big_16_04DataSet.Бісквіти);

        }
    }
}
