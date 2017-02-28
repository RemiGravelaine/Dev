using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AbonneProvider
    {
        public AbonneEntity GetInfoAbonne(string nom)
        {
            AbonneEntity abonne = new AbonneEntity();

            //Appel à la base de données
            abonne.Prenom = "Remi";
            abonne.Nom = "Gravelaine";
            abonne.Id = "identifiant-0001";
            return abonne;
        }
    }
}
