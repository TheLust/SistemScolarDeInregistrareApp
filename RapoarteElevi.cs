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
    public partial class RapoarteElevi : Form
    {
        public RapoarteElevi()
        {
            InitializeComponent();
        }

        private void RapoarteElevi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SistemScolarDataSet1.rapElevi' table. You can move, or remove it, as needed.
            this.rapEleviTableAdapter.Fill(this.SistemScolarDataSet1.rapElevi);

            this.reportViewer1.RefreshReport();
        }
    }
}
