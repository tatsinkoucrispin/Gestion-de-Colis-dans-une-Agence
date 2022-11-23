using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionColis.Types
{
    public class Agence
    {
        public int Id_agence;
        public String Nom_agence;
        public String Localisation;
        public String Adresse;
        public String Telephone;
        

        public Agence(String Nom_agence, String Localisation, String Adresse, String Telephone)
        {
            this.Nom_agence = Nom_agence;
            this.Localisation = Localisation;
            this.Adresse = Adresse;
            this.Telephone = Telephone;
        }
    }

    
}
