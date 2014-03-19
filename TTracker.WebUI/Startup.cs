using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TTracker.WebUI.Startup))]
namespace TTracker.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
