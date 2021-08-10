using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cabinet.Docteur
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private void Open_File()
        {
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.DereferenceLinks = true;
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files|*.*";
            openFileDialog1.Multiselect = false;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ValidateNames = true;
            openFileDialog1.Title = "Rapports d'analyse";

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Open_File();
        }
    }
}
