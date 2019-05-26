using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project.Звіти
{
    public partial class Zvit_zamovn : Form
    {
        public Zvit_zamovn()
        {
            InitializeComponent();
        }

        private void Zvit_zamovn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовник". При необходимости она может быть перемещена или удалена.
            this.замовникTableAdapter.Fill(this.big_16_04DataSet.Замовник);

            this.reportViewer1.RefreshReport();
        }
    }
}
