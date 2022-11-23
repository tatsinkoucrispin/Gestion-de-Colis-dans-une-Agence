using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionColis.Types
{
    public class Recepteur
    {
        public int Id_rec;
        public string Nom_rec;
        public string Prenom_rec;
        public string Telephone_rec;
        public string Adresse;
        public string Email;

        public Recepteur(string Nom_rec, string Prenom_rec, string Telephone_rec, string Adresse, string Email)
        {
            this.Nom_rec = Nom_rec;
            this.Prenom_rec = Prenom_rec;
            this.Telephone_rec = Telephone_rec;
            this.Adresse = Adresse;
            this.Email = Email;
        }
    }
}
