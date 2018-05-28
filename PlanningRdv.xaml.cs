using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BelleTablePlanning
{
    /// <summary>
    /// Logique d'interaction pour PlanningRdv.xaml
    /// </summary>
    public partial class PlanningRdv : Window
    {
        // Base de test local
        //BddCo Bdd = new BddCo("localhost", "root", "");

        // Serveur CFA
        // BddCo Bdd = new BddCo("localhost", "root", "");

        // Autre serveur
        BddCo Bdd = new BddCo("srv-wakanda.cloudapp.net", "root", "KCX96mtkhm!");

        int IDUser = int.Parse(Application.Current.Properties["IDUser"].ToString());

        public PlanningRdv()
        {
            InitializeComponent();
            RemplirListeRdv();
        }

        private void RemplirListeRdv()
        {
            // On vide la Grid pour eviter les doublons
            planningGrid.Items.Clear();

            // On instancie une liste pour y mettre les rdv récupérés
            List<Rdv> listeRdv = new List<Rdv>();

            // On récupère tous les rdv de l'utilisateur courant et on les ajoute dans la liste
            Bdd.RecupAllRdv(IDUser, listeRdv);

            // On ajoute chaque rdv contenus dans la liste dans la Grid
            foreach (Rdv rdv in listeRdv)
            {
                planningGrid.Items.Add(rdv);
            }

            planningGrid.Items.Refresh();
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }

        private void btnResetFiltre_Click(object sender, RoutedEventArgs e)
        {
            filtreDatePick.Text = "";
        }

        private void filtreDatePick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(filtreDatePick.Text))
            {
                RemplirListeRdv();
                planningGrid.Items.Refresh();
            }
            else
            {
                List<Rdv> listeRdv = new List<Rdv>();
                                
                // On récupère le format US pour faire correspondre le format de date au format MYSQL
                CultureInfo usFormat = new CultureInfo("us-US");

                // On stock le tout dans une variable pour faciliter la lecture en précisant le format MySql
                string dateFormat = filtreDatePick.SelectedDate.Value.ToString("yyyy-MM-dd");
                // On vide la grid pour la mettre à jour
                planningGrid.Items.Clear();

                // On récupère les rdv en les filtrant par la date fournie
                Bdd.RecupRdvFiltre(dateFormat, IDUser, listeRdv);

                foreach (Rdv rdv in listeRdv)
                {
                    planningGrid.Items.Add(rdv);
                }
            }
        }

        private void btnDetailsRdv_Click(object sender, RoutedEventArgs e)
        {
            if (planningGrid.SelectedIndex > -1)
            {
                Rdv rdv = (Rdv)planningGrid.SelectedItem;
                RdvDetails PageDetailsRdv = new RdvDetails(rdv);
                PageDetailsRdv.Show();
            }
        }
    }
}
