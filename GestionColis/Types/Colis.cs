using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionColis.Types
{
    public class Colis
    {
        public int Id_colis;
        public string Nom_col;
        public double Valeur;
        public string description;
        public DateTime date_dep;
        public DateTime date_arr;
        
        public Colis(String Nom_col,double Valeur, string description,DateTime date_dep, DateTime date_arr)
        {
            this.Nom_col = Nom_col;
            this.Valeur = Valeur;
            this.description = description;
            this.date_dep = date_dep;
            this.date_arr = date_arr;

        }


    }
}
