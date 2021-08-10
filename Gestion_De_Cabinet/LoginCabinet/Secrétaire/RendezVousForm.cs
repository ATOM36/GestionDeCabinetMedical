using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Cabinet.Secrétaire
{
    public partial class RendezVousForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public int ID;
        public string idDoc, idPatient;

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public RendezVousForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using(RegistrationForm child = new RegistrationForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void RendezVousForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string docQuerry = "SELECT Nom,Prenom,UserID FROM Utilisateur WHERE Statut='Docteur';";
            string patientQuerry = "SELECT NomPatient,PrenomPatient,PatientID FROM Patient;";
            
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(docQuerry, this.GateWay);
                SqlDataAdapter da2 = new SqlDataAdapter(patientQuerry, this.GateWay);

                DataTable docTable = new DataTable();
                DataTable patientTable = new DataTable();

                da1.Fill(docTable);
                da2.Fill(patientTable);

                gridDoctor.DataSource = docTable;
                gridDoctor.Columns[2].Visible = false;

                gridPatient.DataSource = patientTable;
                gridPatient.Columns[2].Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = "INSERT INTO RendezVous VALUES(" + int.Parse(docID.Text) + "," + int.Parse(patientID.Text) + "," +
                    datePicker.Value.ToShortDateString() + "," + timePicker.Value.ToShortTimeString() + ");";

                SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération effectuée avec succès");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void gridDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridDoctor.ReadOnly = true;
        }

        private void gridPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPatient.ReadOnly = true;
        }

        private void gridPatient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPatient.ReadOnly = true;
            int index = e.RowIndex;
            nameEntry.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
            firstNameEntry.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[1].Value);
            patientID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
        }

        private void gridDoctor_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridDoctor.ReadOnly = true;
            int index = e.RowIndex;
            docID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
        }
    }
}