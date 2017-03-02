﻿using DTO;
using System.Collections.Generic;

namespace DAL
{
    public class AbonneProvider
    {
        List<AbonneEntity> listAbonne = new List<AbonneEntity>();
        public AbonneEntity GetInfoAbonne(string nom)
        {


            AbonneEntity abonne = new AbonneEntity();
            abonne.Prenom = "Remi";
            abonne.Nom = "Gravelaine";
            abonne.Id = "identifiant-0001";
            listAbonne.Add(abonne);
            abonne = new AbonneEntity();
            abonne.Prenom = "Jean";
            abonne.Nom = "Grine";
            abonne.Id = "identifiant-0002";
            listAbonne.Add(abonne);
                                  
            //Appel à la base de données
            return listAbonne.Find(e => e.Nom == nom) ?? new AbonneEntity();

        }

        public void AddAbonneProvider(AbonneEntity abonne)
        {
            listAbonne.Add(abonne);
        }
    }
}
