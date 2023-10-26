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
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private Utilizator obUtilizator;

        public Login()
        {
            InitializeComponent();
        }


        private void DataUtilizator()
        {
            obUtilizator.NumeUtilizator = txtLoginUtilizator.Text;
            obUtilizator.Parola = txtLoginParola.Text;
        }

        private void ClearControls()
        {
            txtLoginUtilizator.Clear();
            txtLoginParola.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            obUtilizator = new Utilizator();

            DataUtilizator();

            try
            {
                if (obUtilizator.AutorizareUtilizator())
                {
                    FrmSistemScolarInregistrare objSchoolRegistration = new FrmSistemScolarInregistrare();
                    this.Hide();
                    objSchoolRegistration.Show();
                    objSchoolRegistration.btnAdmin.Enabled = false;
                }
                else if (obUtilizator.AutorizareAdmin())
                {
                    FrmSistemScolarInregistrare objSchoolRegistration = new FrmSistemScolarInregistrare();
                    this.Hide();
                    objSchoolRegistration.Show();
                    objSchoolRegistration.btnAdmin.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Utilizator/Parola neautorizata!!", "Utilizator/Administrator neautorizat",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkArataParola_CheckedChanged(object sender, EventArgs e)
        {
            if (chkArataParola.Checked)
            {
                txtLoginParola.UseSystemPasswordChar = false;
            }
            else
            {
                txtLoginParola.UseSystemPasswordChar = true;
            }
        }
    }
}
