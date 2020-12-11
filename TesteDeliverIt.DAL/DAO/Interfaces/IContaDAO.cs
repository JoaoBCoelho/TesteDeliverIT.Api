using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.DAO.Interfaces
{
    public interface IContaDAO
    {
        Task<List<ContaDTO>> GetAsync();
        Task<ContaDTO> PostAsync(ContaDTO model);
    }
}
