using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.EF
{
    public sealed class PeriodoDeExibicao : ObjetoDeValor<PeriodoDeExibicao>
    {
        public DateTime Fim { get; private set; }
        public DateTime Inicio { get; private set; }

        private PeriodoDeExibicao()
        {

        }

        public PeriodoDeExibicao(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        protected override bool EqualsCore(PeriodoDeExibicao outroObjeto)
        {
            if (outroObjeto == null)
                return false;

            return Inicio == outroObjeto.Inicio &&
                Fim == outroObjeto.Fim;
        }

        public bool Disponivel()
        {
            return Inicio <= DateTime.Now && DateTime.Now <= Fim;
        }

        protected override int GetHashCodeCore()
        {
            unchecked
            {
                var hashcode = Inicio.GetHashCode();
                hashcode = (hashcode * 397) ^ Fim.GetHashCode();
                return hashcode;
            }
        }
    }
}