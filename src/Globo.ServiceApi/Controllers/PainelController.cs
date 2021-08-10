using Globo.ServiceApi.Application.Interfaces;
using Globo.ServiceApi.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Globo.ServiceApi.Controllers
{
    [Route("/api")]
    [ApiController]
    public class PainelController : Controller
    {
        private readonly IServiceApplication _appService;
        
        public PainelController(IServiceApplication appService)
        {
            _appService = appService;
        }

        [HttpGet]
        //[Authorize]
        [Route("cde/{hourInitial}/{hourFinal}/{id}")]
        [ProducesResponseType(typeof(IEnumerable<CDEEvents>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CDEEvents>>> GetCDE(int hourInitial, int hourFinal, int id)
        {
            var cdeEvents = await _appService.GetCDEWOs(id, hourInitial, hourFinal);
           
            return Ok(cdeEvents);
        }
    }
}
