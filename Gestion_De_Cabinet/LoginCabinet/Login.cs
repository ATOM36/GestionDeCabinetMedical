using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Cabinet.Secrétaire;
using Cabinet.Administrateur;
using Cabinet.Docteur;
using Cabinet.Laboratoire;
using Cabinet.Pharmacie;

namespace Cabinet
{
    public partial class Login : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public Login()
        {
            InitializeComponent();
            this.GateWay.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(nameEntry.Text=="Secretaire")
            {
                using (InterfaceSecretaire child = new InterfaceSecretaire(50))
                {
                    child.ShowDialog();
                }
            }
            else if(nameEntry.Text=="Docteur")
            {
                using (InterfaceDocteur child = new InterfaceDocteur(43))
                {
                    child.ShowDialog();
                }
            }
            else if(nameEntry.Text=="Admin")

            {
                using(InterfaceAdmin child = new InterfaceAdmin(57))
                {
                    child.ShowDialog();
                }
            }
            else if(nameEntry.Text=="Pharma")
            {
                using(PharmacyForm child = new PharmacyForm(64))
                {
                    child.ShowDialog();
                }
            }
            else if(nameEntry.Text=="Labo")
            {
                using(LaboForm child = new LaboForm(71))
                {
                    child.ShowDialog();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                timer2.Stop();
                this.GateWay.Close();
                timer1.Start();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allez ! Fais un effort pour t'en rappeler!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0) this.Opacity -= 0.05;
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}