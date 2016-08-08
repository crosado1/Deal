using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(deal.ui.Startup))]
namespace deal.ui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
