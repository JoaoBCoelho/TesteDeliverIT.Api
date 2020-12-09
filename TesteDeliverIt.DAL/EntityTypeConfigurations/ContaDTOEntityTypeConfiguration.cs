using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.EntityTypeConfigurations
{
    public class ContaDTOEntityTypeConfiguration : IEntityTypeConfiguration<ContaDTO>
    {
        public void Configure(EntityTypeBuilder<ContaDTO> builder)
        {
            builder.ToTable("Conta");

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
