using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Youtube_Comment_Downloader.Models
{
    public class YoutubeCommentSnippet
    {
      public  String videoId { get; set; }
      public YoutubeComment topLevelComment { get; set; }
    }
}