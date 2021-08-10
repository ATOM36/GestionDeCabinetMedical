using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Administrateur
{
    public partial class UpdatingUserForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public UpdatingUserForm()
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
        }

        private void UpdatingUserForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry = "SELECT * FROM Utilisateur;";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                grid.DataSource = myTable;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Utilisateur WHERE UserID=" + int.Parse(idEntry.Text);
            SqlCommand cmd = new SqlCommand(querry, this.GateWay);

            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                if(rd != null)
                {
                    DataTable myTable = new DataTable();
                    myTable.Load(rd);
                    rd.Close();


                    DataRow dr = myTable.Rows[0];
                    firstNameEntry.Text =(string)dr["Nom"];
                    nameEntry.Text = (string)dr["Prenom"];
                    codeEntry.Text = (string)dr["CodeSecurite"];
                    userNameEntry.Text = (string)dr["UserName"];
                }
                else MessageBox.Show("Identifiant inexistant");
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
                string querry = "UPDATE Utilisateur SET UserName='" + userNameEntry.Text + "',Nom='" + nameEntry.Text +
                    "',Prenom='" + firstNameEntry.Text + "',CodeSecurite='" + codeEntry.Text + "' WHERE UserID=" +
                    int.Parse(idEntry.Text) + ";";
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            idEntry.Text=string.Format("{0}",((DataGridView)sender).Rows[index].Cells[0].Value);
            userNameEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[1].Value);
            codeEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[2].Value);
            nameEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[3].Value);
            firstNameEntry.Text= string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[4].Value);
        }
    }
}