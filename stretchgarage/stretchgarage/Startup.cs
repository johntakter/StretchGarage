using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(stretchgarage.Startup))]
namespace stretchgarage
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
