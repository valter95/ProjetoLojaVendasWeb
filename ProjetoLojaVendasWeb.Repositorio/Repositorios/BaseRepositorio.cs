using ProjetoLojaVendasWeb.Dominio.Contratos;
using ProjetoLojaVendasWeb.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLojaVendasWeb.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly ProjetoLojaVendasWebContexto ProjetoLojaContexto;
        public BaseRepositorio(ProjetoLojaVendasWebContexto projetoLojaContexto)
        {
            ProjetoLojaContexto = projetoLojaContexto;

        }
        public void Adicionar(TEntity entity)
        {
            ProjetoLojaContexto.Set<TEntity>().Add(entity);
            ProjetoLojaContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            ProjetoLojaContexto.Set<TEntity>().Update(entity);
            ProjetoLojaContexto.SaveChanges();
        }

        public TEntity ObterPorId(int id)
        {
            return ProjetoLojaContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return ProjetoLojaContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            ProjetoLojaContexto.Set<TEntity>().Remove(entity);
            ProjetoLojaContexto.SaveChanges();
        }
        public void Dispose()
        {
            ProjetoLojaContexto.Dispose();
        }

    }
}
