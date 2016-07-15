using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeveloperForce.Startup))]
namespace DeveloperForce
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
