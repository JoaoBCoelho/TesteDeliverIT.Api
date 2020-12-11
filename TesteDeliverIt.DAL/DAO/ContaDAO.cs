using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<List<ContaDTO>> GetAsync()
        {
            return await _dbContext.Conta.ToListAsync();
        }

        public async Task<ContaDTO> PostAsync(ContaDTO model)
        {
            await _dbContext.Conta.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            return model;
        }
    }
}
