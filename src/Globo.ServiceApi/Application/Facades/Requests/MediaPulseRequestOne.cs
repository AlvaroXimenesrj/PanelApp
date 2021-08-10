using Globo.ServiceApi.Application.Facades.Requests.Interfaces;
using Globo.ServiceApi.Dtos;
using Globo.ServiceApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades.Requests
{   
    public class MediaPulseRequestOne : IRequestOne
    {
        private readonly IMediaPulseRestService _restService;
        //private Parameters _fileParams;
        public MediaPulseRequestOne(IMediaPulseRestService restService)
        {
            _restService = restService;
        }

        //public void AddFiles(Parameters fileParam) => _fileParams = fileParam;
        
        public async Task<List<MediaPulseReturn>> MediaPulseRequest(string Url)
        {
            return await _restService.GetWOsAsync<List<MediaPulseReturn>>(Url);
        }
    }
}
