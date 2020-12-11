using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace TesteDeliverIT.DTO
{
    public class ContaDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorCorrigido { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }
        public int QtdDiasAtraso { get; set; }
    }
}
