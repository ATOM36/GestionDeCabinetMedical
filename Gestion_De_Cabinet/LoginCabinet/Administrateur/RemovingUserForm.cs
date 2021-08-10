using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cabinet.Administrateur
{
    public partial class RemovingUserForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public RemovingUserForm()
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = "DELETE FROM Utilisateur WHERE UserID=" + int.Parse(textBox1.Text);
                try
                {
                    SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération effectuée avec succès !");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.GateWay.Close();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void userGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            textBox1.Text =string.Format("{0}", ((DataGridView)sender).Rows[index].Cells[0].Value);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RemovingUserForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry = "SELECT * FROM Utilisateur;";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                userGrid.DataSource = myTable;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}