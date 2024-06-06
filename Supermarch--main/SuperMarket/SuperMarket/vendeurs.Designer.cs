namespace SuperMarket
{
    partial class vendeurs
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
            this.superMarcheBDDataSet1 = new SuperMarket.SuperMarcheBDDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.VendeursListe = new System.Windows.Forms.DataGridView();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.SupprimerBtn = new System.Windows.Forms.Button();
            this.EnregistrerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeconLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MotDePasseTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdresseTb = new System.Windows.Forms.TextBox();
            this.PseudoTb = new System.Windows.Forms.TextBox();
            this.Téléphone = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // superMarcheBDDataSet1
            // 
            this.superMarcheBDDataSet1.DataSetName = "SuperMarcheBDDataSet";
            this.superMarcheBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(622, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion des Vendeurs";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Location = new System.Drawing.Point(45, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 22);
            this.label12.TabIndex = 12;
            this.label12.Text = "Facturation";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(717, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 52;
            this.label7.Text = "Liste des Vendeurs";
            // 
            // VendeursListe
            // 
            this.VendeursListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VendeursListe.Location = new System.Drawing.Point(238, 347);
            this.VendeursListe.Name = "VendeursListe";
            this.VendeursListe.RowHeadersWidth = 51;
            this.VendeursListe.RowTemplate.Height = 24;
            this.VendeursListe.Size = new System.Drawing.Size(1178, 291);
            this.VendeursListe.TabIndex = 51;
            this.VendeursListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VendeursListe_CellContentClick);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Location = new System.Drawing.Point(394, 250);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(167, 35);
            this.ModifierBtn.TabIndex = 50;
            this.ModifierBtn.Text = "Modifier";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // SupprimerBtn
            // 
            this.SupprimerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.SupprimerBtn.FlatAppearance.BorderSize = 0;
            this.SupprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupprimerBtn.Location = new System.Drawing.Point(892, 250);
            this.SupprimerBtn.Name = "SupprimerBtn";
            this.SupprimerBtn.Size = new System.Drawing.Size(167, 35);
            this.SupprimerBtn.TabIndex = 49;
            this.SupprimerBtn.Text = "Supprimer";
            this.SupprimerBtn.UseVisualStyleBackColor = false;
            this.SupprimerBtn.Click += new System.EventHandler(this.SupprimerBtn_Click);
            // 
            // EnregistrerBtn
            // 
            this.EnregistrerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.EnregistrerBtn.FlatAppearance.BorderSize = 0;
            this.EnregistrerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnregistrerBtn.Location = new System.Drawing.Point(626, 250);
            this.EnregistrerBtn.Name = "EnregistrerBtn";
            this.EnregistrerBtn.Size = new System.Drawing.Size(167, 35);
            this.EnregistrerBtn.TabIndex = 48;
            this.EnregistrerBtn.Text = "Enregistrer";
            this.EnregistrerBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.DeconLbl);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 647);
            this.panel1.TabIndex = 42;
            // 
            // DeconLbl
            // 
            this.DeconLbl.AutoSize = true;
            this.DeconLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeconLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeconLbl.Location = new System.Drawing.Point(19, 500);
            this.DeconLbl.Name = "DeconLbl";
            this.DeconLbl.Size = new System.Drawing.Size(115, 22);
            this.DeconLbl.TabIndex = 13;
            this.DeconLbl.Text = "Deconnexion";
            this.DeconLbl.Click += new System.EventHandler(this.DeconLbl_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label10.Location = new System.Drawing.Point(45, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 10;
            this.label10.Text = "Catégories";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(45, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 9;
            this.label9.Text = "Vendeurs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(45, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 22);
            this.label8.TabIndex = 8;
            this.label8.Text = "Articles";
            // 
            // MotDePasseTb
            // 
            this.MotDePasseTb.Location = new System.Drawing.Point(743, 159);
            this.MotDePasseTb.Name = "MotDePasseTb";
            this.MotDePasseTb.Size = new System.Drawing.Size(204, 20);
            this.MotDePasseTb.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(563, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 46;
            this.label2.Text = "Pseudo";
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(281, 159);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(171, 20);
            this.NomTb.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(277, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 44;
            this.label3.Text = "Nom du Vendeur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1202, 60);
            this.panel2.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(985, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 54;
            this.label5.Text = "Adresse";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(726, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 22);
            this.label6.TabIndex = 55;
            this.label6.Text = "Mot de Passe";
            // 
            // AdresseTb
            // 
            this.AdresseTb.Location = new System.Drawing.Point(976, 162);
            this.AdresseTb.Name = "AdresseTb";
            this.AdresseTb.Size = new System.Drawing.Size(171, 20);
            this.AdresseTb.TabIndex = 57;
            // 
            // PseudoTb
            // 
            this.PseudoTb.Location = new System.Drawing.Point(516, 162);
            this.PseudoTb.Name = "PseudoTb";
            this.PseudoTb.Size = new System.Drawing.Size(171, 20);
            this.PseudoTb.TabIndex = 58;
            // 
            // Téléphone
            // 
            this.Téléphone.AutoSize = true;
            this.Téléphone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Téléphone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Téléphone.Location = new System.Drawing.Point(514, 195);
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.Size = new System.Drawing.Size(119, 22);
            this.Téléphone.TabIndex = 59;
            this.Téléphone.Text = "Mot de Passe";
            this.Téléphone.Click += new System.EventHandler(this.label4_Click);
            // 
            // PhoneTb
            // 
            this.PhoneTb.Location = new System.Drawing.Point(700, 198);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(204, 20);
            this.PhoneTb.TabIndex = 60;
            this.PhoneTb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // vendeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 707);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.Téléphone);
            this.Controls.Add(this.PseudoTb);
            this.Controls.Add(this.AdresseTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.VendeursListe);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.SupprimerBtn);
            this.Controls.Add(this.EnregistrerBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MotDePasseTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vendeurs";
            this.Text = "vendeurs";
            this.Load += new System.EventHandler(this.vendeurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendeursListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperMarcheBDDataSet superMarcheBDDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView VendeursListe;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button SupprimerBtn;
        private System.Windows.Forms.Button EnregistrerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DeconLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox MotDePasseTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdresseTb;
        private System.Windows.Forms.TextBox PseudoTb;
        private System.Windows.Forms.Label Téléphone;
        private System.Windows.Forms.TextBox PhoneTb;
    }
}