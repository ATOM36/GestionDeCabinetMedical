
namespace Cabinet
{
    partial class QuantityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.prodGrid = new System.Windows.Forms.DataGridView();
            this.nameEntry = new System.Windows.Forms.TextBox();
            this.catEntry = new System.Windows.Forms.TextBox();
            this.priceEntry = new System.Windows.Forms.TextBox();
            this.qteEntry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.catName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gridCat = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 69);
            this.panel1.TabIndex = 21;
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
            this.label11.Location = new System.Drawing.Point(584, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 27);
            this.label11.TabIndex = 2;
            this.label11.Text = "Mise à jour des produits";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(114, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Liste des produits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 24;
            this.label3.Text = "Catégorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 485);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantité en stock";
            // 
            // prodGrid
            // 
            this.prodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodGrid.Location = new System.Drawing.Point(37, 274);
            this.prodGrid.Name = "prodGrid";
            this.prodGrid.ReadOnly = true;
            this.prodGrid.RowTemplate.Height = 25;
            this.prodGrid.Size = new System.Drawing.Size(338, 303);
            this.prodGrid.TabIndex = 27;
            this.prodGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodGrid_CellContentDoubleClick);
            // 
            // nameEntry
            // 
            this.nameEntry.Location = new System.Drawing.Point(412, 299);
            this.nameEntry.Name = "nameEntry";
            this.nameEntry.Size = new System.Drawing.Size(267, 29);
            this.nameEntry.TabIndex = 28;
            // 
            // catEntry
            // 
            this.catEntry.Location = new System.Drawing.Point(412, 369);
            this.catEntry.Name = "catEntry";
            this.catEntry.Size = new System.Drawing.Size(267, 29);
            this.catEntry.TabIndex = 29;
            // 
            // priceEntry
            // 
            this.priceEntry.Location = new System.Drawing.Point(412, 436);
            this.priceEntry.Name = "priceEntry";
            this.priceEntry.Size = new System.Drawing.Size(267, 29);
            this.priceEntry.TabIndex = 30;
            // 
            // qteEntry
            // 
            this.qteEntry.Location = new System.Drawing.Point(412, 510);
            this.qteEntry.Name = "qteEntry";
            this.qteEntry.Size = new System.Drawing.Size(267, 29);
            this.qteEntry.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(814, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Liste des catégories";
            // 
            // catName
            // 
            this.catName.Location = new System.Drawing.Point(1030, 369);
            this.catName.Name = "catName";
            this.catName.Size = new System.Drawing.Size(267, 29);
            this.catName.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1030, 344);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "Nom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(471, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 37;
            this.button1.Text = "Mettre à jour le produit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1088, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 60);
            this.button2.TabIndex = 38;
            this.button2.Text = "Mettre à jour la catégorie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Firebrick;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(28, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 60);
            this.button3.TabIndex = 39;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gridCat
            // 
            this.gridCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCat.Location = new System.Drawing.Point(802, 274);
            this.gridCat.Name = "gridCat";
            this.gridCat.ReadOnly = true;
            this.gridCat.RowTemplate.Height = 25;
            this.gridCat.Size = new System.Drawing.Size(207, 303);
            this.gridCat.TabIndex = 40;
            this.gridCat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCat_CellContentDoubleClick);
            // 
            // QuantityForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.gridCat);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.catName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.qteEntry);
            this.Controls.Add(this.priceEntry);
            this.Controls.Add(this.catEntry);
            this.Controls.Add(this.nameEntry);
            this.Controls.Add(this.prodGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "QuantityForm";
            this.Text = "QuantityForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuantityForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView prodGrid;
        private System.Windows.Forms.TextBox nameEntry;
        private System.Windows.Forms.TextBox catEntry;
        private System.Windows.Forms.TextBox priceEntry;
        private System.Windows.Forms.TextBox qteEntry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox catName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView gridCat;
    }
}