using ProjetoLojaVendasWeb.Dominio.Entidade.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLojaVendasWeb.Dominio.Entidade
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }

        //Pedido deve Ter 1 ou * ItensPedido
        public ICollection<ItemPedido> ItensPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedidos.Any())
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de Pedido");
            if(string.IsNullOrEmpty(CEP))
                AdicionarCritica("Crítica - CEP deve estar preenchido");
            if (FormaPagamentoId == 0)
                AdicionarCritica("Crítica - Não foi informado a forma de pagamento");

        }
    }
}
