using System.Web;
using System.Web.Mvc;

namespace Youtube_Comment_Downloader
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
