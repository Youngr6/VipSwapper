using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kaleidoscope.Startup))]
namespace Kaleidoscope
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
