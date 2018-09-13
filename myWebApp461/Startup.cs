using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myWebApp461.Startup))]
namespace myWebApp461
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
