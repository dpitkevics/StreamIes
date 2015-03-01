using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using HtmlAgilityPack;
using StreamIes.TorrentDownloader;

namespace StreamIes.TorrentDownloader
{
    public class TorrentSearcher
    {
        private String hostUrl = "http://kickass.to/usearch/";

        public void MakeSearchAndDownload(String query)
        {
            String requestUrl = this.hostUrl + query + "/";
            HttpDownloader httpDownloader = new HttpDownloader(requestUrl, "", "");

            String html = httpDownloader.GetPage();

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            HtmlNode node = htmlDoc.DocumentNode.SelectSingleNode("//a[@class='idownload icon16']");

            String torrentUrl = node.Attributes["href"].Value;
            String torrentTitle = torrentUrl.Substring(torrentUrl.IndexOf("?title=", 0) + "?title=".Length);

            WebClient client = new WebClient();

            try
            {
                String saveFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\.StriemIes";
                if (!Directory.Exists(saveFolder))
                {
                    Directory.CreateDirectory(saveFolder);
                }

                client.DownloadFile(new Uri(torrentUrl), saveFolder + "\\" + torrentTitle + ".torrent");
            }
            catch (Exception exception)
            {
                while (exception != null)
                {
                    Console.WriteLine(exception.Message);
                    exception = exception.InnerException;
                }
            }
        }
    }

    public class Torrent
    {
        private String href { get; set; }
        private float size { get; set; }
        private String title { get; set; }
        private String age { get; set; }
        private int seeders { get; set; }
        private int leechers { get; set; }
    }
}
