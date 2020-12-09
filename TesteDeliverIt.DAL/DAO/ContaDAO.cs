using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DAL.Models;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.DAO
{
    public class ContaDAO : IContaDAO
    {
        private readonly DeliverContext _dbContext;

        public ContaDAO(DeliverContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ContaDTO> Get()
        {
            return _dbContext.Conta.ToList();
        }

        public void Post(ContaDTO model)
        {
            _dbContext.Conta.Add(model);
            _dbContext.SaveChanges();
        }
    }
}
