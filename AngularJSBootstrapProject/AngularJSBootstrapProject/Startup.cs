using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularJSBootstrapProject.Startup))]
namespace AngularJSBootstrapProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
