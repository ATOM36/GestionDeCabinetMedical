using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cabinet.Secrétaire
{
    public partial class InterfaceSecretaire : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public int ID;
        public InterfaceSecretaire(int token)
        {
            InitializeComponent();
            this.Visible = false;
            this.ID = token;
        }

        private void newPatient_Click(object sender, EventArgs e)
        {
            using(RegistrationForm child = new RegistrationForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void cancelMeeting_Click(object sender, EventArgs e)
        {
            using (RemovalForm child = new RemovalForm())
            {
                child.ShowDialog();
            }
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.GateWay.Close();
                timer1.Stop();
                this.Dispose();
            }
        }

        private void rendezvous_Click(object sender, EventArgs e)
        {
            using(RendezVousForm child =new RendezVousForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void medicSchedule_Click(object sender, EventArgs e)
        {
            using (UpdatingPatient child = new UpdatingPatient())
            {
                child.ShowDialog();
            }
        }

        private void tips_Click(object sender, EventArgs e)
        {
            using(InformationForm child = new InformationForm())
            {
                child.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void InterfaceSecretaire_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry1 = "SELECT Nom FROM Utilisateur WHERE UserID=" + this.ID;
            string querry2 = "SELECT * FROM Horaire;";
            string querry3 = "SELECT * FROM RendezVous ;";

            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(querry1, this.GateWay);
                SqlDataAdapter da2 = new SqlDataAdapter(querry2, this.GateWay);
                SqlDataAdapter da3 = new SqlDataAdapter(querry3, this.GateWay);

                DataTable myTable1 = new DataTable();
                DataTable myTable2 = new DataTable();
                DataTable myTable3 = new DataTable();

                da1.Fill(myTable1);
                da2.Fill(myTable2);
                da3.Fill(myTable3);

                grid.DataSource = myTable1;

                horaireGrid.DataSource = myTable2;
                horaireGrid.Columns[0].Visible = false;

                rdvGrid.DataSource = myTable3;
               
                for(int i=1;i<=2;i++) rdvGrid.Columns[i].Visible = false;

                welcomeLabel.Text = string.Format("Bienvenue {0}", grid.Rows[0].Cells[0].Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}