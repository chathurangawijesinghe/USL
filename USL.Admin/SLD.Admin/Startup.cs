using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SLD.Admin.Startup))]
namespace SLD.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
