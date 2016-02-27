using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AllBanksDiploma.Startup))]
namespace AllBanksDiploma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
