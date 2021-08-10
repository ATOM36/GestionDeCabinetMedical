using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cabinet.Docteur
{
    public partial class ScheduleForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public DateTime time = new DateTime();
        public int ID, index;
        public ScheduleForm(int token)
        {
            InitializeComponent();
            this.GateWay.Open();
            this.Visible = false;
            time = DateTime.Today;
            timeLabel.Text = time.ToLongDateString();
            this.ID = token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GateWay.Close();
            timer1.Stop();
            this.Dispose();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            string querry = "SELECT * FROM Horaire WHERE UserID=" + this.ID + ";";
            SqlCommand cmd = new SqlCommand(querry, this.GateWay);
            try
            {
                SqlDataAdapter rd = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                rd.Fill(myTable);
                grid.DataSource = myTable;

                for (int i = 0; i <= 4; i++) grid.Columns[i].Visible = false;
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

        private void grid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.index = e.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string querry = "UPDATE Horaire SET Date_RDV='" + grid.Rows[this.index].Cells[5].Value.ToString() + "';";
                SqlCommand cmd = new SqlCommand(querry, this.GateWay);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Opération effectuée avec succès");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }
    }
}
