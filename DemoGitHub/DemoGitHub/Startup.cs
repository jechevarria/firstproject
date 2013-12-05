using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoGitHub.Startup))]
namespace DemoGitHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
