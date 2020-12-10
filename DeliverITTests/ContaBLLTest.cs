using System;
using TesteDeliverIT.BLL.Interfaces;
using TesteDeliverIT.DTO;
using Xunit;

namespace DeliverITTests
{
    public class ContaBLLTest
    {
        private readonly IContaBLL _contaBLL;
        public ContaBLLTest(IContaBLL contaBLL)
        {
            _contaBLL = contaBLL;
        }

        [Fact]
        public void Listagem_DeveObterValores()
        {
            var contas = _contaBLL.Get();
            Assert.True(contas.Count > 0);
        }

        [Fact]
        public void Insercao_DeveAplicarJurosCorretamente()
        {
            var conta = new ContaDTO()
            {
                Nome = "Conta Teste",
                DataVencimento = DateTime.Today,
                DataPagamento = DateTime.Today.AddDays(10),
                ValorOriginal = 100.0m
            };

            _contaBLL.Post(conta);

            Assert.True(conta.QtdDiasAtraso == 10 && conta.ValorCorrigido == 102m && conta.Id != Guid.Empty);
        }
    }
}
