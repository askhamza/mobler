using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mobler.Models
{
    public class Devis
    {
        public int Id_Devis { set; get; }
        public string Nom_Visiteur { set; get; }
        public string Prenom_Visiteur { set; get; }
        public string Email_Visiteur { set; get; }
        public string Tel_Visiteur { set; get; }
        public string Description { set; get; }
        public int Id_Article { set; get; }
        public int Qte { set; get; }
    }
}