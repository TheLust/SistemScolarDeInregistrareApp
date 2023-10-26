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
    public partial class InregistrareUtilizatori : MaterialSkin.Controls.MaterialForm
    {
        //Variabila Class
        private Utilizator objUtilizator;
        private static int UtilizatorID;

        public InregistrareUtilizatori()
        {
            InitializeComponent();
        }

        private bool ValidareDateIntrare()
        {
            const int lungimeMinimaParola = 8;

            //Validare Utilizator
            if (txtNumeUtilizator.Text.Length == 0)
            {
                MessageBox.Show("Te rugam, Introduce Numele Utilizatorului."
                    , "Eroare Date de Intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNumeUtilizator.Focus();

                return false;
            }

            //Parola trebuie sa contina minimum 8 caractere
            //Parola trebuie sa contin cel putin o litera mare
            //Parola trebuie sa contin cel putin o litera mica
            //Parola trebuie sa contin cel putin un numar

            //Validare Parola
            if (txtParola.Text.Length == 0)
            {
                MessageBox.Show("Te rugam, Introduce Parola."
                    , "Eroare Date de Intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtParola.Focus();

                return false;
            }
            else
            {
                //Verifica daca parola respecta numarul de caractere introduse 
                if (txtParola.Text.Length < lungimeMinimaParola ||
                    //Verifica numarul de caratere mari introduse)
                    VerificaCaractereMari(txtParola.Text) < 1 ||
                    //Verifica numarul de caratere mici introduse)
                    VerificaCaractereMici(txtParola.Text) < 1 ||
                    //Verifica numarul de caratere mici introduse)
                    VerificaNumere(txtParola.Text) < 1)
                {
                    MessageBox.Show("Te rugam, Introduce o parola valida.\n" +
                        "Parola trebuie sa contina un numar de 8 caractere." +
                        "\n Parola trebuie sa contina cel putin o litera mare." +
                        "\n Parola trebuie sa contina cel putin a litera mica." +
                        "\n parola trebuie sa contine cel putin un numar.",
                        "Eroare Date de Intrare", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtParola.Focus();

                    return false;
                }

            }

            //Validare confirmare parola
            if (txtConfirmareParola.Text.Length == 0)
            {
                MessageBox.Show("Te rugam sa confirmi parola."
                     , "Eroare Date de Intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtConfirmareParola.Focus();

                return false;
            }
            else
            {
                if (txtParola.Text != txtConfirmareParola.Text)
                {
                    MessageBox.Show("Parolele introduse nu corespund." +
                   "Te rugam sa incerci din nou"
                   , "Eroare Date de Intrare", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    txtConfirmareParola.Focus();

                    return false;
                }
            }

            if (txtPozitie.Text.Length == 0)
            {
                MessageBox.Show("Te rugam, Introduce Pozitia."
                    , "Eroare Date de Intrare", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPozitie.Focus();

                return false;
            }

            return true;
        }

        private int VerificaNumere(string parola)
        {
            //Variabila care va stoca numarul cifrelor
            int numere = 0;
            //Numara cifrele din parola
            foreach (char ch in parola)
            {
                //Gaseste fiecare numar cautat
                if (char.IsNumber(ch))
                {
                    //Incrementeaza cifrele gasite
                    numere++;
                }

            }

            return numere;
        }

        private int VerificaCaractereMici(string parola)
        {
            //Variabila care va stoca numarul de caractere mici
            int numarCaractereMici = 0;
            //Numara caractere mici din parola
            foreach (char ch in parola)
            {
                //Gaseste fiecare caracter mic cautat
                if (char.IsLower(ch))
                {
                    //Incrementeaza caracterele mici gasite
                    numarCaractereMici++;
                }

            }

            return numarCaractereMici;
        }

        private int VerificaCaractereMari(string parola)
        {
            //Variabila care va stoca numarul de caractere mari
            int numarCaractereMari = 0;
            //Numara caractere mari din parola
            foreach (char ch in parola)
            {
                //Gaseste fiecare caracter mic cautat
                if (char.IsUpper(ch))
                {
                    //Incrementeaza caracterele mari gasite
                    numarCaractereMari++;
                }

            }

            return numarCaractereMari;
        }

        private void CurataControale()
        {
            txtNumeUtilizator.Clear();
            txtParola.Clear();
            txtConfirmareParola.Clear();
            txtPozitie.Clear();
        }

        private void btnResetare_Click(object sender, EventArgs e)
        {
            CurataControale();
            txtNumeUtilizator.Focus();
        }

        private void btnUtilizatorInregistrare_Click(object sender, EventArgs e)
        {

            this.DateUtilizator();

            if (ValidareDateIntrare())
            {
                objUtilizator.Adauga();
            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet2.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tbUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet2.tbUtilizatori);
            CurataControale();

        }

        private void DateUtilizator()
        {
            objUtilizator = new Utilizator();
            objUtilizator.NumeUtilizator = txtNumeUtilizator.Text;
            objUtilizator.Parola = txtParola.Text;
            objUtilizator.Pozitie = txtPozitie.Text;

        }

        private void InregistrareUtilizatori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemScolarDataSet2.tbUtilizatori' table. You can move, or remove it, as needed.
            this.tbUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet2.tbUtilizatori);

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celule = dataGridView1.CurrentRow.Cells;
            UtilizatorID = Convert.ToInt32(celule[0].Value.ToString());
            txtNumeUtilizator.Text = celule[1].Value.ToString();
            txtParola.Text = celule[2].Value.ToString();
            txtConfirmareParola.Text = celule[2].Value.ToString();
            txtPozitie.Text = celule[3].Value.ToString();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();

            if (ValidareDateIntrare())
            {
                objUtilizator.Actualizare(UtilizatorID);
            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet2.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tbUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet2.tbUtilizatori);
            CurataControale(); 
        }

        private void btnResetare_Click_1(object sender, EventArgs e)
        {
            CurataControale();
            txtNumeUtilizator.Focus();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            this.DateUtilizator();

            if (ValidareDateIntrare())
            {
                objUtilizator.Sterge(UtilizatorID);
            }

            // TODO: This line of code loads data into the 'sistemScolarDataSet2.tblUtilizatori' table. You can move, or remove it, as needed.
            this.tbUtilizatoriTableAdapter.Fill(this.sistemScolarDataSet2.tbUtilizatori);
            CurataControale();
        }
    }
}
