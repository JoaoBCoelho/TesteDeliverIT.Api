using System;
using System.Collections.Generic;
using System.Text;

namespace TesteDeliverIT.DTO
{
    public class ContaAtrasoDTO
    {
        public Guid Id { get; set; }
        public int DiaMinimoAtraso { get; set; }
        public decimal PorcentagemMulta { get; set; }
        public decimal JurosPorDia { get; set; }
    }
}
