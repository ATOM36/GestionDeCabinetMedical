using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cabinet.Pharmacie
{
    public partial class StuffForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        int catID;
        string prodID;
        public StuffForm()
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void StuffForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry = "SELECT * FROM Categorie;";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);

                catBox.DataSource = myTable;
                catBox.DisplayMember = "NomCategorie";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            catEntry.Text = catBox.Text;
            DialogResult result = MessageBox.Show("Confirmer","", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                string querry = string.Format("INSERT INTO Produit VALUES('{0}','{1}',{2},{3});", nameEntry.Text, catEntry.Text, priceEntry.Text, qteEntry.Text);
                try
                {
                    SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operation effectuée avec succès");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = "INSERT INTO Categorie VALUES('" + catName.Text + "') ;";
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            catLabel.Visible = true;
            catName.Visible = true;
            createCat.Visible = true;
        }
    }
}