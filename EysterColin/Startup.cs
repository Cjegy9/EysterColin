using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EysterColin.Startup))]
namespace EysterColin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
