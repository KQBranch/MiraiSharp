using System;
using System.ComponentModel;
using System.IO;
using System.Net;

namespace MiraiSharp.Library.Net
{
    class SingleDownload
    {
        private long _downloadedBytes;
        public delegate void DownloadedBytesChange(object sender, EventArgs e);
        public event DownloadedBytesChange OnDownloadedBytesChange;
        public long TotalBytes { get; set; }

        public long DownloadedBytes
        {
            get => _downloadedBytes;
            set
            {
                OnDownloadedBytesChange(new object(), new EventArgs());
                _downloadedBytes = value;
            }
        }

        public double DownloadedPercent
        {
            get
            {
                if (TotalBytes == 0)
                    return 0.0;
                return 100.0 * DownloadedBytes / TotalBytes;
            }
        }
        public bool IsCompleted { get; set; } = false;

        public void StartDownload(string downloadLink, string path)
        {

            File.Delete(path);
            WebClient client = new WebClient();

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(Client_DownloadFileCompleted);

            client.DownloadFileAsync(new Uri(downloadLink), path);

        }

        void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            TotalBytes = e.TotalBytesToReceive;
            DownloadedBytes = e.BytesReceived;
        }

        void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            IsCompleted = true;
        }
    }
}
