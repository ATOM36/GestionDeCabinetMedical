using System;
using Microsoft.Data.SqlClient;
using System.Data;


namespace Cabinet
{
    class Admin
    {
        static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        static SqlConnection GateWay = new SqlConnection(strconnexion);

        public string nomAdmin { get; set; }
        public string prenomAdmin { get; set; }
        public int adminID { get; set; }
        public string adminPassword { get; set; }
        const string fonction = "administrateur";

        public static void SecretaryTable()
        {
            string selQuery = "SELECT * FROM Secretaire;";
            SqlDataAdapter da = new SqlDataAdapter(selQuery, GateWay);
            DataSet ds = new DataSet();
            da.Fill(ds, "Secretaire");
        }
    }
}
