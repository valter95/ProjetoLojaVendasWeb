using ProjetoLojaVendasWeb.Dominio.Contratos;
using ProjetoLojaVendasWeb.Dominio.Entidade;
using ProjetoLojaVendasWeb.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(ProjetoLojaVendasWebContexto projetoLojaContexto) : base(projetoLojaContexto)
        {
        }
    }
}
