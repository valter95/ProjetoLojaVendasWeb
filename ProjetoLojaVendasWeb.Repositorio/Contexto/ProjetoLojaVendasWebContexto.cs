using Microsoft.EntityFrameworkCore;
using ProjetoLojaVendasWeb.Dominio.Entidade;
using ProjetoLojaVendasWeb.Dominio.Entidade.ObjetoDeValor;
using ProjetoLojaVendasWeb.Repositorio.Config;

namespace ProjetoLojaVendasWeb.Repositorio.Contexto
{
    public class ProjetoLojaVendasWebContexto : DbContext
    {
        public ProjetoLojaVendasWebContexto( DbContextOptions options) : base(options)
        {
        }

        //Usuarios no plural será criado na base de dados
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Classes de mapeamento aqui....
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            modelBuilder.Entity<FormaPagamento>().HasData(
                new FormaPagamento() { 
                    Id = 1, 
                    Nome = "Boleto", 
                    Descricao = "Forma de pagamento Boleto"},
                new FormaPagamento()
                {
                    Id = 2,
                    Nome = "Cartão de Crédito",
                    Descricao = "Forma de pagamento Cartão de Crédito"
                },
                new FormaPagamento()
                {
                    Id = 3,
                    Nome = "Depósito",
                    Descricao = "Forma de pagamento Depósito"
                });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
