using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dejt.Startup))]
namespace Dejt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
