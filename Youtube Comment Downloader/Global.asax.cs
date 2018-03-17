using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Hangfire.MemoryStorage;
using Hangfire.Console;
namespace Youtube_Comment_Downloader
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Just discover what configuration options do you have.
            Hangfire.GlobalConfiguration.Configuration.UseMemoryStorage();
            Hangfire.GlobalConfiguration.Configuration.UseConsole();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

        }
    }
}
