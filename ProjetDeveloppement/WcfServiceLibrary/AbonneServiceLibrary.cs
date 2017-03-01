using BLL;
using DTO;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AbonneServiceLibrary : IAbonneServiceLibrary
    {

        public AbonneEntity GetInfoAbonne(string nom)
        {
            return new AbonneManager().GetInfoAbonne(nom);
        }

        public AbonneEntity test(string nom)
        {
            return new AbonneEntity();
        }
    }
}
