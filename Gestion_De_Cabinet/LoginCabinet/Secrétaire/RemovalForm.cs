using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cabinet.Secrétaire
{
    public partial class RemovalForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public RemovalForm()
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
        }

        private void abortionButton_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void removalButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = "DELETE FROM RendezVous WHERE RendezVousID=" + int.Parse(rdvID.Text);
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

        private void RemovalForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry = "SELECT RendezVousID,DateRendezVous, Nom, NomPatient FROM RendezVous R, Utilisateur U,Patient P " +
                "WHERE R.DocteurID=U.UserID AND R.PatientID=P.PatientID ;";

            SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
            DataTable myTable = new DataTable();
            da.Fill(myTable);
            rdvGrid.DataSource = myTable;
            rdvGrid.Columns[0].Visible = false;
        }

        private void rdvGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            rdvID.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
            textBox1.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[1].Value);
            patientName.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
            docName.Text = string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[3].Value);
        }
    }
}