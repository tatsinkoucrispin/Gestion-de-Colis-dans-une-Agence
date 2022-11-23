using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionColis.Types
{
    public  class Employes
    {
        public int Id_employe;
        public string Nom;
        public string Prenom;
        public string Email;
        public string Telephone;
        public string Poste;

        public Employes (string Nom, string Prenom, string Email, string Telephone, string Poste)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Email = Email;
            this.Telephone = Telephone;
            this.Poste = Poste;

        }
    }
}
