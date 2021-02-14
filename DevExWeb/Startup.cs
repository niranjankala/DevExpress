using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevExWeb.Startup))]
namespace DevExWeb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
