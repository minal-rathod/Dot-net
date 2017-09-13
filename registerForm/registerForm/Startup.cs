using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(registerForm.Startup))]
namespace registerForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
