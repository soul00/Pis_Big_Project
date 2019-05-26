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
    public partial class Zvit_document : Form
    {
        public Zvit_document()
        {
            InitializeComponent();
        }

        private void Zvit_document_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "big_16_04DataSet.Документ_Замовник". При необходимости она может быть перемещена или удалена.
            this.документ_ЗамовникTableAdapter.Fill(this.big_16_04DataSet.Документ_Замовник);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
