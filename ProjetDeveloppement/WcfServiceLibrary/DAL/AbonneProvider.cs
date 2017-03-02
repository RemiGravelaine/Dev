using DTO;
using System.Collections.Generic;

namespace DAL
{
    public class AbonneProvider
    {
        List<AbonneEntity> listAbonne = new List<AbonneEntity>();
        public AbonneEntity GetInfoAbonne(string nom)
        {                                  
            //Appel à la base de données
            return listAbonne.Find(e => e.Nom == nom) ?? new AbonneEntity();

        }

        public void AddAbonneProvider(AbonneEntity abonne)
        {
            listAbonne.Add(abonne);
        }
    }
}
