using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DAL.Models;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.DAO
{
    public class ContaAtrasoDAO : IContaAtrasoDAO
    {
        private readonly DeliverContext _dbContext;

        public ContaAtrasoDAO(DeliverContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ContaAtrasoDTO Get(int qtdDiasAtraso)
        {
            return _dbContext.ContaAtraso.Where(w=> w.DiaMinimoAtraso <= qtdDiasAtraso)
                                            .OrderByDescending(o=> o.DiaMinimoAtraso)
                                            .FirstOrDefault();
        }
    }
}
