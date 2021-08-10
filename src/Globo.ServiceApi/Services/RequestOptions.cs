using System.Collections.Generic;

namespace Globo.ServiceApi.Services
{
    public class RequestOptions
    {
        public Dictionary<string, string> Headers { get; set; }

        public string Token { get; set; }

        public string Schema { get; set; }
    }
}
