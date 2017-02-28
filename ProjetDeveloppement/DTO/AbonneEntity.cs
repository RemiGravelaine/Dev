using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AbonneEntity
    {
        /// <summary>
        /// Identifiant de l'abonné
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// Nom de l'abonné
        /// </summary>
        [DataMember]
        public string Nom { get; set; }

        /// <summary>
        /// Prénom de l'abonné
        /// </summary>
        [DataMember]
        public string Prenom { get; set; }
    }
}
