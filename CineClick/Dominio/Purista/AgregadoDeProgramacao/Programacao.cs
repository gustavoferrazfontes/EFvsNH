using CineClick.SharedKernel;
using System;
using System.Collections.Generic;

namespace CineClick.Dominio.Puro.AgregadoDeProgramacao
{
    public sealed class Programacao : RaizDeAgregado
    {
        private IList<Sessao> _sessoes;

        public  PeriodoDeExibicao Exibicao { get; private set; }

        public  IEnumerable<Sessao> Sessoes { get { return _sessoes; }  }

        public Programacao(PeriodoDeExibicao exibicao,List<Sessao> sessoes)
        {
            _sessoes = new List<Sessao>();
            Exibicao = exibicao;
            sessoes.ForEach(s => AdicionarSessao(s));
            
        }
     
        public  void SessaoIndisponivel(Sessao sessao)
        {
           _sessoes.Remove(sessao);  
        }

        public  void AdicionarSessao(Sessao sessao)
        {
            if (Exibicao.Disponivel())
                _sessoes.Add(sessao);
            else
                throw new InvalidOperationException("Essa programação não está disponivel");
        }
    }
}
