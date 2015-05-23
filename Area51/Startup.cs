using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Area51.Startup))]
namespace Area51
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
