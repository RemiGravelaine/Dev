using System.Runtime.Serialization;

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
