

using Ninject.Modules;
using Youtube_Comment_Downloader.service;

namespace Youtube_Comment_Downloader.Util
{
    public class CommentDownloaderModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IYoutubeCommentDownloader>().To<YoutubeCommentDowloader>();
        }
    }
}