using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ass22sep2018.Authentication.Startup))]
namespace Ass22sep2018.Authentication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
