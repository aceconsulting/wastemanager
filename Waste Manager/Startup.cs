using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Waste_Manager.Startup))]
namespace Waste_Manager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
