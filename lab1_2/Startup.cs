using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab1_2.Startup))]
namespace lab1_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
