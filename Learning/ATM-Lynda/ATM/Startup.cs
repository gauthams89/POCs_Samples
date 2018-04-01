using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ATM.Startup))]
namespace ATM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
