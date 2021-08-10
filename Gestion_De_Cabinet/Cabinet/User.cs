using System;
using Microsoft.Data.SqlClient;

namespace Cabinet
{
    public class User
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string password { get; set; }
        public int UserID { get; set; }
        public string statut { get; set; }

        public string UserName { get; set; }

        static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion); 
    }
}
