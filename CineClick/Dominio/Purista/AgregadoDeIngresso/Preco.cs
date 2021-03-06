﻿using CineClick.SharedKernel;

namespace CineClick.Dominio.Puro.AgregadoDeIngresso
{
    public sealed class Preco : ObjetoDeValor<Preco>
    {
        public decimal Valor { get; }

        public Preco(decimal valor)
        {
            Valor = valor;
        }

        private Preco()
        {

        }

        protected override bool EqualsCore(Preco outroObjeto)
        {
            return Valor == outroObjeto.Valor;
        }

        protected override int GetHashCodeCore()
        {
            return Valor.GetHashCode();
        }

    }
}