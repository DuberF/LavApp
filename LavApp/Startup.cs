using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LavApp.Startup))]
namespace LavApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
