using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDeliverIT.DTO;
using Microsoft.Extensions.Logging;
using TesteDeliverIT.BLL.Interfaces;

namespace TesteDeliverIT.Api.Controllers
{
    [ApiController]
    public class ContaController : ControllerBase
    {
        private readonly IContaBLL _contaBLL;
        public ContaController(IContaBLL contaBLL)
        {
            _contaBLL = contaBLL;
        }

        [HttpGet]
        [Route("[controller]/Get")]
        public IEnumerable<ContaDTO> Get()
        {
            return _contaBLL.Get();
        }
        [HttpPost]
        [Route("[controller]/Post")]
        public void Post(ContaDTO conta)
        {
            _contaBLL.Post(conta);
        }
    }
}
