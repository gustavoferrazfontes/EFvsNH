using CineClick.SharedKernel;
using System;
using System.Collections.Generic;

namespace CineClick.Dominio.NHibernate.AgregadoDeProgramacao
{
    public class Programacao : RaizDeAgregado
    {
        private IList<Sessao> _sessoes;

        public virtual EF.PeriodoDeExibicao Exibicao { get; protected set; }

        public virtual IEnumerable<Sessao> Sessoes { get { return _sessoes; }  }

        protected Programacao()
        {
            
        }

        public Programacao(EF.PeriodoDeExibicao exibicao,List<Sessao> sessoes)
        {
            _sessoes = new List<Sessao>();
            Exibicao = exibicao;
            sessoes.ForEach(s => AdicionarSessao(s));
            
        }
     
        public virtual void SessaoIndisponivel(Sessao sessao)
        {
           _sessoes.Remove(sessao);  
        }

        public virtual void AdicionarSessao(Sessao sessao)
        {
            if (Exibicao.Disponivel())
                _sessoes.Add(sessao);
            else
                throw new InvalidOperationException("Essa programação não está disponivel");
        }
    }
}
