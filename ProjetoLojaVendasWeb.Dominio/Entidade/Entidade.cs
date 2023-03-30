using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoLojaVendasWeb.Dominio.Entidade
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao { get; set; }

        private List<string> mensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }
        protected void LimparMensagensValidacao() 
        {
            mensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem) 
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
