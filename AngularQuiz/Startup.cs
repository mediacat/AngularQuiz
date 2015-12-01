using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngularQuiz.Startup))]
namespace AngularQuiz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
