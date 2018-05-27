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
    /// Logique d'interaction pour PortefeuilleClients.xaml
    /// </summary>
    public partial class PortefeuilleClients : Window
    {
        public PortefeuilleClients()
        {
            InitializeComponent();
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }

        private void btnConsulterClients_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.ConsulterClients();
            window.Show();
        }

        private void btnCreerClient_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.CreerClient();
            window.Show();
        }
    }
}
