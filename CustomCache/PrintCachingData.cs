using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache
{
    internal class PrintCachingData : IDataDownloader
    {
        private readonly IDataDownloader _downloader;

        public PrintCachingData(IDataDownloader downloader)
        {
            _downloader = downloader;
        }

        public string DownloadData(string resourceId)
        {
            var data = _downloader.DownloadData(resourceId);
            Console.WriteLine("Data is ready!");
            return data;
        }
    }
}
