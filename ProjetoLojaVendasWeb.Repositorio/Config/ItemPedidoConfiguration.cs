using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoLojaVendasWeb.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Repositorio.Config
{
   public class ItemPedidoConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(i => i.Id);

            builder
                .Property(i => i.ProdutoId)
                .IsRequired();
            builder
                .Property(i => i.Quantidade)
                .IsRequired();
        }
    }
}
