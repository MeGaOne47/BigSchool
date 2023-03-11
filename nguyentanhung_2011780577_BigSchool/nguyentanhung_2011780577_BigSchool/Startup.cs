using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyentanhung_2011780577_BigSchool.Startup))]
namespace nguyentanhung_2011780577_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
