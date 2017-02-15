using CineClick.SharedKernel;
using System;
using System.Collections.Generic;

namespace CineClick.Dominio.EF.AgregadoDeProgramacao
{
    public class Sala : Entidade
    {
        public virtual int Capacidade { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public Sessao Sessao { get; private set; }

        protected Sala()
        {

        }

        public Sala(int capacidade,string descricao)
        {
            Id = Guid.NewGuid();
            Capacidade = capacidade;
            Descricao = descricao;
        }
    }
}