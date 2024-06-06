/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Factures : Form
    {
        Functions Con;
        public Factures()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            VendeurLbl.Text = Connexion.UserName;
            
        }


        private void ListerArticles()
        {
            try
            {
                string Req = "Select ArtCode as Code, ArtPrix, as Prix, CatNom as Categories, ArtStock as Stock from ArticlesTbl join CategorieTbl on ArticlesTbl.ArtCat = CCategorieTblatCode";
                FactureListe.DataSource = Con.RecupererDonnees(Req);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void DeconLbl_Click(object sender, EventArgs e)
        {
            Connexion Con = new Connexion();
            Con.Show();
            this.Hide();
        }

        int Key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = FactureListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = FactureListe.SelectedRows[0].Cells[2].Value.ToString();
            //CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = FactureListe.SelectedRows[0].Cells[4].Value.ToString();

            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FactureListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ReinitialiserBtn_Click(object sender, EventArgs e)
        {
            NomTb.Text = "";
            PrixTb.Text = "";
            StockTb.Text = "";
            QuantiteTb.Text = "";

        }
        private void ModifierStock()
        {

            int Stock = Convert.ToInt32(StockTb.Text);
            int NewStock = Stock - Convert.ToInt32(QuantiteTb.Text);

            string Req = "update ArticlesTbl set ArtStock = {0} where ArtCode = {1}";
            Req = String.Format(Req, NewStock, Key);
            Con.EnvoyerDonnes(Req);
            ListerArticles();

        }
        int n = 0;
        int GrdTotal = 0;
        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (Prix.Text == "" || QuantiteTb.Text == "" || StockTb.Text == "" || NomTb.Text == "")
            {
                MessageBox.Show("Information Manquante !!");
            } else
            {
                if (Convert.ToInt32(QuantiteTb.Text) > Convert.ToInt32(StockTb.Text))
                {
                    MessageBox.Show("Stock Non Disponible !!");
                }
                else
                {
                    int total = Convert.ToInt32(QuantiteTb.Text) * Convert.ToInt32(PrixTb.Text);
                    DataGridViewRow Ligne = new DataGridViewRow();
                    Ligne.CreateCells(FactureListe);
                    Ligne.Cells[0].Value = new + 1;
                    Ligne.Cells[1].Value = NomTb.Text;
                    Ligne.Cells[2].Value = QuantiteTb.Text;
                    Ligne.Cells[3].Value = PrixTb.Text;
                    Ligne.Cells[4].Value = total;
                    GrdTotal = GrdTotal + total;
                    FactureListe.Rows.Add(Ligne);
                    PrixTotalLbl.Text = GrdTotal + "$";
                    ModifierStock();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    QuantiteTb.Text = "";
                    n++;
                }
            }
        }

        private void InsererFacture()
        {

            

            try
            {
                int Vendeur = Connexion.UserId;
                MessageBox.Show("" + Vendeur)
                string Req = "insert into FacturesTbl values ('{0}', '{1},{2})";
                Req = String.Format(Req, DateTime.Today.Date.ToString(), Vendeur, GrdTotal);
                Con.EnvoyerDonnes(Req);
                ListerArticles();
                MessageBox.Show("Facture Ajoutée !!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
  
            
        }

        private void ImprimerBtn_Click(object sender, EventArgs e)
        {
            InsererFacture();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600)
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


        int ACode, APrix, AQty, ATotal;

        string ANom;
        int pos = 60;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Notre SuperMarche", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in FactureListe.Rows)
            {
            }
            ACode = Convert.ToInt32(Row.Cells["Column1"].Value);
            ANom = "" + row.Cells["Column2"].Value;
            APrix = Convert.ToInt32(Row.Cells["Column3"].Value);
            AQty = Convert.ToInt32(Row.Cells["Column4"].Value);
            ATotal = Convert.ToInt32(Row.Cells["Column5"].Value);


            e.Graphics.DrawString('', + ACode, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26,pos));
            e.Graphics.DrawString('', + ANom, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
            e.Graphics.DrawString('', + APrix, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
            e.Graphics.DrawString('', + AQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
            e.Graphics.DrawString('', + ATotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
            pos = pos + 20;


            e.Graphics.DrawString("Grand Total" + GrdTotal + "$", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50 ));
            e.Graphics.DrawString("*********SMarche********", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            FactureListe.Rows.Clear();
            FactureListe.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
            PrixTotalLbl.Text = "";
        }
    }
}
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Factures : Form
    {
        Functions Con;
        public Factures()
        {
            InitializeComponent();
            Con = new Functions();
            ListerArticles();
            VendeurLbl.Text = Connexion.UserName;
        }

        private void ListerArticles()
        {
            try
            {
                string Req = "Select ArtCode as Code, ArtPrix as Prix, CatNom as Categories, ArtStock as Stock from ArticlesTbl join CategorieTbl on ArticlesTbl.ArtCat = CategorieTbl.CatCode";
                FactureListe.DataSource = Con.RecupererDonnees(Req);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeconLbl_Click(object sender, EventArgs e)
        {
            Connexion Con = new Connexion();
            Con.Show();
            this.Hide();
        }

        int Key = 0;
        private void ArticlesListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = FactureListe.SelectedRows[0].Cells[1].Value.ToString();
            PrixTb.Text = FactureListe.SelectedRows[0].Cells[2].Value.ToString();
            //CatCb.Text = ArticlesListe.SelectedRows[0].Cells[3].Value.ToString();
            StockTb.Text = FactureListe.SelectedRows[0].Cells[4].Value.ToString();

            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FactureListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ReinitialiserBtn_Click(object sender, EventArgs e)
        {
            NomTb.Text = "";
            PrixTb.Text = "";
            StockTb.Text = "";
            QuantiteTb.Text = "";
        }

        private void ModifierStock()
        {
            int Stock = Convert.ToInt32(StockTb.Text);
            int NewStock = Stock - Convert.ToInt32(QuantiteTb.Text);

            string Req = "update ArticlesTbl set ArtStock = {0} where ArtCode = {1}";
            Req = String.Format(Req, NewStock, Key);
            Con.EnvoyerDonnees(Req);
            ListerArticles();
        }

        int n = 0;
        int GrdTotal = 0;
        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            if (Prix.Text == "" || QuantiteTb.Text == "" || StockTb.Text == "" || NomTb.Text == "")
            {
                MessageBox.Show("Information Manquante !!");
            }
            else
            {
                if (Convert.ToInt32(QuantiteTb.Text) > Convert.ToInt32(StockTb.Text))
                {
                    MessageBox.Show("Stock Non Disponible !!");
                }
                else
                {
                    int total = Convert.ToInt32(QuantiteTb.Text) * Convert.ToInt32(PrixTb.Text);
                    DataGridViewRow Ligne = new DataGridViewRow();
                    Ligne.CreateCells(FactureListe);
                    Ligne.Cells[0].Value = n + 1;
                    Ligne.Cells[1].Value = NomTb.Text;
                    Ligne.Cells[2].Value = QuantiteTb.Text;
                    Ligne.Cells[3].Value = PrixTb.Text;
                    Ligne.Cells[4].Value = total;
                    GrdTotal = GrdTotal + total;
                    FactureListe.Rows.Add(Ligne);
                    PrixTotalLbl.Text = GrdTotal + "$";
                    ModifierStock();
                    NomTb.Text = "";
                    PrixTb.Text = "";
                    StockTb.Text = "";
                    QuantiteTb.Text = "";
                    n++;
                }
            }
        }

        private void InsererFacture()
        {
            try
            {
                int Vendeur = Connexion.UserId;
                MessageBox.Show("" + Vendeur);
                string Req = "insert into FacturesTbl values ('{0}', '{1}', {2})";
                Req = String.Format(Req, DateTime.Today.Date.ToString(), Vendeur, GrdTotal);
                Con.EnvoyerDonnees(Req);
                ListerArticles();
                MessageBox.Show("Facture Ajoutée !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImprimerBtn_Click(object sender, EventArgs e)
        {
            InsererFacture();
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int ACode, APrix, AQty, ATotal;
        string ANom;
        int pos = 60;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Notre SuperMarche", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach (DataGridViewRow row in FactureListe.Rows)
            {
                ACode = Convert.ToInt32(row.Cells["Column1"].Value);
                ANom = "" + row.Cells["Column2"].Value;
                APrix = Convert.ToInt32(row.Cells["Column3"].Value);
                AQty = Convert.ToInt32(row.Cells["Column4"].Value);
                ATotal = Convert.ToInt32(row.Cells["Column5"].Value);

                e.Graphics.DrawString("" + ACode, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + ANom, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString("" + APrix, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + AQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + ATotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                pos = pos + 20;
            }

            e.Graphics.DrawString("Grand Total: " + GrdTotal + "$", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
            e.Graphics.DrawString("*********SMarche********", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
            FactureListe.Rows.Clear();
            FactureListe.Refresh();
            pos = 100;
            GrdTotal = 0;
            n = 0;
            PrixTotalLbl.Text = "";
        }
    }
}
