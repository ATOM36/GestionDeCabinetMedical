using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Docteur
{
    public partial class PharmacyStock : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public PharmacyStock()
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void PharmacyStock_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry = "SELECT * FROM Produit;";
            SqlCommand cmd = new SqlCommand(querry, this.GateWay);
            try
            {
                SqlDataAdapter rd = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                rd.Fill(myTable);
                grid.DataSource = myTable;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }
    }
}
