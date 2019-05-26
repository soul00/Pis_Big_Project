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
    public partial class Zvit_Torg_Predst : Form
    {
        public Zvit_Torg_Predst()
        {
            InitializeComponent();
        }

        private void Zvit_Torg_Predst_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Торговий_представник". При необходимости она может быть перемещена или удалена.
            this.торговий_представникTableAdapter.Fill(this.big_16_04DataSet.Торговий_представник);

            this.reportViewer1.RefreshReport();
        }
    }
}
