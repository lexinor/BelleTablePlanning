using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelleTablePlanning
{
    public class Rdv
    {
        public string nomClient { get; set; }
        public string prenomClient { get; set; }
        public string mailClient { get; set; }
        public string adrClient { get; set; }
        public string telClient { get; set; }
        public string dateRdv { get; set; }
        public string libelleRdv { get; set; }
        public string descripRdv { get; set; }
        public string planRdv { get; set; }
        public string typeRdv { get; set; }   
        
        public Rdv(string _nomC, string _prenomC, string _mailC, string _adrC, string _telC, string _date, string _lblRdv, string _descri, string _plan, string _type)
        {
            nomClient = _nomC;
            prenomClient = _prenomC;
            mailClient  = _mailC;
            adrClient  = _adrC;
            telClient  = _telC;
            dateRdv  = _date;
            libelleRdv  = _lblRdv;
            descripRdv  = _descri;
            planRdv  = _plan;
            typeRdv  = _type;
        }    

    }
}