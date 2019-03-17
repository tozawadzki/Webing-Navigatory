using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B2TomaszZawadzkiZadDom6.Startup))]
namespace B2TomaszZawadzkiZadDom6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
