
namespace Cabinet.Secrétaire
{
    partial class InterfaceSecretaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceSecretaire));
            this.rendezvous = new System.Windows.Forms.Button();
            this.cancelMeeting = new System.Windows.Forms.Button();
            this.medicSchedule = new System.Windows.Forms.Button();
            this.tips = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.newPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.logOutButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdvGrid = new System.Windows.Forms.DataGridView();
            this.horaireGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaireGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // rendezvous
            // 
            this.rendezvous.BackColor = System.Drawing.Color.White;
            this.rendezvous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rendezvous.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rendezvous.FlatAppearance.BorderSize = 0;
            this.rendezvous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rendezvous.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rendezvous.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.rendezvous.Location = new System.Drawing.Point(28, 64);
            this.rendezvous.Name = "rendezvous";
            this.rendezvous.Size = new System.Drawing.Size(214, 80);
            this.rendezvous.TabIndex = 1;
            this.rendezvous.Text = "Prendre rendez-vous";
            this.rendezvous.UseVisualStyleBackColor = false;
            this.rendezvous.Click += new System.EventHandler(this.rendezvous_Click);
            // 
            // cancelMeeting
            // 
            this.cancelMeeting.BackColor = System.Drawing.Color.White;
            this.cancelMeeting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelMeeting.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelMeeting.ForeColor = System.Drawing.Color.Crimson;
            this.cancelMeeting.Location = new System.Drawing.Point(493, 66);
            this.cancelMeeting.Name = "cancelMeeting";
            this.cancelMeeting.Size = new System.Drawing.Size(200, 78);
            this.cancelMeeting.TabIndex = 2;
            this.cancelMeeting.Text = "Annulez rendez-vous";
            this.cancelMeeting.UseVisualStyleBackColor = false;
            this.cancelMeeting.Click += new System.EventHandler(this.cancelMeeting_Click);
            // 
            // medicSchedule
            // 
            this.medicSchedule.BackColor = System.Drawing.Color.White;
            this.medicSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.medicSchedule.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medicSchedule.Location = new System.Drawing.Point(711, 68);
            this.medicSchedule.Name = "medicSchedule";
            this.medicSchedule.Size = new System.Drawing.Size(200, 76);
            this.medicSchedule.TabIndex = 3;
            this.medicSchedule.Text = "Mettre à jour les informations d\'un patient";
            this.medicSchedule.UseVisualStyleBackColor = false;
            this.medicSchedule.Click += new System.EventHandler(this.medicSchedule_Click);
            // 
            // tips
            // 
            this.tips.BackColor = System.Drawing.Color.White;
            this.tips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tips.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tips.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.tips.Location = new System.Drawing.Point(941, 66);
            this.tips.Name = "tips";
            this.tips.Size = new System.Drawing.Size(220, 78);
            this.tips.TabIndex = 4;
            this.tips.Text = "Informations sur le cabinet";
            this.tips.UseVisualStyleBackColor = false;
            this.tips.Click += new System.EventHandler(this.tips_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(595, 443);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(230, 26);
            this.welcomeLabel.TabIndex = 5;
            this.welcomeLabel.Text = "Bienvenue Secrétaire";
            // 
            // newPatient
            // 
            this.newPatient.BackColor = System.Drawing.Color.White;
            this.newPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newPatient.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newPatient.ForeColor = System.Drawing.Color.SeaGreen;
            this.newPatient.Location = new System.Drawing.Point(265, 67);
            this.newPatient.Name = "newPatient";
            this.newPatient.Size = new System.Drawing.Size(204, 77);
            this.newPatient.TabIndex = 6;
            this.newPatient.Text = "Ajouter un patient";
            this.newPatient.UseVisualStyleBackColor = false;
            this.newPatient.Click += new System.EventHandler(this.newPatient_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1354, 69);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 69);
            this.panel2.TabIndex = 8;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1115, 22);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(146, 26);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "HH:MM:YY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(641, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Espace secrétaire";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(210, 69);
            this.panel7.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(39, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Health Care";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Health Care";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(562, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Espace secrétaire";
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 76);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(1322, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 76);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(240, 68);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 55);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Crimson;
            this.panel6.Location = new System.Drawing.Point(462, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(32, 54);
            this.panel6.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(691, 68);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(22, 54);
            this.panel8.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel9.Location = new System.Drawing.Point(910, 68);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(34, 54);
            this.panel9.TabIndex = 13;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(1160, 68);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(29, 55);
            this.panel10.TabIndex = 14;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.White;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.logOutButton.Location = new System.Drawing.Point(1187, 68);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(139, 76);
            this.logOutButton.TabIndex = 15;
            this.logOutButton.Text = "Déconnexion";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(606, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 207);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(302, 201);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(35, 33);
            this.grid.TabIndex = 17;
            this.grid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 506);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Liste des rendez-vous";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(872, 531);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(297, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Horaire du personnel soignant";
            // 
            // rdvGrid
            // 
            this.rdvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rdvGrid.Location = new System.Drawing.Point(114, 546);
            this.rdvGrid.Name = "rdvGrid";
            this.rdvGrid.ReadOnly = true;
            this.rdvGrid.RowTemplate.Height = 25;
            this.rdvGrid.Size = new System.Drawing.Size(240, 191);
            this.rdvGrid.TabIndex = 20;
            // 
            // horaireGrid
            // 
            this.horaireGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horaireGrid.Location = new System.Drawing.Point(872, 559);
            this.horaireGrid.Name = "horaireGrid";
            this.horaireGrid.RowTemplate.Height = 25;
            this.horaireGrid.Size = new System.Drawing.Size(401, 178);
            this.horaireGrid.TabIndex = 21;
            // 
            // InterfaceSecretaire
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 749);
            this.Controls.Add(this.horaireGrid);
            this.Controls.Add(this.rdvGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.newPatient);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.tips);
            this.Controls.Add(this.medicSchedule);
            this.Controls.Add(this.cancelMeeting);
            this.Controls.Add(this.rendezvous);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "InterfaceSecretaire";
            this.Text = "Secretaire";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InterfaceSecretaire_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdvGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaireGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button rendezvous;
        private System.Windows.Forms.Button cancelMeeting;
        private System.Windows.Forms.Button medicSchedule;
        private System.Windows.Forms.Button tips;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button newPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView rdvGrid;
        private System.Windows.Forms.DataGridView horaireGrid;
    }
}