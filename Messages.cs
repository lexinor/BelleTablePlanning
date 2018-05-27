using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelleTablePlanning
{
    public class Messages
    {
        public string id_msg { get; set; }
        public string objet_msg { get; set; }
        public string msg { get; set; }
        public string destinataire { get; set; }
        public string emetteur { get; set; }
        public string date_msg { get; set; }

        public Messages(string _idmsg, string _obj_msg, string _msg, string desti, string emet, string date)
        {
            id_msg = _idmsg;
            objet_msg = _obj_msg;
            msg = _msg;
            destinataire = desti;
            emetteur = emet;
            date_msg = date;
        }
    }
}