using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.EF.AgregadoDeProgramacao
{
    public sealed class Sessao : Entidade
    {
        public  Guid FilmeId { get; private set; }
        public Guid SalaId { get; private set; }
        //public Guid ProgramacaoId { get; private set; }

        public  DateTime Data { get; private set; }
        
        public  int IngressosVendidos { get; private set; }
        public  bool Disponivel { get; private set; }
     

        private Sessao()
        {

        }

        public Sessao(Guid filmeId, Guid salaId, DateTime dataDaSessao, bool disponivel)
        {
            Id = Guid.NewGuid();
            FilmeId = filmeId;
            SalaId = salaId;
            Data = dataDaSessao;
            Disponivel = disponivel;
            IngressosVendidos = 0;
           
        }

      
    }
}
