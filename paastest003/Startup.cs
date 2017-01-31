using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(paastest003.Startup))]
namespace paastest003
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
