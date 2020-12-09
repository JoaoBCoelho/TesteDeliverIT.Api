using System;
using System.Collections.Generic;
using TesteDeliverIT.BLL.Interfaces;
using TesteDeliverIT.DAL.DAO;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.BLL
{
    public class ContaBLL : IContaBLL
    {
        private readonly IContaDAO _contaDAO;
        public ContaBLL(IContaDAO contaDAO)
        {
            _contaDAO = contaDAO;
        }

        public List<ContaDTO> Get()
        {
            return _contaDAO.Get();
        }

        public void Post(ContaDTO conta)
        {
            _contaDAO.Post(conta);
        }
    }
}
