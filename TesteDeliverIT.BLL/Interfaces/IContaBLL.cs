using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.BLL.Interfaces
{
    public interface IContaBLL
    {
        List<ContaDTO> Get();
        ContaDTO Post(ContaDTO conta);
    }
}
