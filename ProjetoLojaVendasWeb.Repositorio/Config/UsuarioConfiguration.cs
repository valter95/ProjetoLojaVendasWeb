using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoLojaVendasWeb.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Repositorio.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            
            //Builder Utiliza o padrão Fluent 
            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(100)");

            builder
                .Property(u => u.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .Property(u => u.SobreNome)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnType("varchar(100)");

            builder
                .HasMany(u => u.Pedidos)
                .WithOne(p => p.Usuario);
        }
    }
}
