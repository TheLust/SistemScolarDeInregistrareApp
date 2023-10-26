using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemScolarDeInregistrareApp
{
    public partial class FrmAfisareDateElevi : MaterialSkin.Controls.MaterialForm
    {
        Conectare con = new Conectare();
        SqlDataAdapter dtAp;
        System.Data.DataTable dt;
        SqlCommand cmd;
        public static int elevID;

        public FrmAfisareDateElevi()
        {
            InitializeComponent();
        }

        private void FrmAfisareDateElevi_Load(object sender, EventArgs e)
        {
            dtAp = new SqlDataAdapter("SELECT Elevi.eleviID, Elevi.nume, Elevi.prenume, Elevi.sex, Elevi.adresa, Elevi.telefon, Elevi.email, Elevi.dataNasterii, Elevi.dataInregistrarii," +
                "Clase.numeClasa, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras FROM Elevi " +
                "INNER JOIN Clase ON Elevi.clasaID=Clase.clasaID " +
                "INNER JOIN Judet ON Elevi.judetID=Judet.judetID " +
                "INNER JOIN Municipiu ON Elevi.municipiuID=Municipiu.municipiuID " +
                "INNER JOIN Oras ON Elevi.orasID=Oras.orasID", con.DeschidereConectare());

            dt = new System.Data.DataTable();
            dtAp.Fill(dt);
            GDAfisareElevi.DataSource = dt;

            con.InchidereConectare();
        }

        private void GDAfisareElevi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmElevi incarcareDateElevi = new FrmElevi();

            elevID = Convert.ToInt32(GDAfisareElevi.Rows[e.RowIndex].Cells[0].Value.ToString());

            incarcareDateElevi.txtNume.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[1].Value.ToString());
            incarcareDateElevi.txtPrenume.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[2].Value.ToString());
            incarcareDateElevi.rdMasculin.Checked = true;
            incarcareDateElevi.rdFeminin.Checked = false;

            if (GDAfisareElevi.Rows[e.RowIndex].Cells[3].Value.ToString() == "Feminin")
            {
                incarcareDateElevi.rdMasculin.Checked = false;
                incarcareDateElevi.rdFeminin.Checked = true;
            }

            incarcareDateElevi.txtAdresa.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[4].Value.ToString());
            incarcareDateElevi.txtTelefon.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[5].Value.ToString());
            incarcareDateElevi.txtEmail.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[6].Value.ToString());
            incarcareDateElevi.dtDataNasterii.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[7].Value.ToString());
            incarcareDateElevi.dtDataInregistrarii.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[8].Value.ToString());
            incarcareDateElevi.cmbClasa.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[9].Value.ToString());
            incarcareDateElevi.cmbJudet.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[10].Value.ToString());
            incarcareDateElevi.cmbMunicipiu.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[11].Value.ToString());
            incarcareDateElevi.cmbOras.Text = (GDAfisareElevi.Rows[e.RowIndex].Cells[12].Value.ToString());

            incarcareDateElevi.Show();
            incarcareDateElevi.btnActualizare.Enabled = true;
            incarcareDateElevi.btnStergere.Enabled = true;




        }

        public void CautareDupaPrenume(string prenume)
        {
            string cautare = "select * from elevi where Prenume like '%" + prenume + "%'";
            cmd = new SqlCommand(cautare, con.DeschidereConectare());
            dtAp = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            dtAp.Fill(dt);
            GDAfisareElevi.DataSource = dt;

        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            CautareDupaPrenume(txtCautare.Text);
        }

        private void btn_Excel_DateElevi_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelExport;
            Workbook RegistruEx;
            Worksheet FoaieCalculEx;

            try
            {
                ExcelExport = new Microsoft.Office.Interop.Excel.Application();
                RegistruEx = ExcelExport.Workbooks.Add(Type.Missing);
                FoaieCalculEx = null;

                FoaieCalculEx = RegistruEx.Sheets["Sheet1"];
                FoaieCalculEx = RegistruEx.ActiveSheet;
                FoaieCalculEx.Name = "DateElevi";
                ExcelExport.Visible = true;

                for (int i = 1; i < GDAfisareElevi.Columns.Count + 1; i++)
                {
                    FoaieCalculEx.Cells[1, i] = GDAfisareElevi.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < GDAfisareElevi.RowCount; i++)
                {
                    for (int j = 0; j < GDAfisareElevi.ColumnCount; j++)
                    {
                        FoaieCalculEx.Cells[i + 2, j + 1] = GDAfisareElevi.Rows[i].Cells[j].Value;
                    }

                }

                ExcelExport.Columns.AutoFit();

            }
            catch (Exception)
            {

            }
        }
    }
}
