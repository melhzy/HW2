using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmartReporting_HW2.Startup))]
namespace SmartReporting_HW2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
