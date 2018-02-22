using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClaytonsProperties.Startup))]
namespace ClaytonsProperties
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
