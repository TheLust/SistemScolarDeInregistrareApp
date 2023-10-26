using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemScolarDeInregistrareApp
{
    internal class Conectare
    {
        SqlConnection conectare;

        public static string cs = "Data Source=DESKTOP-JM98U40;Initial Catalog=SistemScolar;Integrated Security=True";

        public Conectare()
        {
            conectare = new SqlConnection("Data Source=DESKTOP-JM98U40;Initial Catalog=SistemScolar;Integrated Security=True");
        }

        public SqlConnection DeschidereConectare()
        {
            try
            {
                conectare.Open();
            }
            catch(Exception)
            {

            }
            return conectare;
        }

        public void InchidereConectare()
        {
            try
            {
                conectare.Close();
            }
            catch(Exception) { }        
        }



            
    }
}
