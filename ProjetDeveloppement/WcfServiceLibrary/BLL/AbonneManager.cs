﻿using DAL;
using DTO;

namespace BLL
{
    public class AbonneManager
    {

        /// <summary>
        /// Méthode de récuperation des informations de l'abonné
        /// </summary>
        /// <param name="name">Nom de l'abonné</param>
        /// <returns>Retourne toutes les informations de l'abonné</returns>
        public AbonneEntity GetInfoAbonne(string name)
        {
            return new AbonneProvider().GetInfoAbonne(name);
        }

        public void AddAbonneManager(AbonneEntity abonne)
        {
            if (!string.IsNullOrEmpty(abonne.Nom) && !string.IsNullOrEmpty(abonne.Prenom))
            {
                new AbonneProvider().AddAbonneProvider(abonne);
            }
        }

    }
}