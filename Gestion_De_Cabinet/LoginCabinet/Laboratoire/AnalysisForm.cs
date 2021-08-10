using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Cabinet.Laboratoire
{
    public partial class AnalysisForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public int ID;

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public AnalysisForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
            this.ID = token;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void RendezVousForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string patientQuerry = "SELECT PatientID,DocteurID,NomPatient,PrenomPatient FROM Patient;";
            
            try
            {
                SqlDataAdapter da2 = new SqlDataAdapter(patientQuerry, this.GateWay);
                DataTable patientTable = new DataTable();
                da2.Fill(patientTable);

                gridPatient.DataSource = patientTable;
                for (int i = 0; i <= 1; i++) gridPatient.Columns[i].Visible = false;
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
                string querry = "INSERT INTO Echantillon VALUES(" + int.Parse(docID.Text) + "," + int.Parse(patientID.Text) + "," +
                    datePicker.Value.ToShortDateString() + ";";

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

        private void gridPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPatient.ReadOnly = true;
        }

        private void gridPatient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPatient.ReadOnly = true;
            int index = e.RowIndex;
            patientID.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
            docID.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[1].Value);
            nameEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
            firstNameEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[3].Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }
    }
}