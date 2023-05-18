using ProjetoLojaVendasWeb.Dominio.Contratos;
using ProjetoLojaVendasWeb.Dominio.Entidade;
using ProjetoLojaVendasWeb.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoLojaVendasWeb.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProjetoLojaVendasWebContexto projetoLojaContexto) : base(projetoLojaContexto)
        {

        }
    }
}
