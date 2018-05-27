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
    /// Logique d'interaction pour EnvoiMsg.xaml
    /// </summary>
    public partial class EnvoiMsg : Window
    {
        BddCo Bdd = new BddCo("localhost", "root", "");
        public EnvoiMsg()
        {
            InitializeComponent();
            Bdd.RemplirLeComboBox(cb_desti, "SELECT * FROM users WHERE NOT IDUser=" + Application.Current.Properties["IDUser"].ToString(), "Mail");
        }

        private void btn_SendMsg_Click(object sender, RoutedEventArgs e)
        {
            if(Bdd.EnvoyerMessage(tb_objetMsg.Text, tb_MsgContenu.Text, Bdd.RecupIdDesti(cb_desti.Text)))
            {
                MessageBox.Show("Message envoyé avec succès à " + cb_desti.Text);
            }
        }
    }
}
