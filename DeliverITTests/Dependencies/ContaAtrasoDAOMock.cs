using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DTO;

namespace DeliverITTests.Dependencies
{
    public class ContaAtrasoDAOMock : IContaAtrasoDAO
    {
        public ContaAtrasoDTO Get(int qtdDiasAtraso)
        {
            return new ContaAtrasoDTO()
            {
                DiaMinimoAtraso = 1,
                JurosPorDia = 0.1m,
                PorcentagemMulta = 1
            };
        }
    }
}
