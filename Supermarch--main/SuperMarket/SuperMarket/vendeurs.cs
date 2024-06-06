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
    public partial class vendeurs : Form
    {

        Functions Con;
        public vendeurs()
        {
            InitializeComponent();
            Con = new Functions();
            ListerVendeurs();

        }

        private void ListerVendeurs()
        {
            string Req = "Select * from VendeursTbl";
            VendeursListe.DataSource = Con.RecupererDonnees(Req);
        }

        private void vendeurs_Load(object sender, EventArgs e)
        {

        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PseudoTb.Text == "" || MotDePasseTb.Text == "" || AdresseTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PseudoTb.Text;
                    string MPasse = MotDePasseTb.Text;
                    string Phone = PhoneTb.Text;
                    string Add = AdresseTb.Text;
                    

                    
                    
                    string Req = "insert into VendeursTbl values ('{0}', '{1}','{2}','{3}','{4}'')";
                    Req = String.Format(Req, Nom, Pseudo, MPasse, Phone, Add);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Ajoutée !!");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        int Key = 0;
        private void VendeursListe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NomTb.Text = VendeursListe.SelectedRows[0].Cells[1].Value.ToString();
            PseudoTb.Text = VendeursListe.SelectedRows[0].Cells[2].Value.ToString();
            MotDePasseTb.Text = VendeursListe.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = VendeursListe.SelectedRows[0].Cells[4].Value.ToString();
            AdresseTb.Text = VendeursListe.SelectedRows[0].Cells[5].Value.ToString();
            //tockTb.Text = ArticlesListe.SelectedRows[0].Cells[4].Value.ToString();
            if (NomTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(VendeursListe.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void SupprimerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Selectionnez un Vendeur Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PseudoTb.Text;
                    string MPasse = MotDePasseTb.Text;
                    string Phone = PhoneTb.Text;
                    string Add = AdresseTb.Text;




                    string Req = "delete from VendeursTbl where VendCode =  {0})";
                    Req = String.Format(Req, Nom, Pseudo, MPasse, Phone, Add);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur Supprimé !!");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (NomTb.Text == "" || PseudoTb.Text == "" || MotDePasseTb.Text == "" || AdresseTb.Text == "")
                {
                    MessageBox.Show("Completer Le Formulaire Svp !!!");
                }
                else
                {
                    string Nom = NomTb.Text;
                    string Pseudo = PseudoTb.Text;
                    string MPasse = MotDePasseTb.Text;
                    string Phone = PhoneTb.Text;
                    string Add = AdresseTb.Text;




                    string Req = "update VendeursTbl set VendNom = '{0}', VendPseudo = '{1}', VendPass'{2}', VendPhone = '{3}', VendAdd'{4}' where VendCode = {5}')";
                    Req = String.Format(Req, Nom, Pseudo, MPasse, Phone, Add, Key);
                    Con.EnvoyerDonnees(Req);
                    ListerVendeurs();
                    MessageBox.Show("Vendeur modifié !!");
                    NomTb.Text = "";
                    PseudoTb.Text = "";
                    MotDePasseTb.Text = "";
                    AdresseTb.Text = "";


                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeconLbl_Click(object sender, EventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Hide();
        }
    }
}




