using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelleTablePlanning
{
    public class Incident
    {
        public string objet { get; set; }
        public string msg { get; set; }
        public string typeIncident { get; set; }
        public string date { get; set; }
        public string auteur { get; set; }
        public string statut { get; set; }
        public string idIncident { get; set; }

        public Incident(string _objet, string _msg, string _type, string _date, string _auteur, string _statut, string _IdIncident)
        {
            objet = _objet;
            msg = _msg;
            typeIncident = _type;
            date = _date;
            auteur = _auteur;
            statut = _statut;
            idIncident = _IdIncident;
        }

        

    }
}