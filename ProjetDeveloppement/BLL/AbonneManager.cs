using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}