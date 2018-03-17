using System;


namespace Youtube_Comment_Downloader.service
{
    public interface IYoutubeCommentDownloader
    {
        void downloadComment(String url);
    }
}
