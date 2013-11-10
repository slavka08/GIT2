using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppHarbor.Startup))]
namespace AppHarbor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
