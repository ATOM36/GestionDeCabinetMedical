using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Secrétaire
{
    public partial class UpdatingPatient : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public UpdatingPatient()
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void confirmRegistration_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = string.Format("UPDATE Patient SET NomPatient='{0}',PrenomPatient='{1}',Age={2}," +
                  "Poids={3},CauseAdmission='{4}',DateAdmission='{5}',DocteurID={6},SecretaireID={7} WHERE PatientID={8}",
                  lastNameEntry.Text, firstNameEntry.Text, int.Parse(ageEntry.Text), float.Parse(weightEntry.Text),
                  causesEntry.Text, dateEntry.Text, int.Parse(docID.Text), int.Parse(secretaryID.Text),
                  int.Parse(idEntry.Text));
                try
                {
                    SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération effectuée avec succès!");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Patient WHERE PatientID=" + int.Parse(idEntry.Text);
            SqlCommand cmd = new SqlCommand(querry, this.GateWay);
           
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd != null)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(rd);
                    rd.Close();

                    DataRow dr = myTable.Rows[0];
                    firstNameEntry.Text = (string)dr["NomPatient"];
                    lastNameEntry.Text = (string)dr["PrenomPatient"];
                    ageEntry.Text = string.Format("{0}",dr["Age"]);
                    weightEntry.Text = string.Format("{0}",dr["Poids"]);
                    causesEntry.Text = (string)dr["CauseAdmission"];
                    dateEntry.Text = (string)dr["DateAdmission"];
                    docID.Text = string.Format("{0}", dr["DocteurID"]);
                    secretaryID.Text = string.Format("{0}", dr["SecretaireID"]);
                }
                else MessageBox.Show("Identifiant inexistant");
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void UpdatingPatient_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry = "SELECT * FROM Patient;";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                grid.DataSource = myTable;

                for (int i = 0; i <= 2; i++) grid.Columns[i].Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            idEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
            docID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[1].Value);
            secretaryID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
            lastNameEntry.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[3].Value);
            firstNameEntry.Text=string.Format("{0}",((DataGridView)sender).Rows[index].Cells[4].Value);
            ageEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[5].Value);
            weightEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[6].Value);
            causesEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[7].Value);
            dateEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[8].Value);
        }
    }
}