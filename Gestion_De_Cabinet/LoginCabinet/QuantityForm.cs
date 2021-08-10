using System;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Cabinet
{
    public partial class QuantityForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        int catID;
        string prodID;
        public QuantityForm()
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

        private void prodGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            this.prodID = string.Format("{0]", ((DataGridView)sender).Rows[index].Cells[0].Value);
            nameEntry.Text = this.prodID;
            catEntry.Text = string.Format("{0]", ((DataGridView)sender).Rows[index].Cells[1].Value);
            priceEntry.Text = string.Format("{0]", ((DataGridView)sender).Rows[index].Cells[2].Value);
            qteEntry.Text = string.Format("{0]", ((DataGridView)sender).Rows[index].Cells[3].Value);
        }

        private void QuantityForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            string querry1 = "SELECT * FROM Produit";
            string querry2 = "SELECT * FROM Categorie;";

            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(querry1, this.GateWay);
                SqlDataAdapter da2 = new SqlDataAdapter(querry2, this.GateWay);

                DataTable myTable1 = new DataTable(); 
                DataTable myTable2 = new DataTable();

                da1.Fill(myTable1);
                da2.Fill(myTable2);

                prodGrid.DataSource = myTable1;
                gridCat.DataSource = myTable2;
                gridCat.Columns[0].Visible = false;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Categorie SET NomCategorie='" + catName.Text + "' WHERE CategorieId=" + this.catID + ";";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "UPDATE Produit SET Nom='" + nameEntry.Text + "',Categorie='" + catEntry.Text + "' ,Prix_Unitaire=" + float.Parse(priceEntry.Text) + ",Quantite=" + int.Parse(qteEntry.Text) + ";";
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

        private void gridCat_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                this.catID = (int)((DataGridView)sender).Rows[index].Cells[0].Value;
                catName.Text = string.Format("{0]", ((DataGridView)sender).Rows[index].Cells[1].Value);
        }
    }
}