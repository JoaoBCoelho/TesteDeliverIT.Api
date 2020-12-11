using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.DAO.Interfaces
{
    public interface IContaAtrasoDAO
    {
        ContaAtrasoDTO Get(int qtdDiasAtraso);
    }
}
