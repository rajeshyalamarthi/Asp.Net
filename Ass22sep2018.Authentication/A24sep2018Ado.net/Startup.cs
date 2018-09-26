using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A24sep2018Ado.net.Startup))]
namespace A24sep2018Ado.net
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
