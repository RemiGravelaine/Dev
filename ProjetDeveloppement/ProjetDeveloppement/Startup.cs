using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetDeveloppement.Startup))]
namespace ProjetDeveloppement
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
