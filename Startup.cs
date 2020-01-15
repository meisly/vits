using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vits.Startup))]
namespace Vits
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
