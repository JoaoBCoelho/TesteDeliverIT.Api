using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDeliverIT.DTO;
using Microsoft.Extensions.Logging;
using TesteDeliverIT.BLL.Interfaces;
using Microsoft.AspNetCore.Cors;

namespace TesteDeliverIT.Api.Controllers
{
    public class ContaController : ControllerBase
    {
        private readonly IContaBLL _contaBLL;
        public ContaController(IContaBLL contaBLL)
        {
            _contaBLL = contaBLL;
        }

        [HttpGet]
        [Route("[controller]/Get")]
        public async Task<IEnumerable<ContaDTO>> Get()
        {
            return await _contaBLL.GetAsync();
        }

        [HttpPost]
        [Route("[controller]/Post")]
        public async Task<ContaDTO> Post([FromBody] ContaDTO conta)
        {
            return await _contaBLL.PostAsync(conta);
        }
    }
}
