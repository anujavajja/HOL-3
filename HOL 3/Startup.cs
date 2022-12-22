using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HOL_3.Startup))]
namespace HOL_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
