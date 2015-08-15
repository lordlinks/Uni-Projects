using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hex_Calc.Startup))]
namespace Hex_Calc
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
