using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamsTechSolutionMS.Startup))]
namespace DreamsTechSolutionMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
