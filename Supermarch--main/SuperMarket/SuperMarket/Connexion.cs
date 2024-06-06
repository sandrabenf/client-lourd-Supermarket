

using System;
using System.Data;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class Connexion : Form
    {
        Functions Con;

        public Connexion()
        {
            InitializeComponent();
            Con = new Functions(); // Initialisez la variable membre Con ici
        }

        public static int UserId;
        public static string UserName;

        private void ConBtn_Click(object sender, EventArgs e)
        {
            if (NomTb.Text == "" || MPasseTb.Text == "")
            {
                MessageBox.Show("Entrez les informations Complètes !!");
            }
            else if (NomTb.Text == "sa123" && MPasseTb.Text == "sa123")
            {
                Articles Obj = new Articles();
                Obj.Show();
                this.Hide();
            }
            else
            {
                string Req = "Select * from VendeursTbl where  VendPseudo = '{0}' and  VendPass = '{1}'";
                Req = string.Format(Req, NomTb.Text, MPasseTb.Text);
                DataTable dt = Con.RecupererDonnees(Req);
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Vendeurs Inexistant !!");
                }
                else
                {
                    UserName = dt.Rows[0][2].ToString();
                    UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Factures Obj = new Factures();
                    Obj.Show();
                    this.Hide();
                }
            }
        }
    }
}
