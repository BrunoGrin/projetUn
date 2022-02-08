using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetUn
{
    public partial class Windows : Form
    {
        public Windows()
        {
            InitializeComponent();
        }

        private void Connexion_Click(object sender, EventArgs e)
        {
            try
            {
                string MyConnection = "SERVER=localhost;DATABASE=mysql;USER=root;PASSWORD=root;";
                MySqlConnection connection = new MySqlConnection(MyConnection);

                if (Connexion.Text== "Déconnecter")
                {
                    connection.Close();
                    Connexion.Text = "Connecter";
                    MessageBox.Show("Déconnecter de la base de donnée");
                }
                else
                {
                    connection.Open();
                    Connexion.Text = "Déconnecter";
                    MessageBox.Show("Connecter à la base de donnée");
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
