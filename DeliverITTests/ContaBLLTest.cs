using System;
using System.Threading.Tasks;
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
        public async Task Listagem_DeveObterValores()
        {
            var contas = await _contaBLL.GetAsync();
            Assert.True(contas.Count > 0);
        }

        [Fact]
        public async Task Insercao_DeveAplicarJurosCorretamente()
        {
            var conta = new ContaDTO()
            {
                Nome = "Conta Teste",
                DataVencimento = DateTime.Today,
                DataPagamento = DateTime.Today.AddDays(10),
                ValorOriginal = 100.0m
            };

            await _contaBLL.PostAsync(conta);

            Assert.True(conta.QtdDiasAtraso == 10 && conta.ValorCorrigido == 102m && conta.Id != Guid.Empty);
        }
    }
}
