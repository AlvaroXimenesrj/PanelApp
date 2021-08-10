using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Globo.ServiceApi.Services
{
    public static class HttpClientExtensions
    {
        internal static HttpClient AddAuthorizationHeader(this HttpClient client, string token, string schema)
        {
            if (!string.IsNullOrEmpty(token) && !string.IsNullOrEmpty(schema))
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(schema, token);

            return client;
        }

        internal static HttpClient AddHeaders(this HttpClient client, Dictionary<string, string> headers)
        {
            headers?
                .ToList()
                .ForEach(x =>
                {
                    if (client.DefaultRequestHeaders.Contains(x.Key))
                        client.DefaultRequestHeaders.Remove(x.Key);

                    client.DefaultRequestHeaders.Add(x.Key, x.Value);
                });

            return client;
        }
    }
}
