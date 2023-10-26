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
    public partial class RapoarteProfesori : Form
    {
        public RapoarteProfesori()
        {
            InitializeComponent();
        }

        private void RapoarteProfesori_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'SistemScolarDataSet.Profesori' table. You can move, or remove it, as needed.
            this.ProfesoriTableAdapter.Fill(this.SistemScolarDataSet.Profesori);

            this.reportViewer1.RefreshReport();

        }
    }
}
