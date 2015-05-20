using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyInstaPrepWebApp.Startup))]
namespace MyInstaPrepWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
