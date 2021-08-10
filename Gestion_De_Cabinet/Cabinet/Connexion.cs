using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cabinet
{
    class Connexion
    {
        static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public static SqlConnection GateWay = new SqlConnection(strconnexion);
        public Connexion()
        {
            
            try
            {
                GateWay.Open();
                Console.WriteLine("Engaged\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void LeaveDB()
        {
            try
            {
                GateWay.Close();
                Console.WriteLine("\nI'm done");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}
