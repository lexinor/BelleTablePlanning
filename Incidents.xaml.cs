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
    /// Logique d'interaction pour Incidents.xaml
    /// </summary>
    public partial class Incidents : Window
    {
        public Incidents()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(objetIncident.Text) || string.IsNullOrWhiteSpace(messageIncident.Text)) // Si un des deux sont vides
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs vides !");
            }
            else if (string.IsNullOrWhiteSpace(objetIncident.Text) && string.IsNullOrWhiteSpace(messageIncident.Text)) // Si les deux sont vides
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Champs vides !");
            }
            else
            {
                int IDUser = int.Parse(Application.Current.Properties["IDUser"].ToString());

                // Base de test local
                //BddCo Connexion = new BddCo("localhost", "root", "");

                // Serveur CFA
                // BddCo Connexion = new BddCo("localhost", "root", "");

                // Autre serveur
                BddCo Connexion = new BddCo("srv-wakanda.cloudapp.net", "root", "KCX96mtkhm!");

                int Etat; // DÉTERMINONS LA CRITICITÉ DE TON INCIDENT
                if (critiqueButton.IsChecked == true)
                {
                    Etat = 3;
                }
                else if (urgentButton.IsChecked == true)
                {
                    Etat = 2;
                }
                else if (normalButton.IsChecked == true)
                {
                    Etat = 1;
                }
                else Etat = 0; // Cet else n'est strictement jamais censé se produire.

                Connexion.CreationIncident(objetIncident.Text, messageIncident.Text, Etat, DateTime.Now, IDUser, 0);
                MessageBox.Show("Incident signalé ! Merci.");
                this.Close();
                var window = new BelleTablePlanning.Window1();
                window.Show();
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {

        }
        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }
    }
}
