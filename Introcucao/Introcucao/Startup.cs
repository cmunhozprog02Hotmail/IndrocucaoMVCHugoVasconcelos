using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introcucao.Startup))]
namespace Introcucao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
