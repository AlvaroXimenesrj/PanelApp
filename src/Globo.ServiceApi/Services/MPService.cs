using Globo.ServiceApi.Configurations;
using Globo.ServiceApi.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Services
{
    public class MPService : IMediaPulseRestService
    {
        private HttpClient _httpClient;
        private IOptions<AppSettings> _settings;
        public MPService(IOptions<AppSettings> settings)
        {
            _httpClient = new HttpClient();
            _settings = settings;
        }


        public async Task<T> GetWOsAsync<T>(string url)
        {
            var result = await GetAsync<T>(url);

            return result;
        }

        private async Task<T> GetAsync<T>(string urlService)
        {

            var byteArray = Encoding.ASCII.GetBytes(_settings.Value.UserLoginPassword);

            var response = await GetAsync($"{urlService}", new RequestOptions { Schema = "Basic", Token = Convert.ToBase64String(byteArray) });

            var resp = await response.Content.ReadAsStringAsync();

            //var wos = JsonConvert.DeserializeObject<T>(resp);
            var wos = JsonSerializer.Deserialize<T>(resp);

            return wos;
        }

        private async Task<HttpResponseMessage> GetAsync(string endpoint, RequestOptions requestOptions = null)
            => await _httpClient
            .AddAuthorizationHeader(requestOptions?.Token, requestOptions?.Schema)
            .GetAsync(endpoint);
    }
}
