using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Cabinet.Administrateur
{
    public partial class AddingUserForm : Form
    {
        public static string strconnexion = @"Data Source=ATOM\SQLEXPRESS;Initial Catalog=GestionDeCabinet;
                                        Integrated Security=true;";

        public SqlConnection GateWay = new SqlConnection(strconnexion);
        public AddingUserForm()
        {
            InitializeComponent();
            this.Visible = false;
            this.GateWay.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.GateWay.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirmer", "", MessageBoxButtons.OKCancel,
               MessageBoxIcon.Question);
            if(result==DialogResult.OK)
            { 
                string querry = string.Format("INSERT INTO Utilisateur VALUES('{0}','{1}','{2}','{3}','{4}');", userNameEntry.Text,
                                codeEntry.Text, nameEntry.Text, firstNameEntry.Text, statusEntry.Text);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();
        }

        private void AddingUserForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
