using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Angulari18n.Startup))]
namespace Angulari18n
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
