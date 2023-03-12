using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HuynhNhatTruong_2080600759.Startup))]
namespace HuynhNhatTruong_2080600759
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
