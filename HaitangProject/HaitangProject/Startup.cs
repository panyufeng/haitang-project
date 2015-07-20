using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HaitangProject.Startup))]
namespace HaitangProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
