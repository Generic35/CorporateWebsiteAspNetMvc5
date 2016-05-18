using Microsoft.Owin;
using Owin;
using SitecoreReference.App_Start;

[assembly: OwinStartupAttribute(typeof(SitecoreReference.Startup))]
namespace SitecoreReference
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
