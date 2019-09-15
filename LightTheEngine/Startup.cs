using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LightTheEngine.Startup))]
namespace LightTheEngine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
