using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;

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

        public string CreateConString()
        {
            ConnexionString = "server = " + host + "; user id = " + identi + "; pwd = " + passBd + "; database = belletableplanning";
            return ConnexionString;
        }

        /// <summary>
        /// Cette méthode permet de vérifier si l'utilisateur a accès à l'appli ou pas
        /// On récupère son mail pour le test
        /// </summary>
        /// <param name="_mail"></param>
        /// <returns></returns>
        public bool CheckCompte(string _mail, string _mp)
        {
            
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            // On crypte le mot de passe avec la méthode de hash SHA512
            _mp = GenSHA512Mp(_mp);

            int _IDUser;
            string _Nom;
            string _Prenom;
            string _Phone;
            int _IDType;

            try
            {                 
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                
                cmd.CommandText = "SELECT * FROM `users` WHERE Mail=@mail AND Password =@mp AND Banned=0";
                cmd.Parameters.AddWithValue("@mail", _mail);
                cmd.Parameters.AddWithValue("@mp", _mp);

                object o = cmd.ExecuteScalar();

                // CA SERAIT BIEN QU'ON STOCKE LA CONNEXION DANS UNE SESSION, NON ?
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _IDUser = dataReader.GetInt32(0);
                    _Nom = dataReader.GetString(1);
                    _Prenom = dataReader.GetString(2);
                    _Nom = dataReader.GetString(3);
                    _Phone = dataReader.GetString(4);
                    _IDType = dataReader.GetInt32(5);

                    Application.Current.Properties["IDUser"] = _IDUser;
                    Application.Current.Properties["Nom"] = _Nom;
                    Application.Current.Properties["Prenom"] = _Prenom;
                    Application.Current.Properties["Phone"] = _Phone;
                    Application.Current.Properties["IDType"] = _IDType;
                }
                // MERCI.
                if (o != null)
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

        public bool Inscription(string _nom, string _prenom, string _mail, string _tel, string _typeUser, string _mpU)
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            // On crypte le mot de passe avec la méthode de hash SHA512
            _mpU = GenSHA512Mp(_mpU);

            try
            {                
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `users`(`Nom`, `Prenom`, `Mail`, `Phone`,`IDType`,`Password`) VALUES (@_nom,@_prenom,@_mail,@_tel,@_typeUser,@_mdp)";

                cmd.Parameters.AddWithValue("@_nom", _nom);
                cmd.Parameters.AddWithValue("@_prenom", _prenom);
                cmd.Parameters.AddWithValue("@_mail", _mail);
                cmd.Parameters.AddWithValue("@_tel", _tel);
                cmd.Parameters.AddWithValue("@_typeUser", _typeUser);
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

        public bool RecupereCompteInscrit(string _MailInscrit)
        {
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            int _IDUserInscrit;

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();

                cmd.CommandText = "SELECT IDUser FROM `users` WHERE Mail=@mail";
                cmd.Parameters.AddWithValue("@mail", _MailInscrit);

                object o = cmd.ExecuteScalar();

                // CA SERAIT BIEN QU'ON STOCKE LA CONNEXION DANS UNE SESSION, NON ?
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _IDUserInscrit = dataReader.GetInt32(0);

                    Application.Current.Properties["IDUserInscrit"] = _IDUserInscrit;
                }
                // MERCI.
                if (o != null)
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
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public bool Inscription2(int _IDUserAgenda, string _ContenuAgenda) // Pour souhaiter la bvn au commercial on lui donne un agenda.
        {
            // Pourquoi pas l'avoir fait dans la première méthode ? Car j'ai besoin entre temps de récupérer l'ID du nouveau commercial. Je ne peux pas anticiper un AI.
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `agendas` (`IDUser`, `Contenu`) VALUES (@_IDUserAgenda,@_ContenuAgenda)";

                cmd.Parameters.AddWithValue("@_IDUserAgenda", _IDUserAgenda);
                cmd.Parameters.AddWithValue("@_ContenuAgenda", _ContenuAgenda);
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

        public bool CreationIncident(string _objet, string _message, int _type, DateTime _dateAjout, int _auteur, int _resolu)
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `incidents` (`Objet`, `Message`, `Type`, `DateAjout`, `Auteur`, `Resolu`) VALUES (@_objet,@_message,@_type,@_dateAjout,@_auteur,@_resolu)";
                
                cmd.Parameters.AddWithValue("@_objet", _objet);
                cmd.Parameters.AddWithValue("@_message", _message);
                cmd.Parameters.AddWithValue("@_type", _type);
                cmd.Parameters.AddWithValue("@_dateAjout", _dateAjout);
                cmd.Parameters.AddWithValue("@_auteur", _auteur);
                cmd.Parameters.AddWithValue("@_resolu", _resolu);
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

        public bool RecupereCompte(string _mail)
        {
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();

                cmd.CommandText = "SELECT * FROM `users` WHERE Mail=@mail";
                cmd.Parameters.AddWithValue("@mail", _mail);
                object o = cmd.ExecuteScalar();
                if (o != null)
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
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public void RemplirLeGrid(DataGrid LeGrid, string requeteSql)
        {

            MySqlConnection connection = new MySqlConnection(CreateConString());
            MySqlCommand cmdSel = new MySqlCommand(requeteSql, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
            LeGrid.DataContext = dt;
            LeGrid.ItemsSource = dt.DefaultView;
        }

        public void RemplirLeComboBox(ComboBox LeComboBox, string requeteSql, string Colonne)
        {
            
            MySqlConnection connection = new MySqlConnection(CreateConString());
            connection.Open();
            MySqlCommand cmdSel = new MySqlCommand(requeteSql, connection);
            MySqlDataReader reader = cmdSel.ExecuteReader();
            while (reader.Read())
            {
                LeComboBox.Items.Add(reader.GetString(Colonne)); // Récupération de la colonne au choix de la table
            }
            connection.Close();
        }

        public void RemplirLeComboBox2Colonnes(ComboBox LeComboBox, string requeteSql, string Colonne, string Colonne2)
        {

            MySqlConnection connection = new MySqlConnection(CreateConString());
            connection.Open();
            MySqlCommand cmdSel = new MySqlCommand(requeteSql, connection);
            MySqlDataReader reader = cmdSel.ExecuteReader();
            while (reader.Read())
            {
                LeComboBox.Items.Add(reader.GetString(Colonne) + " " + reader.GetString(Colonne2)); // Récupération de la colonne au choix de la table
            }
            connection.Close();
        }

        public bool CreationRdvEtape1(string _Libelle, string _Description, int _TypeRdv, string _PlanAcces, string _InfoContexte) // 1ère étape : créer le rdv
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `rdv` (`Libelle`, `Description`, `TypeRdv`, `PlanAcces`, `InfoContexte`) VALUES (@_Libelle,@_Description,@_TypeRdv,@_PlanAcces,@_InfoContexte)";

                cmd.Parameters.AddWithValue("@_Libelle", _Libelle);
                cmd.Parameters.AddWithValue("@_Description", _Description);
                cmd.Parameters.AddWithValue("@_TypeRdv", _TypeRdv);
                cmd.Parameters.AddWithValue("@_PlanAcces", _PlanAcces);
                cmd.Parameters.AddWithValue("@_InfoContexte", _InfoContexte);
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

        public bool RecupereNewRdv(string _LibelleRdv)
        {
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            int _IDNewRdv;

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();

                cmd.CommandText = "SELECT IDRdv FROM `rdv` WHERE Libelle=@LibelleRdv"; // Un libellé est unique
                cmd.Parameters.AddWithValue("@LibelleRdv", _LibelleRdv);

                object o = cmd.ExecuteScalar();

                // CA SERAIT BIEN QU'ON STOCKE LA CONNEXION DANS UNE SESSION, NON ?
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _IDNewRdv = dataReader.GetInt32(0);

                    Application.Current.Properties["IDNewRdv"] = _IDNewRdv;
                }
                // MERCI.
                if (o != null)
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
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public bool RecupereInterlocuteur(string _ConcatPrenomNom)
        {
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            int _IDNewInterlocuteur;

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();

                cmd.CommandText = "SELECT IDInterlocuteur FROM `interlocuteurs` WHERE CONCAT(Prenom, ' ', Nom)=@ConcatPrenomNom";
                cmd.Parameters.AddWithValue("@ConcatPrenomNom", _ConcatPrenomNom);

                object o = cmd.ExecuteScalar();

                // CA SERAIT BIEN QU'ON STOCKE LA CONNEXION DANS UNE SESSION, NON ?
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _IDNewInterlocuteur = dataReader.GetInt32(0);

                    Application.Current.Properties["IDNewInterlocuteur"] = _IDNewInterlocuteur;
                }
                // MERCI.
                if (o != null)
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
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public bool CreationRdvEtape2(int _IDRdv, int _IDUser, int _IDInterlocuteur) // 2ème étape : associer le rdv à l'interlocuteur
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `qualifier` (`IDRdv`, `IDUser`, `IDInterlocuteur`) VALUES (@_IDRdv,@_IDUser,@_IDInterlocuteur)";

                cmd.Parameters.AddWithValue("@_IDRdv", _IDRdv);
                cmd.Parameters.AddWithValue("@_IDUser", _IDUser);
                cmd.Parameters.AddWithValue("@_IDInterlocuteur", _IDInterlocuteur);
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

        public bool RecupereAgenda(int _NewIDUserAgenda)
        {
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            int _AgendaUser;

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();

                cmd.CommandText = "SELECT IDAgenda FROM `agendas` WHERE IDUser=@NewIDUserAgenda";
                cmd.Parameters.AddWithValue("@NewIDUserAgenda", _NewIDUserAgenda);

                object o = cmd.ExecuteScalar();

                // CA SERAIT BIEN QU'ON STOCKE LA CONNEXION DANS UNE SESSION, NON ?
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    _AgendaUser = dataReader.GetInt32(0);

                    Application.Current.Properties["AgendaUser"] = _AgendaUser;
                }
                // MERCI.
                if (o != null)
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
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close(); // Fermeture de la connexion
                }
            }
        }

        public bool CreationRdvEtape3(DateTime _Creneau, int _IDAgenda, int IDRdv) // 3ème étape : bloquer un créneau dans l'agenda du commercial
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `bloquer` (`Creneau`, `IDAgenda`, `IDRdv`) VALUES (@_Creneau,@_IDAgenda,@IDRdv)";

                cmd.Parameters.AddWithValue("@_Creneau", _Creneau);
                cmd.Parameters.AddWithValue("@_IDAgenda", _IDAgenda);
                cmd.Parameters.AddWithValue("@IDRdv", IDRdv);
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

        public bool CreationNouveauClient(string _NomClient, string _PrenomClient, string _MailClient, string _AdresseClient, string _TelephoneClient, int _IDStructureClient) // 3ème étape : bloquer un créneau dans l'agenda du commercial
        {
            // Création de la chaine de connexion
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                MySqlCommand cmd;
                connexion.Open(); //Ouverture de la connexion

                cmd = connexion.CreateCommand();
                cmd.CommandText = "INSERT INTO `interlocuteurs` (`Nom`, `Prenom`, `Mail`, `Adresse`, `Phone`, `IDStructure`) VALUES (@_NomClient,@_PrenomClient,@_MailClient,@_AdresseClient,@_TelephoneClient,@_IDStructureClient)";

                cmd.Parameters.AddWithValue("@_NomClient", _NomClient);
                cmd.Parameters.AddWithValue("@_PrenomClient", _PrenomClient);
                cmd.Parameters.AddWithValue("@_MailClient", _MailClient);
                cmd.Parameters.AddWithValue("@_AdresseClient", _AdresseClient);
                cmd.Parameters.AddWithValue("@_TelephoneClient", _TelephoneClient);
                cmd.Parameters.AddWithValue("@_IDStructureClient", _IDStructureClient);
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

        public bool EnvoyerMessage(string objet, string msg, string desti)
        {
            string reqSendMsg = "INSERT INTO `messages`(`objet_msg`, `contenu_msg`, `id_emet`, `id_dest`, `date_envoi`) VALUES (@objet,@msg,@IdEmet,@IdDesti,now())";
            
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                connexion.Open();
                MySqlCommand cmdSendMsg = new MySqlCommand(reqSendMsg, connexion);

                cmdSendMsg.Parameters.AddWithValue("@objet", objet);
                cmdSendMsg.Parameters.AddWithValue("@msg", msg);
                cmdSendMsg.Parameters.AddWithValue("@IdEmet", Application.Current.Properties["IDUser"]);
                cmdSendMsg.Parameters.AddWithValue("@IdDesti", Convert.ToInt32(desti));

                if (cmdSendMsg.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

        public string RecupIdDesti(string mail)
        {
            string reqSendMsg = "SELECT IDUser FROM users WHERE Mail=@Mail";
            
            MySqlConnection connexion = new MySqlConnection(CreateConString());

            try
            {
                connexion.Open();
                MySqlCommand cmdSendMsg = new MySqlCommand(reqSendMsg, connexion);

                cmdSendMsg.Parameters.AddWithValue("@Mail", mail);

                MySqlDataReader reader = cmdSendMsg.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                    }
                }
                return "";
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

        public List<Messages> RecupMsg(string idUser)
        {
            List<Messages> ListeMessages = new List<Messages>();
            string reqSelect = "SELECT id_msg, objet_msg, contenu_msg, date_envoi, id_emet from messages WHERE id_dest=@id_Dest AND NOT id_emet=@id_Emet";

            MySqlConnection connexion = new MySqlConnection(CreateConString());
            try
            {
                connexion.Open();
                MySqlCommand cmdSendMsg = new MySqlCommand(reqSelect, connexion);

                // On ajoute les paramètres à la requête
                cmdSendMsg.Parameters.AddWithValue("@id_Dest", idUser);
                cmdSendMsg.Parameters.AddWithValue("@id_Emet", idUser);

                // On crée le reader
                MySqlDataReader reader = cmdSendMsg.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string idMsg = reader[0].ToString();
                        string objet = reader[1].ToString();
                        string msg = reader[2].ToString();
                        string date = reader[3].ToString();
                        string emet = RecupMailFromId(reader[4].ToString());
                        string desti = idUser;

                        Messages Message = new Messages(idMsg,objet,msg,desti,emet,date);
                        ListeMessages.Add(Message);
                    }
                    return ListeMessages;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

        public string RecupMailFromId(string idUser)
        {
            string reqSelect = "SELECT Mail FROM users WHERE IDUser=@Iduser";
            MySqlConnection connexion = new MySqlConnection(CreateConString());
            try
            {
                connexion.Open();
                MySqlCommand cmdSendMsg = new MySqlCommand(reqSelect, connexion);

                // On ajoute les paramètres à la requête
                cmdSendMsg.Parameters.AddWithValue("@Iduser", idUser);

                // On crée le reader
                MySqlDataReader reader = cmdSendMsg.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader[0].ToString();
                    }
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connexion.State == ConnectionState.Open)
                {
                    connexion.Close();
                }
            }
        }

    }
}