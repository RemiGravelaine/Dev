using System.Runtime.Serialization;

namespace DTO
{
    public class AbonneEntity
    {

        public AbonneEntity()
        {
            Id = string.Empty;
            Nom = string.Empty;
            Prenom = string.Empty;
        }

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
