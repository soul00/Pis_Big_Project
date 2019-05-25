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
    public partial class Document_Control : UserControl
    {
        public Document_Control()
        {
            InitializeComponent();
        }

        private void Document_Control_Load(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            new Document().ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            new Nakladni().ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            new Zamovlennya().ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new Rahunki().ShowDialog();
        }
    }
}