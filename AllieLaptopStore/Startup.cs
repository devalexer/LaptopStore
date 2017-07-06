using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllieLaptopStore.Startup))]
namespace AllieLaptopStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
