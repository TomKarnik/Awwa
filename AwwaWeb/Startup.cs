using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AwwaWeb.Startup))]
namespace AwwaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
