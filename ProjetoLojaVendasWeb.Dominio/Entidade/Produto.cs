using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Dominio.Entidade
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("O nome do produto não pode ser vázio");
            if (Preco < 0)
                AdicionarCritica("O valor não pode ser menor que 0");
        }
    }
}
