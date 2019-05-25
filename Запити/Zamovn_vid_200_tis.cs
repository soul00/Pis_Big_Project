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
    public partial class Zamovn_vid_200_tis : Form
    {
        public Zamovn_vid_200_tis()
        {
            InitializeComponent();
        }

        private void Zamovn_vid_200_tis_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовлення_від_200_тис". При необходимости она может быть перемещена или удалена.
            this.замовлення_від_200_тисTableAdapter.Fill(this.big_16_04DataSet.Замовлення_від_200_тис);

        }
    }
}
