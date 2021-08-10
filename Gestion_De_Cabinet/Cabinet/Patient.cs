using System;
using System.IO;
using Microsoft.Data.SqlClient;

namespace Cabinet
{
    public class Patient
    {
        static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        static SqlConnection GateWay = new SqlConnection(strconnexion);

        public string nomPatient { get; set; }
        public string prenomPatient { get; set; }
        public int patientID { get; set; }
        public string causeAdmission { get; set; }
        public int secretaireID { get; set; }
        public string dateAdmission { get; set; }
        public float poids { get; set; }
        public int age { get; set; }
      

        public static int CountPatient()
        {
            try
            {
                string query = "SELECT Count(*) FROM Patient;";
                SqlCommand cmd = new SqlCommand(query, GateWay);
                int n = (int)cmd.ExecuteScalar();
                return n;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void Registration()
        {
            string query = string.Format("INSERT INTO Patient (PatientID,SecretaireID,NomPatient," +
               "PrenomPatient,Age,Poids,CauseAdmission,DateAdmission) VALUES ('{0}','{1}','{2}'," +
               "'{3}','{4}','{5}','{6}','{7}');", this.patientID, this.secretaireID, this.nomPatient,
               this.prenomPatient, this.age, this.poids, this.causeAdmission, this.dateAdmission);

            SqlCommand cmd = new SqlCommand(query, GateWay);
            cmd.ExecuteNonQuery();
        }

        public void CancelRegistration()
        {
            string query = string.Format("DELETE FROM Patient where PatientID={0}", this.patientID);
            SqlCommand cmd = new SqlCommand(query, GateWay);
            cmd.ExecuteNonQuery();
        }

        public void UpdatePrenomPatient(string newName)
        {
            try
            {
                string query = string.Format("UPDATE Secretaire SET NomSecretaire='{0}' WHERE " +
                    "NomSecretaire='{1}';", newName, this.prenomPatient);
                SqlCommand cmd = new SqlCommand(query, GateWay);
                cmd.ExecuteNonQuery();
                this.prenomPatient = newName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateNomPatient(string newName)
        {
            try
            {
                string query = string.Format("UPDATE Secretaire SET NomSecretaire='{0}' WHERE " +
                    "NomSecretaire='{1}';", newName, this.nomPatient);
                SqlCommand cmd = new SqlCommand(query, GateWay);
                cmd.ExecuteNonQuery();
                this.nomPatient = newName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}
