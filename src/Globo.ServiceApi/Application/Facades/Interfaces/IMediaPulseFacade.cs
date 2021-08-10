using Globo.ServiceApi.Dtos;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Facades.Interfaces
{
    public interface IMediaPulseFacade
    {
        Task GetWos();
        void AddFiles(Parameters fileParam);
    }
}
