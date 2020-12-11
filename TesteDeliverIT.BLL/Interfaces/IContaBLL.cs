using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.BLL.Interfaces
{
    public interface IContaBLL
    {
        Task<List<ContaDTO>> GetAsync();
        Task<ContaDTO> PostAsync(ContaDTO conta);
    }
}
