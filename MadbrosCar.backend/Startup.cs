using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MadbrosCar.backend.Startup))]
namespace MadbrosCar.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
