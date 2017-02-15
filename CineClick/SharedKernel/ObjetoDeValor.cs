using System;

namespace CineClick.SharedKernel
{
    public abstract class ObjetoDeValor<T> where T : ObjetoDeValor<T>
    {
        public override bool Equals(object obj)
        {
            var outroObjeto = obj as T;

            if (ReferenceEquals(outroObjeto, null))
                return false;

            return EqualsCore(outroObjeto);
        }

        protected abstract bool EqualsCore(T outroObjeto);
        protected abstract int GetHashCodeCore();

        public static bool operator ==(ObjetoDeValor<T> a, ObjetoDeValor<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }


        public static bool operator !=(ObjetoDeValor<T> a, ObjetoDeValor<T> b)
        {
            return !(a == b);
        }

    }
}
