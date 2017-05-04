using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Syinca.Startup))]
namespace Syinca
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
