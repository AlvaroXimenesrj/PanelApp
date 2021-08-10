using Globo.ServiceApi.Application.Facades.Interfaces;
using Globo.ServiceApi.Application.Facades.Requests.Interfaces;
using Globo.ServiceApi.Application.Interfaces;
using Globo.ServiceApi.Configurations;
using Globo.ServiceApi.Dtos;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application
{
    public class ServiceApplication : IServiceApplication
    {
        private Parameters _params;
        private readonly IMediaPulseFacade _facade;
        private IOptions<AppSettings> _settings;
        public ServiceApplication(IOptions<AppSettings> settings, IMediaPulseFacade facade)
        {
            _settings = settings;
            _params = new Parameters(_settings);
            _facade = facade;
        }
        public async Task<List<CDEEvents>> GetCDEWOs(int siteId, int rangeIni, int rangeFinal)
        {
            _params.BuildCDEParams(siteId, rangeIni, rangeFinal);
            _facade.AddFiles(_params);
            await _facade.GetWos();


        }
    }
}
