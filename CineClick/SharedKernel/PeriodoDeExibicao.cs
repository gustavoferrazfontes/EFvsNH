using System;

namespace CineClick.SharedKernel
{
    public sealed class PeriodoDeExibicao : ObjetoDeValor<PeriodoDeExibicao>
    {
        public DateTime Fim { get; }
        public DateTime Inicio { get; }

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
            return DateTime.Now >= Inicio && DateTime.Now <= Fim;
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