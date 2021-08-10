using System;
using System.Windows.Forms;

namespace Cabinet.Secrétaire
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
            this.Visible = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString();
        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}