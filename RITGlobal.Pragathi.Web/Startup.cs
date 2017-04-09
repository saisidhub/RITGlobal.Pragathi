using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RITGlobal.Pragathi.Web.Startup))]
namespace RITGlobal.Pragathi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
