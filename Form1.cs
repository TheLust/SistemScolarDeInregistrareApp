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
    public partial class FrmSistemScolarInregistrare : MaterialSkin.Controls.MaterialForm
    {
        public FrmSistemScolarInregistrare()
        {
         
            InitializeComponent();
        }

        private void btnElevi_Click(object sender, EventArgs e)
        {
            FrmElevi elevi = new FrmElevi();

            elevi.Show();
        }

        private void btnProfesori_Click(object sender, EventArgs e)
        {
            FrmProfesori pr = new FrmProfesori();
            pr.Show();  
        }

        private void btnTaxa_Click(object sender, EventArgs e)
        {
            FrmTaxa taxa = new FrmTaxa();
            taxa.Show();
        }

        private void btnRapoarte_Click(object sender, EventArgs e)
        {
            Rapoarte objRapoarte = new Rapoarte();
            objRapoarte.Visible = true;

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            InregistrareUtilizatori objInregUtilizatori = new InregistrareUtilizatori();
            objInregUtilizatori.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login obLogin = new Login();
            obLogin.Show();
        }
    }
}
