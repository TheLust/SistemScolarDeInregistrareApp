using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolarDeInregistrareApp
{
    public partial class rapTaxa : Form
    {
        public rapTaxa()
        {
            InitializeComponent();
        }

        private void rapTaxa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SistemScolarDataSet3.rapTaxa' table. You can move, or remove it, as needed.
            this.rapTaxaTableAdapter.Fill(this.SistemScolarDataSet3.rapTaxa);

            this.reportViewer1.RefreshReport();
        }
    }
}
