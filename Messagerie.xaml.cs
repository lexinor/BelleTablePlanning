﻿using System;
using System.Data;
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
    /// Logique d'interaction pour Messagerie.xaml
    /// </summary>
    public partial class Messagerie : Window
    {
        // Base de test local
        //BddCo Bdd = new BddCo("localhost", "root", "");

        // Serveur CFA
        // BddCo Bdd = new BddCo("localhost", "root", "");

        // Autre serveur
        BddCo Bdd = new BddCo("srv-wakanda.cloudapp.net", "root", "KCX96mtkhm!");

        string idUser = Application.Current.Properties["IDUser"].ToString();

        public Messagerie()
        {
            InitializeComponent();
            RemplirMessages();           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EnvoiMsg EnvoyezMsg = new EnvoiMsg();
            EnvoyezMsg.Show();
        }

        private void lireMsg_btn_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void lireMsg_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void repMsg_btn_Click(object sender, RoutedEventArgs e)
        {            
            Repondre repMsg = new Repondre();
            repMsg.Show();
        }

        private void RemplirMessages() 
        {
            List<Messages> ListeMessage = Bdd.RecupMsg(idUser);
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();

            foreach (var message in ListeMessage)
            {
                msgGrid.Items.Add(message);
            }
        }
    }
}
