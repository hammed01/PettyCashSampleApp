using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PettyCashApp.Startup))]
namespace PettyCashApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
