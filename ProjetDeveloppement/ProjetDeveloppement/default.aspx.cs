using System;
using ProjetDeveloppement.ServiceLibraryWcf;

namespace ProjetDeveloppement
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AbonneServiceLibraryClient abonne = new AbonneServiceLibraryClient();
            labelTest.Text = abonne.GetInfoAbonne("ersdfsdf").Id;
        }
    }
}