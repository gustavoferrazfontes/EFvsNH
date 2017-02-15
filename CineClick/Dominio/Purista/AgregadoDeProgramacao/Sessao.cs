using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.Puro.AgregadoDeProgramacao
{
    public sealed class Sessao : Entidade
    {
        public  Guid FilmeId { get; private set; }
        public  Guid SalaId { get; private set; }

        public  DateTime Data { get; private set; }
        

        public  int IngressosVendidos { get; private set; }
        public  bool Disponivel { get; private set; }

   
        public Sessao(Guid salaId,Guid filmeId, DateTime dataDaSessao, bool disponivel)
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
