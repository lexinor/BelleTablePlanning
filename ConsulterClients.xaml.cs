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
        BddCo Bdd = new BddCo("localhost", "root", "");
        public ConsulterClients()
        {
            InitializeComponent();
            string requeteClients = "SELECT * FROM interlocuteurs ORDER BY IDInterlocuteur";
            Bdd.RemplirLeGrid(clientsGrid, requeteClients);
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.PortefeuilleClients();
            window.Show();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
