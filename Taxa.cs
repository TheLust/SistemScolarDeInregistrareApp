using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemScolarDeInregistrareApp
{
    public partial class FrmTaxa : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();

        public FrmTaxa()
        {
            InitializeComponent();
            NumeElevi();
            PrenumeElevi();
            ClasaTaxa();
            Lunile();
            btn_taxa_Actualizare.Enabled = false;
            btn_taxa_Stergere.Enabled = false;
        }

        public void NumeElevi()
        {
            dataAdpt = new SqlDataAdapter("select * from Elevi", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmb_taxa_nume.DataSource = dt;
            cmb_taxa_nume.DisplayMember = "nume";
            cmb_taxa_nume.ValueMember = "eleviID";

            conectare.InchidereConectare();
        }

        public void PrenumeElevi()
        {
            dataAdpt = new SqlDataAdapter("select * from Elevi", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmb_taxa_prenume.DataSource = dt;
            cmb_taxa_prenume.DisplayMember = "prenume";
            cmb_taxa_prenume.ValueMember = "eleviID";

            conectare.InchidereConectare();
        }

        public void ClasaTaxa()
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select * from Clase", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmb_taxa_Clasa.DataSource = dt;
                cmb_taxa_Clasa.DisplayMember = "numeClasa";
                cmb_taxa_Clasa.ValueMember = "clasaID";

            }
            catch (Exception)
            {

            }


            conectare.InchidereConectare();
        }

        public void Lunile()
        {
            dataAdpt = new SqlDataAdapter("select * from Lunile", conectare.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmb_taxa_Luna.DataSource = dt;
            cmb_taxa_Luna.DisplayMember = "Luna";
            cmb_taxa_Luna.ValueMember = "LunaID";

            conectare.InchidereConectare();
        }

        private void btn_taxa_Salvare_Click(object sender, EventArgs e)
        {
            int Clasa = Convert.ToInt32(cmb_taxa_Clasa.SelectedValue.ToString());
            int Nume = Convert.ToInt32(cmb_taxa_nume.SelectedValue.ToString());
            int Prenume = Convert.ToInt32(cmb_taxa_prenume.SelectedValue.ToString());
            int Luna = Convert.ToInt32(cmb_taxa_Luna.SelectedValue.ToString());

            if (cmb_taxa_Clasa.Text != "" && cmb_taxa_nume.Text != "" && cmb_taxa_prenume.Text != "" && cmb_taxa_Luna.Text
                != "" && txt_taxa_Suma.Text != "")
            {
                cmd = new SqlCommand("insert into Taxa values ('" + Clasa + "', '" + Nume + "', '" + Prenume + "', " +
                    "'" + dt_taxa_DataAdmiterii.Text + "', '" + Luna + "', '" + txt_taxa_Suma.Text + "')",
                    conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Datele au fost salvate in baza de date");
            }
            else
            {
                MessageBox.Show("Te rog completeaza toate casutele");
            }

            conectare.InchidereConectare();
        }

        private void btn_taxa_Date_Click(object sender, EventArgs e)
        {
            FrmAfisareDateTaxa afisaredtTaxa = new FrmAfisareDateTaxa();

            afisaredtTaxa.Show();
            Hide();
        }

        private void btn_taxa_Adaugare_Click(object sender, EventArgs e)
        {
            cmb_taxa_Clasa.Text = "";
            cmb_taxa_nume.Text = "";
            cmb_taxa_prenume.Text = "";
            cmb_taxa_Luna.Text = "";
            txt_taxa_Suma.Clear();
        }

        private void btn_taxa_Actualizare_Click(object sender, EventArgs e)
        {
            try
            {
                int clasaID = Convert.ToInt32(cmb_taxa_Clasa.SelectedValue);
                int numeID = Convert.ToInt32(cmb_taxa_nume.SelectedValue);
                int prenumeID = Convert.ToInt32(cmb_taxa_prenume.SelectedValue);
                int lunaID = Convert.ToInt32(cmb_taxa_Luna.SelectedValue);
                string dataAdTaxa = dt_taxa_DataAdmiterii.Value.ToString("dd-MM-yyyy");

                if (cmb_taxa_Clasa.Text != "" && cmb_taxa_nume.Text != "" && cmb_taxa_prenume.Text != "" &&
                    cmb_taxa_Luna.Text != "" && txt_taxa_Suma.Text != "")
                {
                    cmd = new SqlCommand("update taxa set ClasaID = '" + clasaID + "', NumeID = '" + numeID + "', " +
                        "PrenumeID = '" + prenumeID + "', DataAdmiterii = '" + dataAdTaxa + "', LunaID = '" + lunaID + "', " +
                        "Suma = '" + txt_taxa_Suma.Text + "' where TaxaID = '" + FrmAfisareDateTaxa.taxaID + "'",
                        conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Datele despre taxa au fost actualizate");
                }
                else
                {
                    MessageBox.Show("Te rog completeaza toate casutele");
                }

                conectare.InchidereConectare();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_taxa_Stergere_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("delete from taxa where TaxaID = '" + FrmAfisareDateTaxa.taxaID + "'",
                conectare.DeschidereConectare());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Datele despre taxa au fost sterse cu succes!");

            conectare.InchidereConectare();
        }
    }
}
