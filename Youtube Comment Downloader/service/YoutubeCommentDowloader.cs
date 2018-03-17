using CsvHelper;
using Hangfire;
using RestSharp;
using RestSharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using Youtube_Comment_Downloader.Models;

namespace Youtube_Comment_Downloader.service
{
    public class YoutubeCommentDowloader : IYoutubeCommentDownloader
    {
        public void downloadComment(string url)
        {
            var jobId = BackgroundJob.Enqueue(
            () => startTask(url)
            );      

        }
        public static void startTask(String url) {
            var client = new RestClient("https://www.googleapis.com/youtube/v3");
            var request = new RestRequest("commentThreads", Method.GET);
            request.AddParameter("part", "snippet"); 
            request.AddParameter("videoId", "IyXUuxn-66M");
            request.AddParameter("key", "AIzaSyAYa0AeA_7lRO46PyTg2P0j7lyGe5P5wyA");
            request.AddParameter("maxResults", 100);
            String nextPageToken = null;
            int dataCount = 1;
            List<YoutubeCommentItem> comments = new List<YoutubeCommentItem>();
            do
            {
                if (nextPageToken != null)
                {
                    request.AddParameter("pageToken", nextPageToken);
                }
                client.DownloadData(request).SaveAs(@"C:\dev\data" + dataCount);
                IRestResponse<YoutubeResponse> response2 = client.Execute<YoutubeResponse>(request);
                System.Diagnostics.Debug.WriteLine(response2.Data.nextPageToken);
                nextPageToken = response2.Data.nextPageToken;
                dataCount++;
                comments.AddRange(response2.Data.items);
            }
            while (nextPageToken != null);
            WriteToCsv(comments);

        }

        private static void WriteToCsv (List<YoutubeCommentItem>  comments)
        {
            CsvWriter csv = null;
            try
            {
                FileInfo fileInfo = new FileInfo(@"C:\dev\data.csv");
                StreamWriter textWriter = fileInfo.CreateText();
                var records = comments;
                csv = new CsvWriter(textWriter);
                csv.WriteRecords(records);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (csv != null)
                {
                    csv.Flush();
                }
            }
        }

    }
}