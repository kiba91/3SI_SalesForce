using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForceDev.Startup))]
namespace ForceDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
