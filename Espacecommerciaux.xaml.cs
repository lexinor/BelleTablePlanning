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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            int IDType = int.Parse(Application.Current.Properties["IDType"].ToString());
            if (IDType == 3)
            {
                btnAdmin.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Incidents();
            window.Show();
        }

        private void btnretour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            // BOUTON DÉCONNEXION ? DESTRUCTION DE LA SESSION...
            Application.Current.Properties.Remove("IDUser");
            Application.Current.Properties.Remove("Nom");
            Application.Current.Properties.Remove("Prenom");
            Application.Current.Properties.Remove("Phone");
            Application.Current.Properties.Remove("IDType");
            // ... Done.
            var window = new BelleTablePlanning.MainWindow();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Administration();
            window.Show();
        }

        private void btnportecli_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.PortefeuilleClients();
            window.Show();
        }

        private void btnrdv_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.CreerRdv();
            window.Show();
        }

        private void btnplanning_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.PlanningRdv();
            window.Show();
        }

        private void btnmail_Click(object sender, RoutedEventArgs e)
        {
            Messagerie PageMsg = new Messagerie();
            PageMsg.Show();

        }
    }
}
