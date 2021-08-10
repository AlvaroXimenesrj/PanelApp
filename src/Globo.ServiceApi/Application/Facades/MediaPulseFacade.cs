using Globo.ServiceApi.Application.Facades.Interfaces;
using Globo.ServiceApi.Application.Facades.Requests.Interfaces;
using Globo.ServiceApi.Configurations;
using Globo.ServiceApi.Dtos;
using Microsoft.Extensions.Options;
using System.Linq;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades
{
    public class MediaPulseFacade : IMediaPulseFacade
    {
        private readonly IRequestOne _requestOne;
        private readonly IRequestTwo _requestTwo;
        private readonly IRequestThree _requestThree;
        private IOptions<AppSettings> _settings;
        private Parameters _params;

        public MediaPulseFacade(IRequestOne requestOne,
                                IRequestTwo requestTwo,
                                IRequestThree requestThree,
                                IOptions<AppSettings> settings)
        {
            _requestOne = requestOne;
            _requestTwo = requestTwo;
            _requestThree = requestThree;
            _settings = settings;
        }

        public void AddFiles(Parameters fileParam) => _params = fileParam;

        public async Task GetWos()
        {
            var resultOne = await _requestOne.MediaPulseRequest(_params.RequestUrlOne);

            if (resultOne.Count == 0) return;

            var wos = resultOne.Select(w => w.wo_no_seq.wo_no_seq).Distinct();

            _params.SetWosInQuery(wos.ToList());

            var resultTwo = await _requestTwo.MediaPulseRequest();

            var resultThree = await _requestThree.MediaPulseRequest();

        }
    }
}
