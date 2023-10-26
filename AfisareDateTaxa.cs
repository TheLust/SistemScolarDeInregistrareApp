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
using Microsoft.Office.Interop.Excel;

namespace SistemScolarDeInregistrareApp
{
    public partial class FrmAfisareDateTaxa : MaterialSkin.Controls.MaterialForm
    {
        SqlDataAdapter dataAdpt;
        System.Data.DataTable dt;
        SqlCommand cmd;
        Conectare conectare = new Conectare();
        public static int taxaID;


        public FrmAfisareDateTaxa()
        {
            InitializeComponent();
            AfisareDateTaxe();
        }

        public void AfisareDateTaxe()
        {
            dataAdpt = new SqlDataAdapter("select Taxa.TaxaID, Clase.numeClasa, Elevi.nume, Elevi.prenume, Lunile.Luna, " +
                "Taxa.DataAdmiterii, Taxa.Suma from Taxa " +
                "inner join Clase on Clase.clasaID = Taxa.ClasaID " +
                "inner join Elevi on Elevi.eleviID = Taxa.NumeID " +
                "inner join Lunile on Lunile.LunaID = Taxa.LunaID", conectare.DeschidereConectare());

            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            dtgwAfisareDateTaxe.DataSource = dt;

            conectare.InchidereConectare();
        }

        private void dtgwAfisareDateTaxe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            FrmTaxa dtTaxa = new FrmTaxa();

            taxaID = Convert.ToInt32(dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[0].Value.ToString());
            dtTaxa.cmb_taxa_Clasa.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtTaxa.cmb_taxa_nume.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtTaxa.cmb_taxa_prenume.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtTaxa.cmb_taxa_Luna.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[4].Value.ToString();
            dtTaxa.dt_taxa_DataAdmiterii.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[5].Value.ToString();
            dtTaxa.txt_taxa_Suma.Text = dtgwAfisareDateTaxe.Rows[e.RowIndex].Cells[6].Value.ToString();
            dtTaxa.Show();

            dtTaxa.btn_taxa_Actualizare.Enabled = true;
            dtTaxa.btn_taxa_Stergere.Enabled = true;
        }

        private void txtCautare_TextChanged(object sender, EventArgs e)
        {
            CautareDupaPrenume(txtCautareDupaPrenume.Text);
        }

        public void CautareDupaPrenume(string prenume)
        {
            string interogare = "select Taxa.TaxaID, Clase.numeClasa, Elevi.nume, Elevi.prenume, Lunile.Luna, " +
                "Taxa.DataAdmiterii, Taxa.Suma from Taxa " +
                "inner join Clase on Clase.clasaID = Taxa.ClasaID " +
                "inner join Elevi on Elevi.eleviID = Taxa.NumeID " +
                "inner join Lunile on Lunile.LunaID = Taxa.LunaID where prenume like '%" + prenume + "%'";

            cmd = new SqlCommand(interogare, conectare.DeschidereConectare());
            dataAdpt = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            dataAdpt.Fill(dt);
            dtgwAfisareDateTaxe.DataSource = dt;
        }

        private void btn_Excel_DateTaxa_Click(object sender, EventArgs e)
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


                for (int i = 1; i < dtgwAfisareDateTaxe.Columns.Count + 1; i++)
                {
                    FoaieCalculEx.Cells[1, i] = dtgwAfisareDateTaxe.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dtgwAfisareDateTaxe.RowCount; i++)
                {
                    for (int j = 0; j < dtgwAfisareDateTaxe.ColumnCount; j++)
                    {
                        FoaieCalculEx.Cells[i + 2, j + 1] = dtgwAfisareDateTaxe.Rows[i].Cells[j].Value;
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
