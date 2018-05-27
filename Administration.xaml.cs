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
            string requeteIncidents = "SELECT * FROM incidents ORDER BY IDIncident";
            Bdd.RemplirLeGrid(affincidents, requeteIncidents);
            string requeteUtilisateurs = "SELECT * FROM users ORDER BY IDUser";
            Bdd.RemplirLeGrid(listemembre, requeteUtilisateurs);
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

        public static DataTable SelectData(string sCommand)
        {
            DataTable dtData = null;
            try
            {
                dtData = new DataTable();
                string ConnexionString = "server = 127.0.0.1; user id = root; pwd = ; database = belletableplanning";
                using (MySqlConnection connection = new MySqlConnection(ConnexionString))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(sCommand, connection))
                    {
                        connection.Open();
                        da.Fill(dtData);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dtData;
        }

        DataTable dtData = SelectData("SELECT * FROM incidents");
        //affincidents.DataSource = dtData;

        

        private void affincidents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
