using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Laboratoire
{
    public partial class LaboForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public int ID;

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public LaboForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
            this.ID = token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AnalysisForm child = new AnalysisForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void LaboForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry1 = "SELECT Nom FROM Utilisateur WHERE UserID=" + this.ID + ";";
            string querry2 = "SELECT * FROM Echantillon WHERE Statut='En cours' AND EchantillonID="+this.ID+";";
            string querry3 = "SELECT * FROM Echantillon WHERE Statut='Pret' AND EchantillonID=" + this.ID + ";";

            try
            {
                SqlCommand cmd = new SqlCommand(querry1, this.GateWay);
                SqlDataReader rd = cmd.ExecuteReader();
                welcomeLabel.Text = string.Format("Bienvenue {0}",rd["Nom"]);
                rd.Close();

                SqlDataAdapter da2 = new SqlDataAdapter(querry2, this.GateWay);
                SqlDataAdapter da3 = new SqlDataAdapter(querry3, this.GateWay);

                DataTable myTable2 = new DataTable();
                DataTable myTable3 = new DataTable();

                da2.Fill(myTable2);
                da3.Fill(myTable3);

                engagedGrid.DataSource = myTable2;
                doneGrid.DataSource = myTable3;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void engagedGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            ((DataGridView)sender).Rows[index].Cells[5].Value = "Pret";
            this.Refresh();
        }
    }
}
