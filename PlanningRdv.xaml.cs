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
    /// Logique d'interaction pour PlanningRdv.xaml
    /// </summary>
    public partial class PlanningRdv : Window
    {
        BddCo Bdd = new BddCo("localhost", "root", "");
        public PlanningRdv()
        {
            InitializeComponent();
            int IDUser = int.Parse(Application.Current.Properties["IDUser"].ToString());
            string planningSql = "SELECT * FROM rdv, qualifier, bloquer WHERE rdv.IDRdv = qualifier.IDRdv AND qualifier.IDRdv = bloquer.IDRdv AND IDUser = " + IDUser;
            Bdd.RemplirLeGrid(planningGrid, planningSql);
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }
    }
}
