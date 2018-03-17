using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire.MemoryStorage;
using Hangfire;
using Hangfire.Console;


[assembly: OwinStartup(typeof(Youtube_Comment_Downloader.Startup))]

namespace Youtube_Comment_Downloader
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseMemoryStorage();
            app.UseHangfireDashboard();
            app.UseHangfireServer();
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
