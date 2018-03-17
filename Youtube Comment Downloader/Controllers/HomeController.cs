using System.Web.Mvc;
using Youtube_Comment_Downloader.service;

namespace Youtube_Comment_Downloader.Controllers
{
    public class HomeController : Controller
    {
        public IYoutubeCommentDownloader YoutubeCommentDownloader = new YoutubeCommentDowloader();
      
        public ActionResult Index()
        {
            YoutubeCommentDownloader.downloadComment("biatch");
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
