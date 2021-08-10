using System;
using Microsoft.Data.SqlClient;

namespace Cabinet
{
    class Docteur
    {
        static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        static SqlConnection GateWay = new SqlConnection(strconnexion);
        public string nomDoc { get; set; }
        public string prenomDoc { get; set; }
        public int docID { get; set; }
        public string docPassword { get; set; }
        const string statut = "docteur";

        public void Engage()
        {
            string query = string.Format("INSERT INTO Secretaire(NomDocteur,PrenomDocteur,DocteurPassWord)" +
                " VALUES ('{0}','{1}','{2}')", this.nomDoc, this.prenomDoc,this.docPassword);

            SqlCommand cmd = new SqlCommand(query, GateWay);
            cmd.ExecuteNonQuery();
        }

    }
}
