using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamIes.TorrentDownloader
{
    class Searcher
    {
        private String hostUrl = "http://kickass.to/usearch/";


    }

    class Torrent
    {
        private String href { get; set; }
        private float size { get; set; }
        private String title { get; set; }
        private String age { get; set; }
        private int seeders { get; set; }
        private int leechers { get; set; }
    }
}
