using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Colaboratorio.Startup))]
namespace Colaboratorio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
