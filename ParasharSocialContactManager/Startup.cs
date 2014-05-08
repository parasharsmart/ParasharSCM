using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ParasharSocialContactManager.Startup))]
namespace ParasharSocialContactManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
