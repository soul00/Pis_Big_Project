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
    public partial class Zvit_Tovary : Form
    {
        public Zvit_Tovary()
        {
            InitializeComponent();
        }

        private void Zvit_Tovary_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.big_16_04DataSet.Товар);

            this.reportViewer1.RefreshReport();
        }
    }
}
