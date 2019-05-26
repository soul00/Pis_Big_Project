using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project.Запити
{
    public partial class Zamovlen_Zamovn : Form
    {
        public Zamovlen_Zamovn()
        {
            InitializeComponent();
        }

        private void Zamovlen_Zamovn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet._Замовник___документ". При необходимости она может быть перемещена или удалена.
            this.замовник___документTableAdapter.Fill(this.big_16_04DataSet._Замовник___документ);

        }
    }
}
