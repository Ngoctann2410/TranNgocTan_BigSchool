using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TranNgocTan_BigSchool.Startup))]
namespace TranNgocTan_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
