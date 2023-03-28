using ProjetoLojaVendasWeb.Dominio.Entidade.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Dominio.Entidade
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
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
    }
}
