using System.Collections.Generic;

namespace MiraiSharp.Desktop.Models
{
    public class MiraiApiModel
    {
        public string[] Host { get; set; }

        private int Port;

        public string AuthKey { get; set; }
        public int cacheKey { get; set; }
        public bool EnableWebSocket { get; set; }
        public List<string> CORS { get; set; }

        public class ReportModel
        {
            public bool Enabled { get; set; }

        }
    }
}
