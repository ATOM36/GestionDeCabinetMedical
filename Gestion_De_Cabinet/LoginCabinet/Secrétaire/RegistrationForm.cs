using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cabinet.Secrétaire
{
    
    public partial class RegistrationForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";


        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public int secretaryID;
        public RegistrationForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
            this.secretaryID = token;
        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Dispose();
        }

        private void confirmRegistration_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = string.Format("INSERT INTO Patient VALUES({0},{1},'{2}','{3}',{4},{5},'{6}','{7}');",
                    int.Parse(docID.Text), this.secretaryID, lastNameEntry.Text, firstNameEntry.Text,
                    int.Parse(ageEntry.Text), float.Parse(weightEntry.Text), causesEntry.Text, dateEntry.Text);

                try
                {
                    SqlCommand cmd = new SqlCommand(querry, this.GateWay);
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

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry = "SELECT UserID,Nom,Prenom,Specialite FROM Horaire";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                gridDoc.DataSource = myTable;
                gridDoc.Columns[0].Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            docID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
        }
    }
}
