//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mobler.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Utilisateur
    {
        public int Id_User { get; set; }
        public string Nom_User { get; set; }
        public string Prenom_User { get; set; }
        public string Email_User { get; set; }
        public string Password { get; set; }
        public Nullable<int> type_User { get; set; }
    }
}
