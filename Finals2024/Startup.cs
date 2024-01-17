using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Finals2024.Startup))]
namespace Finals2024
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
