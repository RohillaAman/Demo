using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(My.MVCWeb.Startup))]
namespace My.MVCWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
