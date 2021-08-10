using Globo.ServiceApi.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Application.Interfaces
{
    public interface IServiceApplication
    {
        Task<List<CDEEvents>> GetCDEWOs(int siteId, int rangeIni, int rangeFinal);
        Task<List<CDEEvents>> GetVeiculosWOs(int siteId, int rangeIni, int rangeFinal);
    }
}
