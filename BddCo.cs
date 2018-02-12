using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace BelleTablePlanning
{
    public class BddCo
    {
        private string host;
        private string identi;
        private string passBd;
        private string ConnexionString;
        
        public BddCo(string _hst, string _idu,string _psBd)
        {            
            host = _hst;
            identi = _idu;
            passBd = _psBd;
        }

        /// <summary>
        /// Cette méthode permet de vérifier si l'utilisateur a accès à l'appli ou pas
        /// On récupère son mail pour le test
        /// </summary>
        /// <param name="_mail"></param>
        /// <returns></returns>
        public bool CheckCompte(string _mail, string _mp)
        {
            ConnexionString = "server = " + host + "; user id = " + identi + "; pwd = " + passBd + "; database = belletableplanning";
            MySqlConnection connexion = new MySqlConnection(ConnexionString);

            // On crypte le mot de passe avec la méthode de hash SHA512
            _mp = GenSHA512Mp(_mp);

            try
            {                
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                
                cmd.CommandText = "SELECT Mail, Password, Banned FROM `users` WHERE Mail=@mail AND Password =@mp AND Banned=0";
                cmd.Parameters.AddWithValue("@mail", _mail);
                cmd.Parameters.AddWithValue("@mp", _mp);
                object o = cmd.ExecuteScalar();
                if(o != null)
                {
                    return true;
                }
                return false;                
            }
            catch (MySqlException)
            {
                return false;
                throw;                
            }
            finally
            {
                if(connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public bool Inscription(string _nom, string _prenom, string _mail, string _tel, string _mpU)
        {
            // Création de la chaine de connexion
            ConnexionString = "server = " + host + "; user id = " + identi + "; pwd = " + passBd + "; database = belletableplanning";
            MySqlConnection connexion = new MySqlConnection(ConnexionString);

            // On crypte le mot de passe avec la méthode de hash SHA512
            _mpU = GenSHA512Mp(_mpU);

            try
            {                
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `users`(`Nom`, `Prenom`, `Mail`, `Phone`,`Password`) VALUES (@_nom,@_prenom,@_mail,@_tel,@_mdp)";

                cmd.Parameters.AddWithValue("@_nom", _nom);
                cmd.Parameters.AddWithValue("@_prenom", _prenom);
                cmd.Parameters.AddWithValue("@_mail", _mail);
                cmd.Parameters.AddWithValue("@_tel", _tel);
                cmd.Parameters.AddWithValue("@_mdp", _mpU);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        private string GenSHA512Mp(string _inputMp)
        {
            SHA512Managed HashTool = new SHA512Managed();
            Byte[] HashAsByte = System.Text.Encoding.UTF8.GetBytes(_inputMp);
            Byte[] MpCrypted = HashTool.ComputeHash(HashAsByte);
            HashTool.Clear();
            return Convert.ToBase64String(MpCrypted);
        }        
    }
}