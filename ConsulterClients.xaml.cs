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
    /// Logique d'interaction pour ConsulterClients.xaml
    /// </summary>
    public partial class ConsulterClients : Window
    {
        // Base de test local
        //BddCo Bdd = new BddCo("localhost", "root", "");

        // Serveur CFA
        // BddCo Bdd = new BddCo("localhost", "root", "");

        // Autre serveur
        BddCo Bdd = new BddCo("srv-wakanda.cloudapp.net", "root", "KCX96mtkhm!");

        public ConsulterClients()
        {
            InitializeComponent();

            RecupListe();
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.PortefeuilleClients();
            window.Show();
        }    
        
        private void RecupListe()
        {
            // On vide la grid pour éviter les doublons lors de l'ajout des clients
            clientsGrid.Items.Clear();

            // On instancie une liste de Clients
            List<Clients> listeClients = new List<Clients>();

            // On récupère la liste des clients
            Bdd.RecupListeClients(listeClients);

            // On ajoute chaque clients de la liste dans la grid
            foreach (Clients client in listeClients)
            {
                clientsGrid.Items.Add(client);
            }

        }    
    }
}
