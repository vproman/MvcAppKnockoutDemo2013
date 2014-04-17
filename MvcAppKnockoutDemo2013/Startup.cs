using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAppKnockoutDemo2013.Startup))]
namespace MvcAppKnockoutDemo2013
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
