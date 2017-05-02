using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BerryAutoService.Startup))]
namespace BerryAutoService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
