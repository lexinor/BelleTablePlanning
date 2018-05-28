using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Logique d'interaction pour Administration.xaml
    /// </summary>
    public partial class Administration : Window
    {
        BddCo Bdd = new BddCo("localhost", "root", "");

        public Administration()
        {
            InitializeComponent();

            RecupListeUsers();

            RecupListeIncidents();
        }

        private void btnport_Click()
        {
            
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }

        private void RecupListeUsers()
        {
            // On vide la Grid pour eviter les doublons
            listeMembre.Items.Clear();

            // On instancie une liste pour y mettre les utilisateurs récupérés
            List<Users> listeUsers = new List<Users>();

            // On récupère tous utilisateurs et on les ajoute dans la liste
            Bdd.RecupUsers(listeUsers);

            // On ajoute chaque utilisateurs contenus dans la liste dans la Grid
            foreach (Users user in listeUsers)
            {
                listeMembre.Items.Add(user);
            }
            listeMembre.Items.Refresh();
        }

        private void RecupListeIncidents()
        {
            // On vide la Grid pour eviter les doublons
            incidentsGrid.Items.Clear();

            // On instancie une liste pour y mettre les utilisateurs récupérés
            List<Incident> listeIncidents = new List<Incident>();

            // On récupère tous utilisateurs et on les ajoute dans la liste
            Bdd.RecupAllIncidents(listeIncidents);

            // On ajoute chaque utilisateurs contenus dans la liste dans la Grid
            foreach (Incident incident in listeIncidents)
            {
                incidentsGrid.Items.Add(incident);
            }
            incidentsGrid.Items.Refresh();
        }

        private void btnResolu_Click(object sender, RoutedEventArgs e)
        {
            if (incidentsGrid.SelectedIndex > -1)
            {
                Incident incident = (Incident)incidentsGrid.SelectedItem;
                if (Bdd.IsResolu(incident))
                {
                    incidentsGrid.Items.Clear();
                    RecupListeIncidents();
                    MessageBox.Show("Incident Résolu !");

                }
            }
        }
    }
}
