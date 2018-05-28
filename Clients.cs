using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelleTablePlanning
{
    public class Clients
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string tel { get; set; }
        public string adresse { get; set; }
        public string typeClient { get; set; }

        public Clients(string _nom, string _prenom, string _mail, string _tel, string _adr, string _typeC)
        {
            nom = _nom;
            prenom = _prenom;
            mail = _mail;
            tel = _tel;
            adresse = _adr;
            typeClient = _typeC;

        }
    }
}