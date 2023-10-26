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
    public partial class FrmProfesori : MaterialSkin.Controls.MaterialForm
    {
        Conectare con = new Conectare();
        SqlDataAdapter dataAdpt;
        DataTable dt;
        SqlCommand cmd;
        public FrmProfesori()
        {
            InitializeComponent();
            AfisareJudete();
            Experienta();
            btn_pr_Stergere.Enabled = false;
            btn_pr_Actualizare.Enabled = false;
        }

        public void AfisareJudete()
        {
            dataAdpt = new SqlDataAdapter("SELECT * FROM Judet", con.DeschidereConectare());
            dt = new DataTable();
            dataAdpt.Fill(dt);
            cmb_pr_Judet.DataSource = dt;
            cmb_pr_Judet.DisplayMember = "numeJudet";
            cmb_pr_Judet.ValueMember = "judetID";

            con.InchidereConectare();
        }

        private void cmb_pr_Judet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;
            try
            {
                int.TryParse(cmb_pr_Judet.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("SELECT * FROM Municipiu WHERE judetID= '" +
                    valoare + "'", con.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmb_pr_Municipiu.DataSource = dt;
                cmb_pr_Municipiu.DisplayMember = "numeMunicipiu";
                cmb_pr_Municipiu.ValueMember = "municipiuID";

            }
            catch (Exception) { }
            con.InchidereConectare();
        }

        private void cmb_pr_Municipiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valoare;
            try
            {
                int.TryParse(cmb_pr_Municipiu.SelectedValue.ToString(), out valoare);
                dataAdpt = new SqlDataAdapter("SELECT * FROM Oras WHERE municipiuID= '" +
                    valoare + "'", con.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmb_pr_Oras.DataSource = dt;
                cmb_pr_Oras.DisplayMember = "numeOras";
                cmb_pr_Oras.ValueMember = "orasID";

            }
            catch (Exception) { }
            con.InchidereConectare();
        }

        private void Experienta()
            { 
                dataAdpt = new SqlDataAdapter("SELECT * FROM Experienta", con.DeschidereConectare());
                dt = new DataTable();
                dataAdpt.Fill(dt);
                cmbExperienta.DataSource = dt;
                cmbExperienta.DisplayMember = "experienta";
                cmbExperienta.ValueMember = "experientaID";

                con.InchidereConectare();   

      

            }

        private void btn_pr_Salvare_Click(object sender, EventArgs e)
        {
            int experientaID = Convert.ToInt32(cmbExperienta.SelectedValue);
            int judetID = Convert.ToInt32(cmb_pr_Judet.SelectedValue);
            int municipiuID = Convert.ToInt32(cmb_pr_Municipiu.SelectedValue);
            int orasID = Convert.ToInt32(cmb_pr_Oras.SelectedValue);

            try
            {
                string sex = "Feminin";

                if (rd_pr_Masculin.Checked)
                {
                    sex = "Masculin";
                }

                if (txt_pr_Nume.Text != "" && txt_pr_Prenume.Text != "" && txt_pr_Adresa.Text != "" && txt_pr_Telefon.Text != "" &&
                    txt_pr_Email.Text != "" && cmb_pr_Judet.Text != "" && cmb_pr_Municipiu.Text != "" && cmb_pr_Oras.Text != "" &&
                    cmbExperienta.Text != "")
                {
                    cmd = new SqlCommand("insert into Profesori values('" + txt_pr_Nume.Text + "', '" + txt_pr_Prenume.Text +
                        "','" + txt_pr_Adresa.Text + "','" + txt_pr_Telefon.Text + "','" + txt_pr_Email.Text +
                        "','" + sex + "','" + dt_pr_DataNasterii.Text + "','" + experientaID + "','" + judetID +
                        "', '" + municipiuID + "' , '" + orasID + "')", con.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datele au fost salvate");
                    con.InchidereConectare();
                }
                else
                {
                    MessageBox.Show("Va rog sa completati campurile goale");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pr_Adaugare_Click(object sender, EventArgs e)
        {
            txt_pr_Nume.Text = "";
            txt_pr_Prenume.Text = "";
            txt_pr_Adresa.Text = "";
            txt_pr_Telefon.Text = "";
            txt_pr_Email.Text = "";
            cmb_pr_Judet.Text = "";
            cmb_pr_Municipiu.Text = "";
            cmb_pr_Oras.Text = "";
            cmbExperienta.Text = "";
        }

        private void btn_pr_Actualizare_Click(object sender, EventArgs e)
        {
            string sex = "";

            if (rd_pr_Masculin.Checked)
            {
                sex = "Masculin";
            }
            else
            {
                sex = "Feminin";
            }

            try
            {

                string DN = dt_pr_DataNasterii.Value.ToString("dd-MM-yyyy");
                int judetID = Convert.ToInt32(cmb_pr_Judet.SelectedValue);
                int municipiuID = Convert.ToInt32(cmb_pr_Municipiu.SelectedValue);
                int orasID = Convert.ToInt32(cmb_pr_Oras.SelectedValue);
                int experientaID = Convert.ToInt32(cmbExperienta.SelectedValue);

                if (txt_pr_Nume.Text != "" && txt_pr_Prenume.Text != "" && txt_pr_Adresa.Text != ""
                    && txt_pr_Telefon.Text != "" && txt_pr_Email.Text != "" && cmb_pr_Judet.Text != ""
                    && cmb_pr_Municipiu.Text != "" && cmb_pr_Oras.Text != "")
                {
                    cmd = new SqlCommand("update profesori set Nume='" + txt_pr_Nume.Text + "',Prenume='" + txt_pr_Prenume.Text +
                        "', Adresa='" + txt_pr_Adresa.Text + "', Telefon='" + txt_pr_Telefon.Text + "', Email='" + txt_pr_Email.Text +
                        "', Sex='" + sex + "', DataNasterii='" + DN + "', ExperientaID='" + experientaID + "', judetID='" +
                        judetID + "',municipiuID='" + municipiuID + "', orasID='" + orasID +
                        "' where ProfesorID='" + FrmAfisareDateProfesori.profesorID + "'", con.DeschidereConectare());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Datele au fost actualizate cu succes! ");
                }
                else
                {
                    MessageBox.Show(" Te rog completeaza randurile goale");
                }

                con.InchidereConectare();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pr_Date_Click(object sender, EventArgs e)
        {
            FrmAfisareDateProfesori afDatePR = new FrmAfisareDateProfesori();
            afDatePR.Show();
            Hide();
        }

        private void btn_pr_Stergere_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("DELETE FROM Profesori WHERE ProfesorID = '" + FrmAfisareDateProfesori.profesorID + "'",
               con.DeschidereConectare());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Inregistrarile au fost sterse");

            con.InchidereConectare();
        }


    }
}
