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
    public partial class Grafik : Form
    {
        public Grafik()
        {
            InitializeComponent();
        }

        private void ГрафікBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.графікBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.big_16_04DataSet);

        }

        private void Grafik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Замовник". При необходимости она может быть перемещена или удалена.
            this.замовникTableAdapter.Fill(this.big_16_04DataSet.Замовник);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Постійний_графік". При необходимости она может быть перемещена или удалена.
            this.постійний_графікTableAdapter.Fill(this.big_16_04DataSet.Постійний_графік);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Одноразовий_графік". При необходимости она может быть перемещена или удалена.
            this.одноразовий_графікTableAdapter.Fill(this.big_16_04DataSet.Одноразовий_графік);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Графік". При необходимости она может быть перемещена или удалена.
            this.графікTableAdapter.Fill(this.big_16_04DataSet.Графік);

        }
    }
}
