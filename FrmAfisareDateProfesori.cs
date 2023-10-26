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
    public partial class FrmAfisareDateProfesori : MaterialSkin.Controls.MaterialForm
    {
        Conectare con = new Conectare();
        SqlDataAdapter dataAdpt;
        SqlCommand cmd;
        System.Data.DataTable dt;
        public static int profesorID;

        public FrmAfisareDateProfesori()
        {
            InitializeComponent();
        }

        private void FrmAfisareDateProfesori_Load(object sender, EventArgs e)
        {
            try
            {
                dataAdpt = new SqlDataAdapter("select Profesori.ProfesorID, Profesori.Nume, Profesori.Prenume, " +
                    "Profesori.Adresa, Profesori.Telefon, Profesori.Email, Profesori.DataNasterii, Profesori.Sex, " +
                    "Experienta.experienta, Judet.numeJudet, Municipiu.numeMunicipiu, Oras.numeOras from Profesori " +
                    "inner join Experienta on Experienta.experientaID = Profesori.ExperientaID " +
                    "inner join Judet on Judet.judetID = Profesori.judetID " +
                    "inner join Municipiu on Municipiu.municipiuID = Profesori.municipiuID " +
                    "inner join Oras on Oras.orasID = Profesori.orasID", con.DeschidereConectare());

                dt = new System.Data.DataTable();
                dataAdpt.Fill(dt);
                dgwProfesori.DataSource = dt;

                con.InchidereConectare();
            }
            catch (Exception)
            {

            }

        }

        private void dgwProfesori_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FrmProfesori pr = new FrmProfesori();
                profesorID = Convert.ToInt32(dgwProfesori.Rows[e.RowIndex].Cells[0].Value.ToString());
                pr.txt_pr_Nume.Text = dgwProfesori.Rows[e.RowIndex].Cells[1].Value.ToString();
                pr.txt_pr_Prenume.Text = dgwProfesori.Rows[e.RowIndex].Cells[2].Value.ToString();
                pr.txt_pr_Adresa.Text = dgwProfesori.Rows[e.RowIndex].Cells[3].Value.ToString();
                pr.txt_pr_Telefon.Text = dgwProfesori.Rows[e.RowIndex].Cells[4].Value.ToString();
                pr.txt_pr_Email.Text = dgwProfesori.Rows[e.RowIndex].Cells[5].Value.ToString();
                pr.dt_pr_DataNasterii.Text = dgwProfesori.Rows[e.RowIndex].Cells[6].Value.ToString();

                pr.rd_pr_Masculin.Checked = false;
                pr.rd_pr_Feminin.Checked = true;

                if (dgwProfesori.Rows[e.RowIndex].Cells[7].Value.ToString() == "Masculin")
                {
                    pr.rd_pr_Masculin.Checked = true;
                    pr.rd_pr_Feminin.Checked = false;
                }

                pr.cmbExperienta.Text = dgwProfesori.Rows[e.RowIndex].Cells[8].Value.ToString();
                pr.cmb_pr_Judet.Text = dgwProfesori.Rows[e.RowIndex].Cells[9].Value.ToString();
                pr.cmb_pr_Municipiu.Text = dgwProfesori.Rows[e.RowIndex].Cells[10].Value.ToString();
                pr.cmb_pr_Oras.Text = dgwProfesori.Rows[e.RowIndex].Cells[11].Value.ToString();
                pr.Show();
                pr.btn_pr_Stergere.Enabled = true;
                pr.btn_pr_Actualizare.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            public void cautaredupanume(string nume)
            {
                string interogare = "select * from Profesori where Nume like '%" + nume + "%'";
                cmd = new SqlCommand(interogare, con.DeschidereConectare());
                dataAdpt = new SqlDataAdapter(cmd);
                dt = new System.Data.DataTable();
                dataAdpt.Fill(dt);
                dgwProfesori.DataSource = dt;
            }

        private void txt_pr_cautare_TextChanged(object sender, EventArgs e)
        {
            cautaredupanume(txt_pr_cautare.Text);
        }

        private void btn_Excel_DateProfesori_Click(object sender, EventArgs e)
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


                for (int i = 1; i < dgwProfesori.Columns.Count + 1; i++)
                {
                    FoaieCalculEx.Cells[1, i] = dgwProfesori.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgwProfesori.RowCount; i++)
                {
                    for (int j = 0; j < dgwProfesori.ColumnCount; j++)
                    {
                        FoaieCalculEx.Cells[i + 2, j + 1] = dgwProfesori.Rows[i].Cells[j].Value;
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

