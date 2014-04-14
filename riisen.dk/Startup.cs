using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(riisen.dk.Startup))]
namespace riisen.dk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
