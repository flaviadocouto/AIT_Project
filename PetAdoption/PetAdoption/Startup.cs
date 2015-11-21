using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PetAdoption.Startup))]
namespace PetAdoption
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
