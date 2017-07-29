using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FreeCodeCamp.Startup))]
namespace FreeCodeCamp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
