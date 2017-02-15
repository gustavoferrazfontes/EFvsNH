using System;

namespace CineClick.SharedKernel
{
    public class Entidade
    {
        public virtual Guid Id { get; protected set; }
        public override bool Equals(object obj)
        {
            var outraEntidade = obj as Entidade;
            if (ReferenceEquals(outraEntidade, null))
                return false;

            if (ReferenceEquals(this, outraEntidade))
                return true;

            if (this.GetType() != outraEntidade.GetType())
                return false;

            if (Id == Guid.Empty || outraEntidade.Id == Guid.Empty)
                return false;

            return Id == outraEntidade.Id;
        }

        public override int GetHashCode() => Id.GetHashCode();
    }
}
