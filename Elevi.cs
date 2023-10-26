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
using System.Linq.Expressions;

namespace SistemScolarDeInregistrareApp
{
    public partial class FrmElevi : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();

        public FrmElevi()
        { 
            InitializeComponent();
            AfisareJudetelsd();
            Clase();
            btnActualizare.Enabled = false;
            btnStergere.Enabled = false;
        }

        public void AfisareJudetelsd()
        {
            dataAdpt = new SqlDataAdapter("SELECT * FROM Judet", conectare.DeschidereConectare());
            dt = new DataTable();   
            dataAdpt.Fill(dt);
            cmbJudet.DataSource = dt;
            cmbJudet.DisplayMember= "numeJudet";
            cmbJudet.ValueMember= "judetID";
        }

        private void cmbJudet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;
            try
            {
                int.TryParse(cmbJudet.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("SELECT * FROM Municipiu WHERE judetID= '" + 
                    valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbMunicipiu.DataSource = dt;
                cmbMunicipiu.DisplayMember = "numeMunicipiu";
                cmbMunicipiu.ValueMember = "municipiuID";

            }
            catch (Exception) { }
        }

        private void cmbMunicipiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;
            try
            {
                int.TryParse(cmbMunicipiu.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("SELECT * FROM Oras WHERE municipiuID= '" +
                    valoare + "'", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbOras.DataSource = dt;
                cmbOras.DisplayMember = "numeOras";
                cmbOras.ValueMember = "orasID";

            }
            catch (Exception) { }
        }

        public void Clase()
        {
            try 
            {
                dataAdpt = new SqlDataAdapter("SELECT * FROM Clase", conectare.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbClasa.DataSource = dt;
                cmbClasa.DisplayMember = "numeClasa";
                cmbClasa.ValueMember = "clasaID";

            }
            catch (Exception) { }
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            int clasaID = Convert.ToInt32(cmbClasa.SelectedValue);
            int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
            int municipiuID = Convert.ToInt32(cmbMunicipiu.SelectedValue);
            int orasID = Convert.ToInt32(cmbOras.SelectedValue);

            try
            {
                string sex = "Feminin";
                if (rdMasculin.Checked)
                {
                    sex = "Masculin";
                }

                if (txtNume.Text!="" && txtPrenume.Text!="" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cmbMunicipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("INSERT INTO Elevi VALUES('"+sex+ "','"+txtNume.Text+ "','"+txtPrenume.Text+ "'," +
                        "'"+txtAdresa.Text+"', '"+txtTelefon.Text+ "','"+txtEmail.Text+ "', " +
                        "'"+dtDataNasterii.Text+ "', '"+dtDataInregistrarii.Text+ "', '"+clasaID+ "', '"+judetID+ "', " +
                        "'"+municipiuID+ "', '"+orasID+ "')", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();                   

                    MessageBox.Show("Datele au fost salvate cu succes!");

                }
                else
                {
                    MessageBox.Show("Completati toate campurile!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            cmbClasa.Text = "";
            txtNume.Clear();
            txtPrenume.Clear();
            txtAdresa.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            cmbJudet.Text = "";
            cmbOras.Text = "";
            cmbMunicipiu.Text = "";


        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            FrmAfisareDateElevi elevi = new FrmAfisareDateElevi();
            elevi.Show();
            Hide();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            string sex = "";
            if(rdMasculin.Checked)
            {
                sex = "Masculin";
            }
            else
            {
                sex = "Feminin";
            }
            try
            {
                string DN = dtDataNasterii.Value.ToString("dd-MM-yyyy");
                string DI = dtDataInregistrarii.Value.ToString("dd-MM-yyyy");
                int judetID = Convert.ToInt32(cmbJudet.SelectedValue);
                int municipiuID = Convert.ToInt32(cmbMunicipiu.SelectedValue);
                int orasID = Convert.ToInt32(cmbOras.SelectedValue);
                int clasaID = Convert.ToInt32(cmbClasa.SelectedValue);

                if (txtNume.Text != "" && txtPrenume.Text != "" && txtAdresa.Text != ""
                    && txtTelefon.Text != "" && txtEmail.Text != "" && cmbJudet.Text != ""
                    && cmbMunicipiu.Text != "" && cmbOras.Text != "")
                {
                    cmd = new SqlCommand("Update elevi set sex = '" + sex + "', nume='" + txtNume.Text +
                        "',prenume='" + txtPrenume.Text + "', adresa='" + txtAdresa.Text + "', telefon = '" + txtTelefon.Text + "', email = '" + txtEmail.Text +
                        "', dataNasterii='" + DN + "', dataInregistrarii='" + DI + "',clasaID='" + clasaID + "'. judetID='" +
                        judetID + "', municipiuID='" + municipiuID + "',orasID='" + orasID +
                        "' where eleviID='" + FrmAfisareDateElevi.elevID + "'", conectare.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost actualizate cu succes!");
                }
                else
                {
                    MessageBox.Show("Te rog completeaza randurile goale!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectare.InchidereConectare();
            }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM Elevi WHERE eleviID = '"+FrmAfisareDateElevi.elevID+"'", conectare.DeschidereConectare());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datele au fost sterse cu succes!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conectare.InchidereConectare();
        }
    }
    }
 


