using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiApp_001.Startup))]
namespace WebApiApp_001
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}