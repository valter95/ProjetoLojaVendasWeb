using System.Collections.Generic;

namespace ProjetoLojaVendasWeb.Dominio.Entidade
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        //Usuario pode ter 1 ou * pedidos
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
