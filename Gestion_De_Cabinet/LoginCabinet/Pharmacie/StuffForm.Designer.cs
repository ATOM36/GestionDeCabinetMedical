
namespace Cabinet.Pharmacie
{
    partial class StuffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StuffForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.createCat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.catName = new System.Windows.Forms.TextBox();
            this.catLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.qteEntry = new System.Windows.Forms.TextBox();
            this.priceEntry = new System.Windows.Forms.TextBox();
            this.catEntry = new System.Windows.Forms.TextBox();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.catBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(24, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 60);
            this.button3.TabIndex = 58;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // createCat
            // 
            this.createCat.BackColor = System.Drawing.Color.ForestGreen;
            this.createCat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createCat.ForeColor = System.Drawing.Color.White;
            this.createCat.Location = new System.Drawing.Point(1084, 442);
            this.createCat.Name = "createCat";
            this.createCat.Size = new System.Drawing.Size(160, 60);
            this.createCat.TabIndex = 57;
            this.createCat.Text = "Créer catégorie";
            this.createCat.UseVisualStyleBackColor = false;
            this.createCat.Visible = false;
            this.createCat.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(465, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 56;
            this.button1.Text = "Ajouter le produit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(598, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // catName
            // 
            this.catName.Location = new System.Drawing.Point(1026, 375);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(267, 29);
            this.catName.TabIndex = 54;
            this.catName.Visible = false;
            // 
            // catLabel
            // 
            this.catLabel.AutoSize = true;
            this.catLabel.Location = new System.Drawing.Point(1026, 350);
            this.catLabel.Name = "catLabel";
            this.catLabel.Size = new System.Drawing.Size(49, 22);
            this.catLabel.TabIndex = 53;
            this.catLabel.Text = "Nom";
            this.catLabel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(107, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "Liste des catégories";
            // 
            // qteEntry
            // 
            this.qteEntry.Location = new System.Drawing.Point(408, 516);
            this.qteEntry.Name = "qteEntry";
            this.qteEntry.Size = new System.Drawing.Size(267, 29);
            this.qteEntry.TabIndex = 50;
            // 
            // priceEntry
            // 
            this.priceEntry.Location = new System.Drawing.Point(408, 442);
            this.priceEntry.Name = "priceEntry";
            this.priceEntry.Size = new System.Drawing.Size(267, 29);
            this.priceEntry.TabIndex = 49;
            // 
            // catEntry
            // 
            this.catEntry.Location = new System.Drawing.Point(408, 375);
            this.catEntry.Name = "catEntry";
            this.catEntry.Size = new System.Drawing.Size(267, 29);
            this.catEntry.TabIndex = 48;
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(408, 305);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(267, 29);
            this.nameEntry.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 45;
            this.label5.Text = "Quantité en stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Prix unitaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 43;
            this.label3.Text = "Catégorie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nom";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 28);
            this.label10.TabIndex = 1;
            this.label10.Text = "Health Care";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 28);
            this.label9.TabIndex = 0;
            this.label9.Text = "Health Care";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(1091, 20);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(142, 26);
            this.timeLabel.TabIndex = 20;
            this.timeLabel.Text = "DD:MM:YY";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(605, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ajout de produits";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(-2, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 69);
            this.panel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 69);
            this.panel1.TabIndex = 40;
            // 
            // catBox
            // 
            this.catBox.FormattingEnabled = true;
            this.catBox.Location = new System.Drawing.Point(107, 304);
            this.catBox.Name = "catBox";
            this.catBox.Size = new System.Drawing.Size(256, 30);
            this.catBox.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(770, 590);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 60);
            this.button2.TabIndex = 60;
            this.button2.Text = "Introuvable ? Créer une catégorie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // StuffForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.catBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.createCat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.catLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qteEntry);
            this.Controls.Add(this.priceEntry);
            this.Controls.Add(this.catEntry);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "StuffForm";
            this.Text = "NewStuffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StuffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button createCat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.Label catLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox qteEntry;
        private System.Windows.Forms.TextBox priceEntry;
        private System.Windows.Forms.TextBox catEntry;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox catBox;
        private System.Windows.Forms.Button button2;
    }
}