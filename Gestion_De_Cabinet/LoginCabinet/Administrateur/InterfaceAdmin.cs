using System;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cabinet.Administrateur
{
    public partial class InterfaceAdmin : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);

        public int ID;
        int panelWidth;
        bool isCollapsed;
        public InterfaceAdmin(int token)
        {
            InitializeComponent();
            panelWidth = optionPanel.Width;
            this.GateWay.Open();
            isCollapsed = false;
            this.Visible = false;
            this.ID = token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddingUserForm child = new AddingUserForm())
            {
                child.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using(UpdatingUserForm child = new UpdatingUserForm())
            {
                child.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                optionPanel.Width = panelWidth + 10;
                if (optionPanel.Width >= panelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                optionPanel.Width = optionPanel.Width - 10;
                if (optionPanel.Width <= 18)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.GateWay.Close();
                timer2.Stop();
                this.Dispose();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(RemovingUserForm child = new RemovingUserForm())
            {
                child.ShowDialog();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void InterfaceAdmin_Load(object sender, EventArgs e)
        {
            timer2.Start();
            string querry1 = "SELECT Nom FROM Utilisateur WHERE UserID=" + this.ID;
            string querry2 = "SELECT * FROM Utilisateur;";
            string querry3 = "SELECT * FROM Patient;";
            try
            {
                SqlDataAdapter da1 = new SqlDataAdapter(querry1, this.GateWay);
                SqlDataAdapter da2 = new SqlDataAdapter(querry2, this.GateWay);
                SqlDataAdapter da3 = new SqlDataAdapter(querry3, this.GateWay);

                DataTable myTable1 = new DataTable();
                DataTable myTable2 = new DataTable();
                DataTable myTable3 = new DataTable();

                da1.Fill(myTable1);
                da2.Fill(myTable2);
                da3.Fill(myTable3);

                gridName.DataSource = myTable1;
                userGrid.DataSource = myTable2;
                patientGrid.DataSource = myTable3;
                welcomeLabel.Text = string.Format("Bienvenue {0}", gridName.Rows[0].Cells[0].Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}