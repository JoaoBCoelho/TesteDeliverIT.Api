using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DTO;

namespace DeliverITTests.Dependencies
{
    public class ContaDAOMock : IContaDAO
    {
        public async Task<List<ContaDTO>> GetAsync()
        {
            return await Task.Run(() =>
            {
                return new List<ContaDTO>()
                {
                    new ContaDTO(){
                        Nome = "conta 1",
                        QtdDiasAtraso = 0,
                        DataPagamento = DateTime.Today,
                        DataVencimento = DateTime.Today.AddDays(3),
                        ValorOriginal = 100,
                        ValorCorrigido = 100
                    },
                    new ContaDTO(){
                        Nome = "conta 2",
                        QtdDiasAtraso = 0,
                        DataPagamento = DateTime.Today,
                        DataVencimento = DateTime.Today.AddDays(3),
                        ValorOriginal = 200,
                        ValorCorrigido = 200
                    }
                };
            });

        }

        public async Task<ContaDTO> PostAsync(ContaDTO model)
        {
            return await Task.Run(() =>
            {
                model.Id = Guid.NewGuid();
                return model;
            });
        }
    }
}
