using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhoneOnlineShop.Startup))]
namespace PhoneOnlineShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
