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
    public partial class Waffles : Form
    {
        public Waffles()
        {
            InitializeComponent();
        }

        private void ВафліBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вафліBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Waffles_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Вафлі". При необходимости она может быть перемещена или удалена.
            this.вафліTableAdapter.Fill(this.big_16_04DataSet.Вафлі);

        }
    }
}
