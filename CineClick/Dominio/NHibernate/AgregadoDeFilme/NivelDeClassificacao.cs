using CineClick.SharedKernel;

namespace CineClick.Dominio.NHibernate
{
    public sealed class NivelDeClassificacao : ObjetoDeValor<NivelDeClassificacao>
    {

        public static readonly NivelDeClassificacao Livre = new NivelDeClassificacao("L");
        public static readonly NivelDeClassificacao NaoRecomendadoParaMenoresDe10Anos = new NivelDeClassificacao("10");
        public static readonly NivelDeClassificacao NaoRecomendadoParaMenoresDe12Anos = new NivelDeClassificacao("12");
        public static readonly NivelDeClassificacao NaoRecomendadoParaMenoresDe14Anos = new NivelDeClassificacao("14");
        public static readonly NivelDeClassificacao NaoRecomendadoParaMenoresDe16Anos = new NivelDeClassificacao("16");
        public static readonly NivelDeClassificacao NaoRecomendadoParaMenoresDe18Anos = new NivelDeClassificacao("18");

        private NivelDeClassificacao()
        {

        }
        public NivelDeClassificacao(string nivel)
        {
            Nivel = nivel;
        }

        public string Nivel { get; }

        protected override bool EqualsCore(NivelDeClassificacao outroObjeto)
        {
            if (outroObjeto == null)
                return false;

            return Nivel == outroObjeto.Nivel;
           
        }

        protected override int GetHashCodeCore()
        {
            return Nivel.GetHashCode();
        }
    }
}