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
    public partial class Candies : Form
    {
        public Candies()
        {
            InitializeComponent();
        }

        private void ЦукеркиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.цукеркиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Candies_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Цукерки". При необходимости она может быть перемещена или удалена.
            this.цукеркиTableAdapter.Fill(this.big_16_04DataSet.Цукерки);

        }
    }
}
