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
    public partial class Zapyt_Data_Poshuk : Form
    {
        public Zapyt_Data_Poshuk()
        {
            InitializeComponent();
        }

        private void Zapyt_Data_Poshuk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet._Замовник___документ". При необходимости она может быть перемещена или удалена.
            this.замовник___документTableAdapter.Fill(this.big_16_04DataSet._Замовник___документ);

        }

    }
}
