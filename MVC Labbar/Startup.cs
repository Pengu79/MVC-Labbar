using Microsoft.Owin;
using MVC_Labbar;
using Owin;

[assembly: OwinStartup(typeof (Startup))]

namespace MVC_Labbar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}