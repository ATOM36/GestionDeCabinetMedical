
namespace Cabinet.Administrateur
{
    partial class UpdatingUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatingUserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codeEntry = new System.Windows.Forms.TextBox();
            this.userNameEntry = new System.Windows.Forms.TextBox();
            this.firstNameEntry = new System.Windows.Forms.TextBox();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.idEntry = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grid = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 83);
            this.panel1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(1090, 31);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(142, 26);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "DD:MM:YY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(454, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mise à jour des informations d\'un utilisateur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health Care";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(510, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 51);
            this.button1.TabIndex = 24;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeEntry
            // 
            this.codeEntry.Location = new System.Drawing.Point(426, 505);
            this.codeEntry.Name = "codeEntry";
            this.codeEntry.Size = new System.Drawing.Size(301, 29);
            this.codeEntry.TabIndex = 23;
            // 
            // userNameEntry
            // 
            this.userNameEntry.Location = new System.Drawing.Point(426, 431);
            this.userNameEntry.Name = "userNameEntry";
            this.userNameEntry.Size = new System.Drawing.Size(301, 29);
            this.userNameEntry.TabIndex = 22;
            // 
            // firstNameEntry
            // 
            this.firstNameEntry.Location = new System.Drawing.Point(426, 362);
            this.firstNameEntry.Name = "firstNameEntry";
            this.firstNameEntry.Size = new System.Drawing.Size(301, 29);
            this.firstNameEntry.TabIndex = 20;
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(426, 291);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(301, 29);
            this.nameEntry.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(426, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mot de passe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(426, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "UserName";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(426, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(426, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(416, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(506, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ecrire (*) si rien n\'est à modifier dans un champ donné";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(529, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Informations à mettre à jour";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(827, 585);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 51);
            this.button2.TabIndex = 40;
            this.button2.Text = "Annuler";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Identifiant de l\'utilisateur";
            // 
            // idEntry
            // 
            this.idEntry.Location = new System.Drawing.Point(740, 199);
            this.idEntry.Name = "idEntry";
            this.idEntry.Size = new System.Drawing.Size(301, 29);
            this.idEntry.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(809, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 51);
            this.button3.TabIndex = 43;
            this.button3.Text = "Chercher";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 173);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 25;
            this.grid.Size = new System.Drawing.Size(335, 458);
            this.grid.TabIndex = 49;
            this.grid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentDoubleClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(83, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 22);
            this.label14.TabIndex = 48;
            this.label14.Text = "Liste des utilisateurs";
            // 
            // UpdatingUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.idEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.codeEntry);
            this.Controls.Add(this.userNameEntry);
            this.Controls.Add(this.firstNameEntry);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UpdatingUserForm";
            this.Text = "UpdatingUserForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdatingUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeEntry;
        private System.Windows.Forms.TextBox userNameEntry;
        private System.Windows.Forms.TextBox firstNameEntry;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idEntry;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label14;
    }
}