using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using UngDungDocBao.Models;

namespace UngDungDocBao.RssFeed
{
    public class RssReader
    {
        private readonly NewsParse _parser;

        public RssReader(NewsParse parser)
        {
            _parser = parser;
        }

        public List<Article> GetNews(string rssLink)
        {
            var feedData = DownloadFeed(rssLink);
            return _parser.ParseXml(feedData);
        }

        private string DownloadFeed(string rssLink)
        {
            var client = new WebClient()
            {
                Encoding = Encoding.UTF8
            };
            return client.DownloadString(rssLink);
        }
    }
}
