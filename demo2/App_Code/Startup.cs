using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(demo2.Startup))]
namespace demo2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
