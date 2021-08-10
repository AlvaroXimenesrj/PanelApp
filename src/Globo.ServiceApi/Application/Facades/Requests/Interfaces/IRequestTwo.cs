using Globo.ServiceApi.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades.Requests.Interfaces
{
    public interface IRequestTwo
    {
        Task<List<MediaPulseReturn>> MediaPulseRequest();
        void AddFiles(Parameters fileParam);
    }
}
