
namespace Cabinet.Secrétaire
{
    partial class RemovalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovalForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdvID = new System.Windows.Forms.TextBox();
            this.patientName = new System.Windows.Forms.TextBox();
            this.docName = new System.Windows.Forms.TextBox();
            this.removalButton = new System.Windows.Forms.Button();
            this.abortionButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rdvGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdvGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(852, 283);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(497, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Identifiant du rendez-vous";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(497, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nom du patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(497, 397);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom du docteur";
            // 
            // rdvID
            // 
            this.rdvID.BackColor = System.Drawing.Color.White;
            this.rdvID.Location = new System.Drawing.Point(497, 254);
            this.rdvID.Margin = new System.Windows.Forms.Padding(4);
            this.rdvID.Name = "rdvID";
            this.rdvID.PasswordChar = '*';
            this.rdvID.ReadOnly = true;
            this.rdvID.Size = new System.Drawing.Size(269, 26);
            this.rdvID.TabIndex = 5;
            this.rdvID.UseSystemPasswordChar = true;
            // 
            // patientName
            // 
            this.patientName.Location = new System.Drawing.Point(497, 332);
            this.patientName.Margin = new System.Windows.Forms.Padding(4);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(269, 26);
            this.patientName.TabIndex = 7;
            // 
            // docName
            // 
            this.docName.Location = new System.Drawing.Point(497, 420);
            this.docName.Margin = new System.Windows.Forms.Padding(4);
            this.docName.Name = "docName";
            this.docName.Size = new System.Drawing.Size(269, 26);
            this.docName.TabIndex = 8;
            // 
            // removalButton
            // 
            this.removalButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.removalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removalButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.removalButton.ForeColor = System.Drawing.Color.White;
            this.removalButton.Location = new System.Drawing.Point(539, 593);
            this.removalButton.Margin = new System.Windows.Forms.Padding(4);
            this.removalButton.Name = "removalButton";
            this.removalButton.Size = new System.Drawing.Size(193, 56);
            this.removalButton.TabIndex = 9;
            this.removalButton.Text = "Supprimer";
            this.removalButton.UseVisualStyleBackColor = false;
            this.removalButton.Click += new System.EventHandler(this.removalButton_Click);
            // 
            // abortionButton
            // 
            this.abortionButton.BackColor = System.Drawing.Color.Crimson;
            this.abortionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.abortionButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abortionButton.ForeColor = System.Drawing.Color.White;
            this.abortionButton.Location = new System.Drawing.Point(860, 593);
            this.abortionButton.Margin = new System.Windows.Forms.Padding(4);
            this.abortionButton.Name = "abortionButton";
            this.abortionButton.Size = new System.Drawing.Size(193, 56);
            this.abortionButton.TabIndex = 10;
            this.abortionButton.Text = "Annuler";
            this.abortionButton.UseVisualStyleBackColor = false;
            this.abortionButton.Click += new System.EventHandler(this.abortionButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 69);
            this.panel1.TabIndex = 11;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1114, 21);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(142, 26);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "DD:MM:YY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(552, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Annulation d\'un rendez-vous";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 67);
            this.panel2.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(33, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Health Care";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(497, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(386, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Informations relatives au rendez-vous";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rdvGrid
            // 
            this.rdvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdvGrid.Location = new System.Drawing.Point(37, 302);
            this.rdvGrid.Name = "rdvGrid";
            this.rdvGrid.ReadOnly = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdvGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rdvGrid.RowTemplate.Height = 25;
            this.rdvGrid.Size = new System.Drawing.Size(340, 233);
            this.rdvGrid.TabIndex = 14;
            this.rdvGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rdvGrid_CellContentDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(37, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Liste des rendez-vous";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(497, 483);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Date du rendez-vous";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(497, 506);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 26);
            this.textBox1.TabIndex = 17;
            // 
            // RemovalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 720);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rdvGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.abortionButton);
            this.Controls.Add(this.removalButton);
            this.Controls.Add(this.docName);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.rdvID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemovalForm";
            this.Text = "RemovalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RemovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdvGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rdvID;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.TextBox docName;
        private System.Windows.Forms.Button removalButton;
        private System.Windows.Forms.Button abortionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView rdvGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}