namespace SuperMarket
{
    partial class Factures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factures));
            this.QuantiteTb = new System.Windows.Forms.TextBox();
            this.NomTb = new System.Windows.Forms.TextBox();
            this.FacturationLbl = new System.Windows.Forms.Label();
            this.AdresseTb = new System.Windows.Forms.TextBox();
            this.Prix = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DeconLbl = new System.Windows.Forms.Label();
            this.CategoriesLbl = new System.Windows.Forms.Label();
            this.PrixTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VendeurLbl = new System.Windows.Forms.Label();
            this.Téléphone = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FactureListe = new System.Windows.Forms.DataGridView();
            this.ModifierBtn = new System.Windows.Forms.Button();
            this.ImprimerBtn = new System.Windows.Forms.Button();
            this.ReinitialiserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ArticlesLbl = new System.Windows.Forms.Label();
            this.superMarcheBDDataSet1 = new SuperMarket.SuperMarcheBDDataSet();
            this.StockTb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrixTotalLbl = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactureListe)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuantiteTb
            // 
            this.QuantiteTb.Location = new System.Drawing.Point(620, 198);
            this.QuantiteTb.Margin = new System.Windows.Forms.Padding(4);
            this.QuantiteTb.Name = "QuantiteTb";
            this.QuantiteTb.Size = new System.Drawing.Size(227, 22);
            this.QuantiteTb.TabIndex = 77;
            // 
            // NomTb
            // 
            this.NomTb.Location = new System.Drawing.Point(279, 173);
            this.NomTb.Margin = new System.Windows.Forms.Padding(4);
            this.NomTb.Name = "NomTb";
            this.NomTb.Size = new System.Drawing.Size(227, 22);
            this.NomTb.TabIndex = 75;
            // 
            // FacturationLbl
            // 
            this.FacturationLbl.AutoSize = true;
            this.FacturationLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturationLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FacturationLbl.Location = new System.Drawing.Point(60, 353);
            this.FacturationLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FacturationLbl.Name = "FacturationLbl";
            this.FacturationLbl.Size = new System.Drawing.Size(126, 27);
            this.FacturationLbl.TabIndex = 12;
            this.FacturationLbl.Text = "Facturation";
            // 
            // AdresseTb
            // 
            this.AdresseTb.Enabled = false;
            this.AdresseTb.Location = new System.Drawing.Point(620, 278);
            this.AdresseTb.Margin = new System.Windows.Forms.Padding(4);
            this.AdresseTb.Name = "AdresseTb";
            this.AdresseTb.Size = new System.Drawing.Size(227, 22);
            this.AdresseTb.TabIndex = 74;
            // 
            // Prix
            // 
            this.Prix.AutoSize = true;
            this.Prix.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Prix.Location = new System.Drawing.Point(288, 225);
            this.Prix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(51, 27);
            this.Prix.TabIndex = 73;
            this.Prix.Text = "Prix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(1459, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 27);
            this.label5.TabIndex = 72;
            this.label5.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(591, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 27);
            this.label3.TabIndex = 63;
            this.label3.Text = "Quantité";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1336, 74);
            this.panel2.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(829, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de Facturation";
            // 
            // DeconLbl
            // 
            this.DeconLbl.AutoSize = true;
            this.DeconLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeconLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.DeconLbl.Location = new System.Drawing.Point(25, 615);
            this.DeconLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeconLbl.Name = "DeconLbl";
            this.DeconLbl.Size = new System.Drawing.Size(145, 27);
            this.DeconLbl.TabIndex = 13;
            this.DeconLbl.Text = "Deconnexion";
            this.DeconLbl.Click += new System.EventHandler(this.DeconLbl_Click);
            // 
            // CategoriesLbl
            // 
            this.CategoriesLbl.AutoSize = true;
            this.CategoriesLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriesLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CategoriesLbl.Location = new System.Drawing.Point(60, 198);
            this.CategoriesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CategoriesLbl.Name = "CategoriesLbl";
            this.CategoriesLbl.Size = new System.Drawing.Size(119, 27);
            this.CategoriesLbl.TabIndex = 10;
            this.CategoriesLbl.Text = "Catégories";
            // 
            // PrixTb
            // 
            this.PrixTb.Enabled = false;
            this.PrixTb.Location = new System.Drawing.Point(279, 278);
            this.PrixTb.Margin = new System.Windows.Forms.Padding(4);
            this.PrixTb.Name = "PrixTb";
            this.PrixTb.Size = new System.Drawing.Size(271, 22);
            this.PrixTb.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(340, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 27);
            this.label2.TabIndex = 65;
            this.label2.Text = "Pseudo";
            // 
            // VendeurLbl
            // 
            this.VendeurLbl.AutoSize = true;
            this.VendeurLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendeurLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.VendeurLbl.Location = new System.Drawing.Point(60, 273);
            this.VendeurLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VendeurLbl.Name = "VendeurLbl";
            this.VendeurLbl.Size = new System.Drawing.Size(107, 27);
            this.VendeurLbl.TabIndex = 9;
            this.VendeurLbl.Text = "Vendeurs";
            // 
            // Téléphone
            // 
            this.Téléphone.AutoSize = true;
            this.Téléphone.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Téléphone.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Téléphone.Location = new System.Drawing.Point(274, 125);
            this.Téléphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Téléphone.Name = "Téléphone";
            this.Téléphone.Size = new System.Drawing.Size(77, 27);
            this.Téléphone.TabIndex = 76;
            this.Téléphone.Text = "Article";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(1411, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 27);
            this.label7.TabIndex = 71;
            this.label7.Text = "Facture du client";
            // 
            // FactureListe
            // 
            this.FactureListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FactureListe.Location = new System.Drawing.Point(293, 422);
            this.FactureListe.Margin = new System.Windows.Forms.Padding(4);
            this.FactureListe.Name = "FactureListe";
            this.FactureListe.RowHeadersWidth = 51;
            this.FactureListe.RowTemplate.Height = 24;
            this.FactureListe.Size = new System.Drawing.Size(600, 358);
            this.FactureListe.TabIndex = 70;
            this.FactureListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ArticlesListe_CellContentClick);
            // 
            // ModifierBtn
            // 
            this.ModifierBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ModifierBtn.FlatAppearance.BorderSize = 0;
            this.ModifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifierBtn.Location = new System.Drawing.Point(327, 353);
            this.ModifierBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ModifierBtn.Name = "ModifierBtn";
            this.ModifierBtn.Size = new System.Drawing.Size(223, 43);
            this.ModifierBtn.TabIndex = 69;
            this.ModifierBtn.Text = "Ajouter A La Facture";
            this.ModifierBtn.UseVisualStyleBackColor = false;
            this.ModifierBtn.Click += new System.EventHandler(this.ModifierBtn_Click);
            // 
            // ImprimerBtn
            // 
            this.ImprimerBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ImprimerBtn.FlatAppearance.BorderSize = 0;
            this.ImprimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImprimerBtn.Location = new System.Drawing.Point(1367, 720);
            this.ImprimerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ImprimerBtn.Name = "ImprimerBtn";
            this.ImprimerBtn.Size = new System.Drawing.Size(223, 43);
            this.ImprimerBtn.TabIndex = 68;
            this.ImprimerBtn.Text = "Imprimer";
            this.ImprimerBtn.UseVisualStyleBackColor = false;
            this.ImprimerBtn.Click += new System.EventHandler(this.ImprimerBtn_Click);
            // 
            // ReinitialiserBtn
            // 
            this.ReinitialiserBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.ReinitialiserBtn.FlatAppearance.BorderSize = 0;
            this.ReinitialiserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReinitialiserBtn.Location = new System.Drawing.Point(624, 353);
            this.ReinitialiserBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReinitialiserBtn.Name = "ReinitialiserBtn";
            this.ReinitialiserBtn.Size = new System.Drawing.Size(223, 43);
            this.ReinitialiserBtn.TabIndex = 67;
            this.ReinitialiserBtn.Text = "Reinitialiser";
            this.ReinitialiserBtn.UseVisualStyleBackColor = false;
            this.ReinitialiserBtn.Click += new System.EventHandler(this.ReinitialiserBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.DeconLbl);
            this.panel1.Controls.Add(this.FacturationLbl);
            this.panel1.Controls.Add(this.CategoriesLbl);
            this.panel1.Controls.Add(this.VendeurLbl);
            this.panel1.Controls.Add(this.ArticlesLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 870);
            this.panel1.TabIndex = 61;
            // 
            // ArticlesLbl
            // 
            this.ArticlesLbl.AutoSize = true;
            this.ArticlesLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArticlesLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ArticlesLbl.Location = new System.Drawing.Point(60, 122);
            this.ArticlesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArticlesLbl.Name = "ArticlesLbl";
            this.ArticlesLbl.Size = new System.Drawing.Size(87, 27);
            this.ArticlesLbl.TabIndex = 8;
            this.ArticlesLbl.Text = "Articles";
            // 
            // superMarcheBDDataSet1
            // 
            this.superMarcheBDDataSet1.DataSetName = "SuperMarcheBDDataSet";
            this.superMarcheBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StockTb
            // 
            this.StockTb.AutoSize = true;
            this.StockTb.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockTb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.StockTb.Location = new System.Drawing.Point(591, 247);
            this.StockTb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StockTb.Name = "StockTb";
            this.StockTb.Size = new System.Drawing.Size(67, 27);
            this.StockTb.TabIndex = 78;
            this.StockTb.Text = "Stock";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(1074, 289);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 358);
            this.dataGridView1.TabIndex = 79;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Article";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // PrixTotalLbl
            // 
            this.PrixTotalLbl.AutoSize = true;
            this.PrixTotalLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixTotalLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.PrixTotalLbl.Location = new System.Drawing.Point(1459, 670);
            this.PrixTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrixTotalLbl.Name = "PrixTotalLbl";
            this.PrixTotalLbl.Size = new System.Drawing.Size(64, 27);
            this.PrixTotalLbl.TabIndex = 80;
            this.PrixTotalLbl.Text = "Total";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1603, 870);
            this.Controls.Add(this.PrixTotalLbl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StockTb);
            this.Controls.Add(this.QuantiteTb);
            this.Controls.Add(this.NomTb);
            this.Controls.Add(this.AdresseTb);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PrixTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Téléphone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FactureListe);
            this.Controls.Add(this.ModifierBtn);
            this.Controls.Add(this.ImprimerBtn);
            this.Controls.Add(this.ReinitialiserBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Factures";
            this.Text = "Factures";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FactureListe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.superMarcheBDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuantiteTb;
        private System.Windows.Forms.TextBox NomTb;
        private System.Windows.Forms.Label FacturationLbl;
        private System.Windows.Forms.TextBox AdresseTb;
        private System.Windows.Forms.Label Prix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeconLbl;
        private System.Windows.Forms.Label CategoriesLbl;
        private System.Windows.Forms.TextBox PrixTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label VendeurLbl;
        private System.Windows.Forms.Label Téléphone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView FactureListe;
        private System.Windows.Forms.Button ModifierBtn;
        private System.Windows.Forms.Button ImprimerBtn;
        private System.Windows.Forms.Button ReinitialiserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ArticlesLbl;
        private SuperMarcheBDDataSet superMarcheBDDataSet1;
        private System.Windows.Forms.Label StockTb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label PrixTotalLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}