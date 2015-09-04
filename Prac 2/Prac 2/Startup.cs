using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Prac_2.Startup))]
namespace Prac_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
