using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phantom.MVC.Startup))]
namespace Phantom.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
