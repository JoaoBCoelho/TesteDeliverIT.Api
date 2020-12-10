using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DTO;

namespace DeliverITTests.Dependencies
{
    public class ContaDAOMock : IContaDAO
    {
        public List<ContaDTO> Get()
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
        }

        public ContaDTO Post(ContaDTO model)
        {
            model.Id = Guid.NewGuid();
            return model;
        }
    }
}
