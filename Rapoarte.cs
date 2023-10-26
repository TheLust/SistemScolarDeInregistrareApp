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
    public partial class Rapoarte : Form
    {
        public Rapoarte()
        {
            InitializeComponent();
        }

        RapoarteProfesori objRapoarteProfesori = null;

        private void profesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objRapoarteProfesori == null)
            {
                objRapoarteProfesori = new RapoarteProfesori();
                objRapoarteProfesori.MdiParent = this;
                objRapoarteProfesori.FormClosed += ObjRapoarteProfesori_FormClosed;
                objRapoarteProfesori.Show();
            }
            else
            {
                objRapoarteProfesori.Activate();
            }

        }

        private void ObjRapoarteProfesori_FormClosed(object sender, FormClosedEventArgs e)
        {
            objRapoarteProfesori = null;
        }

        RapoarteElevi objRapoarteElevi = null;
        private void eleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objRapoarteElevi == null)
            {
                objRapoarteElevi = new RapoarteElevi();
                objRapoarteElevi.MdiParent = this;
                objRapoarteElevi.FormClosed += ObjRapoarteElevi_FormClosed;
                objRapoarteElevi.Show();
            }
            else
            {
                objRapoarteElevi.Activate();
            }

        }

        private void ObjRapoarteElevi_FormClosed(object sender, FormClosedEventArgs e)
        {
            objRapoarteElevi = null;
        }

        rapTaxa objRapoarteTaxa = null;
        private void taxaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objRapoarteTaxa == null)
            {
                objRapoarteTaxa = new rapTaxa();
                objRapoarteTaxa.MdiParent = this;
                objRapoarteTaxa.FormClosed += ObjRapoarteTaxa_FormClosed;
                objRapoarteTaxa.Show();
            }

        }
        private void ObjRapoarteTaxa_FormClosed(object sender, FormClosedEventArgs e)
        {
            objRapoarteTaxa = null;
        }

        private void dateProfesoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAfisareDateProfesori objDateProfesori = new FrmAfisareDateProfesori();
            objDateProfesori.Show();
            Hide();
        }

        private void dateEleviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAfisareDateElevi objDateElevi = new FrmAfisareDateElevi();
            objDateElevi.Show();
            Hide();
        }

        private void dateTaxaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAfisareDateTaxa objDateTaxa = new FrmAfisareDateTaxa();
            objDateTaxa.Show();
            Hide();
        }

        private void orizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void inchideToateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form toateFormularele in this.MdiChildren)
            {
                toateFormularele.Close();
            } 
        }
    }
}
