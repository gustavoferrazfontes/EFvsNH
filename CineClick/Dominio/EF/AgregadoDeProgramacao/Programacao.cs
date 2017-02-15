using CineClick.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CineClick.Dominio.EF.AgregadoDeProgramacao
{
    public class Programacao : RaizDeAgregado
    {
        public static Expression<Func<Programacao, ICollection<Sessao>>> SessaoExpresson = f => f._Sessoes;

        protected virtual ICollection<Sessao> _Sessoes { get; set; }

        public  IEnumerable<Sessao> Sessoes
        {
            get { return _Sessoes.ToList(); }
        }

        public  PeriodoDeExibicao Exibicao { get; private set; }
        private Programacao()
        {
            
        }

        public Programacao(PeriodoDeExibicao exibicao,List<Sessao> sessoes)
        {
            Id = Guid.NewGuid();
            Exibicao = exibicao;
            _Sessoes = sessoes;
        }
     
        public  void SessaoIndisponivel(Sessao sessao)
        {
           _Sessoes.Remove(sessao);  
        }

        public  void AdicionarSessao(Sessao sessao)
        {
            if (Exibicao.Disponivel())
                _Sessoes.Add(sessao);
            else
                throw new InvalidOperationException("Essa programação não está disponivel");
        }


         
    }
}
                                                        