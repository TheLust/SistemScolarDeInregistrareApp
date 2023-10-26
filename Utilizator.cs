using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;

namespace SistemScolarDeInregistrareApp
{
    public class Utilizator
    {
        SqlDataAdapter adapter;
        DataSet ds;

        //Campurile Membre
        private string numeUtilizator;
        private string parola;
        private string pozitie;

        //Constructor implicit
        public Utilizator()
        {

        }

        public string NumeUtilizator
        {
            get { return numeUtilizator; }
            set { numeUtilizator = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }

        public string Pozitie
        {
            get { return pozitie; }
            set { pozitie = value; }
        }

        //Metoda care adauga utilizatorii in baza de date
        public void Adauga()
        {
            //Sirul de conectare
            string conectare = ConfigurationManager.ConnectionStrings
                ["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(conectare);

            try
            {
                //Creare obiect SqlCommand
                SqlCommand obSqlCommandVerificare = new SqlCommand("VerificareUtilizatori",
                    obSqlConectare);
                obSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                obSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                obSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();

                adapter = new SqlDataAdapter(obSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de Utilizator/Parola exista in baza de date");

                    return;
                }
                else
                {
                    //Creare obiect SqlCommand
                    SqlCommand obSqlCommand = new SqlCommand("AdaugareUtilizator", obSqlConectare);
                    obSqlCommand.CommandType = CommandType.StoredProcedure;
                    obSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    obSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    obSqlCommand.Parameters.AddWithValue("@Pozitia", Pozitie);
                    obSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Utilizator adaugat cu Succes.", "Succes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:" + ex.Message, "Eroare Inserare Valori SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            finally
            {
                obSqlConectare.Close();

            }

        }

        //Metoda care actualizeaza utilizatorii in baza de date
        public void Actualizare(int id)
        {
            //Sirul de conectare
            string conectare = ConfigurationManager.ConnectionStrings
                ["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(conectare);

            try
            {
                //Creare obiect SqlCommand
                SqlCommand obSqlCommandVerificare = new SqlCommand("VerificareUtilizatori",
                    obSqlConectare);
                obSqlCommandVerificare.CommandType = CommandType.StoredProcedure;
                obSqlCommandVerificare.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                obSqlCommandVerificare.Parameters.AddWithValue("@Parola", Parola);
                obSqlConectare.Open();

                adapter = new SqlDataAdapter(obSqlCommandVerificare);
                ds = new DataSet();
                adapter.Fill(ds);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    MessageBox.Show("Numele de Utilizator/Parola exista in baza de date");

                    return;
                }
                else
                {
                    //Creare obiect SqlCommand
                    SqlCommand obSqlCommand = new SqlCommand("ActualizareUtilizatori", obSqlConectare);
                    obSqlCommand.CommandType = CommandType.StoredProcedure;
                    obSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);
                    obSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
                    obSqlCommand.Parameters.AddWithValue("@Parola", Parola);
                    obSqlCommand.Parameters.AddWithValue("@Pozitia", Pozitie);
                    obSqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Utilizator actualizat cu Succes.", "Succes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:" + ex.Message, "Eroare Actualizare Valori SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            finally
            {
                obSqlConectare.Close();

            }
        }

        //Metoda care sterge utilizatorii din baza de date
        public void Sterge(int id)
        {
            //Sirul de conectare
            string conectare = ConfigurationManager.ConnectionStrings
                ["SistemScolarConnectionString"].ConnectionString;

            //Creare obiect pentru conectare
            SqlConnection obSqlConectare = new SqlConnection(conectare);
            //Creare obiect SqlCommand
            SqlCommand obSqlCommand = new SqlCommand("StergereUtilizator", obSqlConectare);
            obSqlCommand.CommandType = CommandType.StoredProcedure;
            obSqlCommand.Parameters.AddWithValue("@UtilizatorID", id);

            try
            {

                obSqlConectare.Open();
                obSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare:" + ex.Message, "Eroare Stergere Valori SQL", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            finally
            {
                obSqlConectare.Close();

            }

            MessageBox.Show("Utilizator Sters cu Succes din Baza de Date.", "Succes",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Metoda care autorizeaza utilizatorii
        public bool AutorizareUtilizator()
        {
            bool esteUtilizatorAutorizat = false;
            //ConnectionString

            string cs = ConfigurationManager.ConnectionStrings
                ["SistemScolarConnectionString"].ConnectionString;
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("isUtilizatorValid", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@NumeUtilizator", NumeUtilizator);
            objSqlCommand.Parameters.AddWithValue("@Parola", Parola);

            try
            {
                objSqlConnection.Open();
                esteUtilizatorAutorizat = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "Utilizator Neautorizat",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }

            return esteUtilizatorAutorizat;
        }

        public bool AutorizareAdmin()
        {
            bool esteAdminValid = false;
            //ConnectionString
            string cs = ConfigurationManager.ConnectionStrings
                ["SistemScolarConnectionString"].ConnectionString;
            //Connection Object
            SqlConnection objSqlConnection = new SqlConnection(cs);
            //SqlCommand Object
            SqlCommand objSqlCommand = new SqlCommand("isAdminValid", objSqlConnection);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@Admin", NumeUtilizator);
            objSqlCommand.Parameters.AddWithValue("@Parola", Parola);

            try
            {
                objSqlConnection.Open();
                esteAdminValid = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error:" + ex.Message, "Administrator Neautorizat",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objSqlConnection.Close();
            }

            return esteAdminValid;
        }

    }
}
