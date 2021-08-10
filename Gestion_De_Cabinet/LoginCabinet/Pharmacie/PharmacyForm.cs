using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cabinet.Pharmacie
{
    public partial class PharmacyForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        int ID;
        public PharmacyForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.ID = token;
            this.Visible = false;
        }

        private void PharmacyForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry1 = "SELECT NomCategorie  FROM Categorie;";
            string querry2 = "SELECT Nom FROM Utilisateur WHERE UserID=" + this.ID;

            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(querry1, this.GateWay);
                SqlDataAdapter da2 = new SqlDataAdapter(querry2, this.GateWay);

                DataTable myTable1 = new DataTable();
                DataTable myTable2 = new DataTable();

                da1.Fill(myTable1);
                da2.Fill(myTable2);

                catList.DataSource = myTable1;
                dataGridView1.DataSource = myTable2;
                catList.DisplayMember = "NomCategorie";
                welcomeLabel.Text = "Bienvenue "+dataGridView1.Rows[0].Cells[0].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            using(Cabinet.QuantityForm child = new Cabinet.QuantityForm())
            {
                child.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "SELECT * FROM Produit WHERE Categorie = '" + textBox1.Text + "';";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                prodGrid.DataSource = myTable;
                this.Refresh();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            using(StuffForm child = new StuffForm())
            {
                child.ShowDialog();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = catList.Text;

            string querry = "SELECT * FROM Produit WHERE Categorie='" + textBox1.Text + "';";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                prodGrid.DataSource = myTable;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
