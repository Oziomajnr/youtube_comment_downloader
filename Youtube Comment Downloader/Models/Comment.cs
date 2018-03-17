using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Youtube_Comment_Downloader.Models
{
    public class Comment
    {
        public String userName { get; set; }
        public DateTime date { get; set; }

        public int numberOfStars { get; set; }

        public String link { get; set; }
    }
}