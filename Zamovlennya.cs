﻿using System;
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
    public partial class Zamovlennya : Form
    {
        public Zamovlennya()
        {
            InitializeComponent();
        }

        private void Zamovlennya_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Зведені_Замовлення". При необходимости она может быть перемещена или удалена.
            this.зведені_ЗамовленняTableAdapter.Fill(this.big_16_04DataSet.Зведені_Замовлення);

        }
    }
}
