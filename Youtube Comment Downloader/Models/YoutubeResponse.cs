using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Youtube_Comment_Downloader.Models
{
    public class YoutubeResponse
    {
        public String kind { get; set; }
        public String etag { get; set; }
        public String nextPageToken { get; set; }

        public List<YoutubeCommentItem> items { get; set; }
    }
}


  
//{
// "kind": "youtube#commentThreadListResponse",
// "etag": "\"RmznBCICv9YtgWaaa_nWDIH1_GM/CSgX5nYreUM1PV4qEAKJCxsa4C8\"",
// "nextPageToken": "QURTSl9pMHBkMjBtNmlVTWJLZzU0OG5rQXAwMF9LWklTTldKb0ZMTEl6WnlNNEhlcWozazc5N3pZci1GRS0zM2RCdFVrTTVlUVZmSy0tb0s2Rkt2SkZFNVRLaFM3Yi1vTHFMZGlSQ0NnNzVLY200aDBJRWliVEdGSU53RWNBaC0=",
// "pageInfo": {
//  "totalResults": 100,
//  "resultsPerPage": 100
// },
// "items": [
//  {


//   "kind": "youtube#commentThread",
//   "etag": "\"RmznBCICv9YtgWaaa_nWDIH1_GM/BNnAMCFtylXJZWkcr4A-5foEyIk\"",
//   "id": "UgylSg7Lw3bP8T-i2FR4AaABAg",
//   "snippet": {
//    "videoId": "xpVfcZ0ZcFM",
//    "topLevelComment": {
//     "kind": "youtube#comment",
//     "etag": "\"RmznBCICv9YtgWaaa_nWDIH1_GM/hjx-8tD0JbWPOoKoCdwqcJYEi5w\"",
//     "id": "UgylSg7Lw3bP8T-i2FR4AaABAg",
//     "snippet": {
//      "authorDisplayName": "Mario Grieco",
//      "authorProfileImageUrl": "https://yt3.ggpht.com/-gAVkXpOg1Ww/AAAAAAAAAAI/AAAAAAAAAAA/akKcQx3jO6o/s28-c-k-no-mo-rj-c0xffffff/photo.jpg",
//      "authorChannelUrl": "http://www.youtube.com/channel/UCBC9W2rn7aMamqVDlzPWMsA",
//      "authorChannelId": {
//       "value": "UCBC9W2rn7aMamqVDlzPWMsA"
//      },
//      "videoId": "xpVfcZ0ZcFM",
//      "textDisplay": "Drake plays FORTNITE.😂😂😂",
//      "textOriginal": "Drake plays FORTNITE.😂😂😂",
//      "canRate": true,
//      "viewerRating": "none",
//      "likeCount": 1,
//      "publishedAt": "2018-03-15T13:53:55.000Z",
//      "updatedAt": "2018-03-15T13:53:55.000Z"
//     }
//    },
//    "canReply": true,
//    "totalReplyCount": 0,
//    "isPublic": true
//   }
//  },