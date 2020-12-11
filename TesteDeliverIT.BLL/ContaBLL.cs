using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteDeliverIT.BLL.Interfaces;
using TesteDeliverIT.DAL.DAO;
using TesteDeliverIT.DAL.DAO.Interfaces;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.BLL
{
    public class ContaBLL : IContaBLL
    {
        private readonly IContaDAO _contaDAO;
        private readonly IContaAtrasoDAO _contaAtrasoDAO;
        public ContaBLL(IContaDAO contaDAO, IContaAtrasoDAO contaAtrasoDAO)
        {
            _contaDAO = contaDAO;
            _contaAtrasoDAO = contaAtrasoDAO;
        }

        public async Task<List<ContaDTO>> GetAsync()
        {
            return await _contaDAO.GetAsync();
        }

        public async Task<ContaDTO> PostAsync(ContaDTO conta)
        {
            CalcularValoresAtraso(conta);

            return await _contaDAO.PostAsync(conta);
        }

        private void CalcularValoresAtraso(ContaDTO conta)
        {
            if (conta.DataPagamento <= conta.DataVencimento)
            {
                conta.QtdDiasAtraso = 0;
                conta.ValorCorrigido = conta.ValorOriginal;
                return;
            }

            conta.QtdDiasAtraso = (conta.DataPagamento - conta.DataVencimento).Days;
            var atraso = _contaAtrasoDAO.Get(conta.QtdDiasAtraso);

            if (atraso == null)
            {
                conta.ValorCorrigido = conta.ValorOriginal;
                return;
            }

            var valorComMulta = conta.ValorOriginal + (conta.ValorOriginal * (atraso.PorcentagemMulta / 100));
            conta.ValorCorrigido = Math.Round(valorComMulta + (conta.ValorOriginal * (conta.QtdDiasAtraso * (atraso.JurosPorDia / 100))), 2);
        }
    }
}
