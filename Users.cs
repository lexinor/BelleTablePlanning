using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BelleTablePlanning
{
    public class Users
    {
        public Users(string _nomU, string _prenomU, string _mailU, string _telU)
        {
            nomU = _nomU;
            prenomU = _prenomU;
            mailU = _mailU;
            telU = _telU;
        }

        public string nomU { get; set; }
        public string prenomU { get; set; }
        public string mailU { get; set; }
        public string telU { get; set; }
    }
}