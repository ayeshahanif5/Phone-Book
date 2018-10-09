using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Phone.Startup))]
namespace Phone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
