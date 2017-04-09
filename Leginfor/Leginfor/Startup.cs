using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Leginfor.Startup))]
namespace Leginfor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
