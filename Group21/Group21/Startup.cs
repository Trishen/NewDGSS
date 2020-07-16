using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Group21.Startup))]
namespace Group21
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
