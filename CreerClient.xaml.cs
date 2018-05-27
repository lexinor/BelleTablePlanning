using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BelleTablePlanning
{
    /// <summary>
    /// Logique d'interaction pour CreerClient.xaml
    /// </summary>
    public partial class CreerClient : Window
    {
        BddCo Bdd = new BddCo("localhost", "root", "");
        public CreerClient()
        {
            InitializeComponent();
            string structureSql = "SELECT Libelle FROM structures ORDER BY Libelle;";
            Bdd.RemplirLeComboBox(structureBox, structureSql, "Libelle");
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.PortefeuilleClients();
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Nom = nomText.Text;
            string Prenom = prenomText.Text;
            string Mail = mailText.Text;
            string Adresse = new TextRange(adresseText.Document.ContentStart, adresseText.Document.ContentEnd).Text;
            string Telephone = telephoneText.Text;
            string Structure = structureBox.Text;

            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(Nom) || string.IsNullOrWhiteSpace(Prenom) || string.IsNullOrWhiteSpace(Mail) || string.IsNullOrWhiteSpace(Adresse) || string.IsNullOrWhiteSpace(Telephone) || string.IsNullOrWhiteSpace(Structure))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur !");
            }
            else
            {
                // Détermination du type de structure selon le libellé
                int IDTypeStructure;
                if (Structure == "Organisme")
                {
                    IDTypeStructure = 1;
                }
                else if (Structure == "Organisation")
                {
                    IDTypeStructure = 2;
                }
                else if (Structure == "Société")
                {
                    IDTypeStructure = 3;
                }
                else if (Structure == "Particulier")
                {
                    IDTypeStructure = 4;
                }
                else
                {
                    IDTypeStructure = 0; // Else de backup. Il ne devrait jamais arriver.
                }
                if (Bdd.CreationNouveauClient(Nom, Prenom, Mail, Adresse, Telephone, IDTypeStructure))
                {
                    MessageBox.Show("Le nouvel interlocuteur " + Prenom + " " + Nom + " a été créé avec succès !", "Succès !");
                    this.Close();
                    var window = new BelleTablePlanning.PortefeuilleClients();
                    window.Show();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue lors de la création du nouvel interlocteur. Le mail doit certainement déjà être pris.", "Erreur.");
                }
            }
        }
    }
}
