using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myNotes.Startup))]
namespace myNotes
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
