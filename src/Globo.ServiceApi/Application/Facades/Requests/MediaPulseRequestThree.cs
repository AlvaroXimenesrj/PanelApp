using Globo.ServiceApi.Application.Facades.Requests.Interfaces;
using Globo.ServiceApi.Dtos;
using Globo.ServiceApi.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades.Requests
{
    public class MediaPulseRequestThree : IRequestThree
    {
        private readonly IMediaPulseRestService _restService;
        private Parameters _fileParams;
        public MediaPulseRequestThree(IMediaPulseRestService restService)
        {
            _restService = restService;
        }

        public void AddFiles(Parameters fileParam) => _fileParams = fileParam;

        public async Task<List<MediaPulseReturn>> MediaPulseRequest()
        {
            return await _restService.GetWOsAsync<List<MediaPulseReturn>>(_fileParams.RequestUrlThree);
        }
    }
}
