using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TransparencyInformation.Startup))]
namespace TransparencyInformation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
