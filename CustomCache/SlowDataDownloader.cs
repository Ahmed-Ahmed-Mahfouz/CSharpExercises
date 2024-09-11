using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCache
{
    internal class SlowDataDownloader : IDataDownloader
    {
        public string DownloadData(string resourceId)
        {
            Thread.Sleep(1000);
            return $"Some data for {resourceId}";
        }
    }
    
}
