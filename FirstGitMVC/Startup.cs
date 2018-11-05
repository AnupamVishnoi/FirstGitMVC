using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstGitMVC.Startup))]
namespace FirstGitMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
