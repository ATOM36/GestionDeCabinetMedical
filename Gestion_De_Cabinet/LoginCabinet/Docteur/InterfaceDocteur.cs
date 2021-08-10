using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Cabinet.Docteur
{
    public partial class InterfaceDocteur : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);

        int panelWidth;
        bool isCollapsed;
        public int ID;
        public InterfaceDocteur(int token)
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
            panelWidth = optionPanel.Width;
            isCollapsed = false;
            this.ID = token;
        }

        private void logOutButton_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isCollapsed)
            {
                optionPanel.Width = panelWidth + 10;
                if(optionPanel.Width>=panelWidth)
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

        private void button4_Click(object sender, EventArgs e)
        {
            using(PharmacyStock child = new PharmacyStock())
            {
                child.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(ListPatientForm child = new ListPatientForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (ScheduleForm child = new ScheduleForm(this.ID))
            {
                child.ShowDialog();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void InterfaceDocteur_Load_1(object sender, EventArgs e)
        {
            timer2.Start();
            string querry1 = "SELECT Nom FROM Utilisateur WHERE UserID=" + this.ID;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry1, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                grid.DataSource = myTable;
                welcomeLabel.Text = string.Format("Bienvenue {0}", grid.Rows[0].Cells[0].Value);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            string querry = "SELECT * FROM RendezVous WHERE DocteurID=" + this.ID + ";";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(querry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                gridConsult.DataSource = myTable;

                for(int i=1;i<=2;i++) gridConsult.Columns[i].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            string timeQuerry = "SELECT * FROM Horaire WHERE UserID=" + this.ID;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(timeQuerry, this.GateWay);
                DataTable myTable = new DataTable();
                da.Fill(myTable);
                timeGrid.DataSource = myTable;

                for (int i = 0; i <= 3; i++) timeGrid.Columns[i].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void optionPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}