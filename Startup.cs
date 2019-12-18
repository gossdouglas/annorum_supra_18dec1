using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(annorum_supra_18dec.Startup))]
namespace annorum_supra_18dec
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
