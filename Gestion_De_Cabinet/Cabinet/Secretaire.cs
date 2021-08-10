using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.Json;

namespace Cabinet
{
    class Secretaire : User, IFonctionnalites
    {
        public Secretaire(string nom, string prenom, string pass)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.password = pass;
            this.statut = "Secrétaire";
            this.GateWay.Open();
        }

        public void AddPatient(Patient lambda)
        {
            lambda.secretaireID = this.UserID;
            lambda.Registration();
        }

        public int CountSecretary()
        {
            try
            {
                string querry = "SELECT Count(*) FROM Secretaire;";
                SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                int n = (int)cmd.ExecuteScalar();
                return n;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public int CountDoctor()
        {
            throw new NotImplementedException();
        }

        public int CountPatient()
        {
            try
            {
                string querry = "SELECT Count(*) FROM Patient;";
                SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                int n = (int)cmd.ExecuteScalar();
                return n;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void S_Engager()
        {
            try
            {
                string query = string.Format("INSERT INTO Secretaire(CodeSecurite,NomSecretaire," +
                    "PrenomSecretaire) VALUES " +
                "('{0}','{1}','{2}')", this.password, this.nom, this.prenom);

                SqlCommand cmd = new SqlCommand(query, this.GateWay);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        public void RemovePatient(Patient lambda)
        {
            lambda.CancelRegistration();
        }

        public void UpdateNom(string newName)
        {
            try
            {
                string query = string.Format("UPDATE Secretaire SET NomSecretaire='{0}' WHERE " +
                    "NomSecretaire='{1}';", newName, this.nom);
                SqlCommand cmd = new SqlCommand(query, this.GateWay);
                cmd.ExecuteNonQuery();
                this.prenom = newName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdatePrenom(string newName)
        {
            try
            {
                string query = string.Format("UPDATE Secretaire SET NomSecretaire='{0}' WHERE " +
                    "NomSecretaire='{1}';", newName, this.prenom);
                SqlCommand cmd = new SqlCommand(query, this.GateWay);
                cmd.ExecuteNonQuery();
                this.prenom = newName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void UpdateNomPatient(Patient lambda, string newName)
        {
            lambda.UpdateNomPatient(newName);
        }

        public void UpdatePrenomPatient(Patient lambda, string newName)
        {
            lambda.UpdatePrenomPatient(newName);
        }

        public void SecretaryTable()
        {
            try
            {
                string querry = "SELECT * FROM Utilisateur;";
                SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                SqlDataReader rd = cmd.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rd);
                rd.Close();

                foreach (DataRow dr in table.Rows)
                {
                    Console.WriteLine("******************");
                    Console.WriteLine(string.Format("UserID: {0}\nCodeSecurite: {1}\n" +
                        "UserName: {2}\n Nom: {3}\nPrenom: {4}\nStatut: {5}", dr["UserId"],
                        dr["CodeSecurite"], dr["UserName"], dr["Nom"], dr["Prenom"],dr["Statut"]));
                } 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
