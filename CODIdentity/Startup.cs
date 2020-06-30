using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CODIdentity.Startup))]
namespace CODIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
