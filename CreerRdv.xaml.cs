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
    /// Logique d'interaction pour CreerRdv.xaml
    /// </summary>
    public partial class CreerRdv : Window
    {
        // Base de test local
        //BddCo Bdd = new BddCo("localhost", "root", "");

        // Serveur CFA
        // BddCo Bdd = new BddCo("localhost", "root", "");

        // Autre serveur
        BddCo Bdd = new BddCo("srv-wakanda.cloudapp.net", "root", "KCX96mtkhm!");

        public CreerRdv()
        {
            InitializeComponent();

            // On met la date minimum du datepicker à la date d'aujourd'hui
            dateText.DisplayDateStart = DateTime.Now.ToLocalTime();

            remplirCbHoraires(cbHeures, cbMinutes);

            string requeteSqlTypeRdv = "SELECT Libelle FROM typesrdv ORDER BY Libelle;";
            Bdd.RemplirLeComboBox(typeCombo, requeteSqlTypeRdv, "Libelle");
            string requeteSqlInterlocuteur = "SELECT * FROM interlocuteurs ORDER BY Prenom;";
            Bdd.RemplirLeComboBox2Colonnes(interlocuteurCombo, requeteSqlInterlocuteur, "Prenom", "Nom");
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            var window = new BelleTablePlanning.Window1();
            window.Show();
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            // Créer des contrôles ------------
            string Libelle = libelleText.Text;
            string Description = new TextRange(descriptionText.Document.ContentStart, descriptionText.Document.ContentEnd).Text;
            string Date = dateText.Text;
            string PlanAcces = new TextRange(planAccesText.Document.ContentStart, planAccesText.Document.ContentEnd).Text;            

            // Vérification des champs vides
            if (string.IsNullOrWhiteSpace(Libelle) || string.IsNullOrWhiteSpace(Description) || string.IsNullOrWhiteSpace(Date) || string.IsNullOrWhiteSpace(PlanAcces) || typeCombo.SelectedIndex < 1 || interlocuteurCombo.SelectedIndex < 1)
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur !");
            }
            else
            {
                string TypeRdv = typeCombo.Text;
                string Interlocuteur = interlocuteurCombo.Text;

                // Détermination du type de rendez-vous selon le libellé
                int IDTypeRdv;
                if (TypeRdv == "Première rencontre")
                {
                    IDTypeRdv = 1;
                }
                else if (TypeRdv == "Rendez-vous téléphonique")
                {
                    IDTypeRdv = 2;
                }
                else if (TypeRdv == "Visite de courtoisie")
                {
                    IDTypeRdv = 3;
                }
                else if (TypeRdv == "Visite technique")
                {
                    IDTypeRdv = 4;
                }
                else if (TypeRdv == "Conclusion")
                {
                    IDTypeRdv = 5;
                }
                else
                {
                    IDTypeRdv = 0; // Else de backup. Il ne devrait jamais arriver.
                }
                #region 
                if (Bdd.CreationRdvEtape1(Libelle, Description, IDTypeRdv, PlanAcces, ""))
                {
                    Bdd.RecupereNewRdv(Libelle);
                    int IDNewRdv = int.Parse(Application.Current.Properties["IDNewRdv"].ToString()); // ID récupéré
                    int IDUser = int.Parse(Application.Current.Properties["IDUser"].ToString()); // ID récupéré
                    Bdd.RecupereInterlocuteur(Interlocuteur);
                    int IDNewInterlocuteur = int.Parse(Application.Current.Properties["IDNewInterlocuteur"].ToString()); // ID récupéré
                    if (Bdd.CreationRdvEtape2(IDNewRdv, IDUser, IDNewInterlocuteur))
                    {
                        int annees = dateText.SelectedDate.Value.Date.Year;
                        int mois = dateText.SelectedDate.Value.Date.Month;
                        int jours = dateText.SelectedDate.Value.Date.Day;
                        int heures = Convert.ToInt32(cbHeures.SelectedItem);
                        int minutes = Convert.ToInt32(cbMinutes.SelectedItem);

                        DateTime fullDate = new DateTime(annees, mois, jours, heures, minutes, 0);

                        Bdd.RecupereAgenda(IDUser);
                        int IDAgenda = int.Parse(Application.Current.Properties["AgendaUser"].ToString()); // ID récupéré
                        if (Bdd.CreationRdvEtape3(fullDate, IDAgenda, IDNewRdv))
                        {
                            MessageBox.Show("Le rendez-vous a été créé avec succès ! RDV le " + Date + " avec " + Interlocuteur + ".", "Succès !");
                            Application.Current.Properties.Remove("IDNewRdv");
                            Application.Current.Properties.Remove("IDNewInterlocuteur");
                            Application.Current.Properties.Remove("AgendaUser");
                            this.Close();
                            var window = new BelleTablePlanning.Window1();
                            window.Show();
                        }
                        else
                        {
                            MessageBox.Show("Une erreur s'est produite lors de l'étape 3.", "Erreur.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Une erreur s'est produite lors de l'étape 2.", "Erreur.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite lors de l'étape 1.", "Erreur.");
                }
                #endregion
            }
        }

        private void quickRdvBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dateText.SelectedDate.Value != null)
            {
                MessageBox.Show(dateText.SelectedDate.Value.Date.ToLocalTime().ToString());
            }
        }

        private void remplirCbHoraires(ComboBox _cbHeures, ComboBox _cbMinutes)
        {
            for (int i = 0; i < 24; i++)
            {
                if (i < 10)
                {
                    _cbHeures.Items.Add("0" + i.ToString());
                }
                else
                {
                    _cbHeures.Items.Add(i.ToString());
                }
            }
            for (int i = 0; i < 60; i++)
            {
                if (i < 10)
                {
                    _cbMinutes.Items.Add("0" + i.ToString());
                }
                else
                {
                    _cbMinutes.Items.Add(i.ToString());
                }
            }            
        }
    }
}
