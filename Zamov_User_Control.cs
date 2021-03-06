﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pis_Big_Project
{
    public partial class Zamov_User_Control : UserControl
    {
        public Zamov_User_Control()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Zamovnik().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Grafik().ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Zamovlen_Zamovn().ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            new Zapyt_Zamov_Grafik().ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Запити.Zamov_Zamovlennya().ShowDialog();
        }
    }
}
