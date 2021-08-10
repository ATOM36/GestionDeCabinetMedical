using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Docteur
{
    public partial class ListPatientForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public int ID;
        public ListPatientForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
            this.ID = token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void ListPatientForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry = "SELECT * FROM Patient WHERE DocteurID=" + this.ID + ";";
            try
            {
                SqlDataAdapter rd = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                rd.Fill(myTable);
                grid.DataSource = myTable;
                grid.Columns[0].Visible = false;
                grid.Columns[1].Visible = false;
                grid.Columns[2].Visible = false;
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

        private void button2_Click(object sender, EventArgs e)
        {
            using(ResultForm child = new ResultForm())
            {
                child.ShowDialog();
            }
        }
    }
}