using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Membership_app.Startup))]
namespace Membership_app
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
