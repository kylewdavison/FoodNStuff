using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoonNStuff.MVC.Startup))]
namespace FoonNStuff.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
