using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControlAppMVC.Startup))]
namespace ControlAppMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
