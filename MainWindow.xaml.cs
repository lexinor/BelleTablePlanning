﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BelleTablePlanning
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BddCo Connexion = new BddCo("localhost", "root", "");

        public MainWindow()
        {
            InitializeComponent();            
        }

        private void btn_Con_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Connecté");
        }

        /// <summary>
        /// Méthode appelée par le bouton "S'inscrire"
        /// Permet de vérifier que tous les champs sont bien renseignés
        /// Ainsi que de réaliser l'inscription via la classe BddCo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Inscrip_Click(object sender, RoutedEventArgs e)
        {
            string nom, prenom, tel, mail, mp;
            // On vérifie qu'aucun champ du formulaire n'est vide
            if (tb_Nom.Text == "" || tb_Prenom.Text == "" || tb_Tel.Text == "" || tb_Mail.Text == "" || tb_InscrMp.Password.ToString() == "" || tb_InscrMpConfirm.Password.ToString() == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
            else
            {
                // On regarde si les deux mdp insérés sont identiques
                if(tb_InscrMp.Password.ToString() != tb_InscrMpConfirm.Password.ToString())
                {
                    MessageBox.Show("Les mots de passe ne sont pas identiques");
                }
                else
                {
                    // On récup toutes les valeurs des champs                    
                    nom = tb_Nom.Text;
                    prenom = tb_Prenom.Text;
                    tel = tb_Tel.Text;
                    mail = tb_Mail.Text;
                    mp = tb_InscrMp.Password.ToString();
                    
                    if (Connexion.Inscription(nom,prenom, tel, mail,mp))
                    {
                        MessageBox.Show("Votre compte à bien été crée !");
                        // On cache le formulaire d'inscription et on affiche le formulaire de connexion
                        InscriptionGrid.Visibility = Visibility.Collapsed;
                        ConnexionGrid.Visibility = Visibility.Visible;
                    }
                }                
            }            
        }

        private void InscriptionClick(object sender, RoutedEventArgs e)
        {
            // On cache le formulaire de connexion et on affiche le formulaire d'inscription
            ConnexionGrid.Visibility = Visibility.Collapsed;
            InscriptionGrid.Visibility = Visibility.Visible;
        }

        private void btn_Connexion_Click(object sender, RoutedEventArgs e)
        {
            if(tb_Identi.Text == "" || tb_Mp.Password.ToString() == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs");
            }
            else
            {
                if(Connexion.CheckCompte(tb_Identi.Text,tb_Mp.Password.ToString()))
                {
                    MessageBox.Show("Connexion réussie !", "Bienvenue", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Connexion échouée","Impossible de se connecter", MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }

        private void btn_Retour_Click(object sender, RoutedEventArgs e)
        {
            // On cache le formulaire d'inscription et on affiche le formulaire de connexion
            InscriptionGrid.Visibility = Visibility.Collapsed;
            ConnexionGrid.Visibility = Visibility.Visible;
        }
    }
}
