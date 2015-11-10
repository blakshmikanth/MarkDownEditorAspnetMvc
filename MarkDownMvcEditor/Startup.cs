using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkDownMvcEditor.Startup))]
namespace MarkDownMvcEditor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
