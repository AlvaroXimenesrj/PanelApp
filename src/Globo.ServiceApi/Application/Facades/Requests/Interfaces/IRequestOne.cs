using Globo.ServiceApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades.Requests.Interfaces
{
    public interface IRequestOne
    {
        Task<List<MediaPulseReturn>> MediaPulseRequest(string Url);
        //void AddFiles(Parameters fileParam);
    }
}
