using DashTelecom.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DashTelecom.Infrastructure.Mappings
{
    public class TelecomOperadorasMapping : IEntityTypeConfiguration<TabTelecomOperadoras>
    {
        public void Configure(EntityTypeBuilder<TabTelecomOperadoras> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Rota)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(p => p.Operadora)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(p => p.Tipo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Pag_sub)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(p => p.Tecnologia)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Operadora_ftr)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.ToTable("TabTelecomOperadoras");
        }
    }
}


