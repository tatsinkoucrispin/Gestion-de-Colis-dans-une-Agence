using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionColis.Types
{
    public class Expediteur
    {
        public int Id_exp;
        public string Nom_exp;
        public string Prenom_exp;
        public string Telephone_exp;
        public string Adresse_exp;
        public string Email_exp;

        public Expediteur(string Nom_exp, string Prenom_exp, string Telephone_exp,string Adresse_exp,string Email_exp)
        {
            this.Nom_exp = Nom_exp;
            this.Prenom_exp = Prenom_exp;
            this.Telephone_exp = Telephone_exp;
            this.Adresse_exp = Adresse_exp;
            this.Email_exp = Email_exp;
        }

    }
}
