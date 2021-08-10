using System.Threading.Tasks;

namespace Globo.ServiceApi.Services.Interfaces
{
    public interface IMediaPulseRestService 
    {
        Task<T> GetWOsAsync<T>(string url);
    }
}
