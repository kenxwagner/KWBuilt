using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(edisonFinder.Startup))]
namespace edisonFinder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
