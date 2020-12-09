using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.DAO.Interfaces
{
    public interface IContaDAO
    {
        List<ContaDTO> Get();
        void Post(ContaDTO model);
    }
}
