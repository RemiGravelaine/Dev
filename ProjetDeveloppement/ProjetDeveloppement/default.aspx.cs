using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WcfServiceLibrary;

namespace ProjetDeveloppement
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AbonneServiceLibrary abonneService = new AbonneServiceLibrary();
            labelTest.Text = abonneService.GetInfoAbonne("Remi").Id;
        }
    }
}