using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSS_System.Startup))]
namespace SSS_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
