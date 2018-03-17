using System;


namespace Youtube_Comment_Downloader.Models
{
    public class TopLevelCommentSnippet
    {
        public String authorDisplayName { get; set; }
        public String textDisplay { get; set; }
        public int likeCount { get; set; }
        public DateTime publishedAt { get; set; }
    }
}