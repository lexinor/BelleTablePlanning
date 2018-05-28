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
    /// Logique d'interaction pour RdvDetails.xaml
    /// </summary>
    public partial class RdvDetails : Window
    {
        public RdvDetails(Rdv rdv)
        {
            InitializeComponent();
            getRdvInfos(rdv);
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void getRdvInfos(Rdv rdv)
        {
            typeRdv.Content = rdv.typeRdv;
            infosC.Content = rdv.nomClient + " " + rdv.prenomClient;
            dateRdv.Content = rdv.dateRdv;
            intituleRdv.Content = rdv.libelleRdv;
            descriptionRdv.Content = rdv.descripRdv;
            planRdv.Content = rdv.adrClient;
            mailC.Content = rdv.mailClient;
            telC.Content = rdv.telClient;
        }
    }
}
