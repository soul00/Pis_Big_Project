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
    public partial class Torgov_Document : Form
    {
        public Torgov_Document()
        {
            InitializeComponent();
        }

        private void Torgov_Document_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Документ". При необходимости она может быть перемещена или удалена.
            this.документTableAdapter.Fill(this.big_16_04DataSet.Документ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet._Торговий___документ". При необходимости она может быть перемещена или удалена.
            this.торговий___документTableAdapter.Fill(this.big_16_04DataSet._Торговий___документ);

        }
    }
}
