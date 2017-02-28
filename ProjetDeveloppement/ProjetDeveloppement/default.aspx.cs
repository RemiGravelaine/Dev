using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace ProjetDeveloppement
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AbonneManager abonne = new AbonneManager();
            labelTest.Text = abonne.GetInfoAbonne("Remi").Nom;
        }
    }
}