using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteDeliverIT.DAL.EntityTypeConfigurations;
using TesteDeliverIT.DTO;

namespace TesteDeliverIT.DAL.Models
{
    public class DeliverContext : DbContext
    {
        public DeliverContext(DbContextOptions<DeliverContext> options)
            : base(options)
        {
        }

        public DbSet<ContaDTO> Conta { get; set; }
        public DbSet<ContaAtrasoDTO> ContaAtraso { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ContaDTOEntityTypeConfiguration());
        }
    }
}
