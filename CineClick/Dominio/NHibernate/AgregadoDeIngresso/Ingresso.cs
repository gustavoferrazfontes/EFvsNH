using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.NHibernate.AgregadoDeIngresso
{
    public class Ingresso:RaizDeAgregado
    {
        public virtual Guid SessaoId { get; protected set; }
        public virtual Preco Preco { get; protected set; }
        public virtual TipoDoIngresso Tipo { get; protected set; }

        protected Ingresso()
        {

        }
        public Ingresso(Guid sessaoId, Preco preco, TipoDoIngresso tipo)
        {
            Id = Guid.NewGuid();
            SessaoId = sessaoId;
            Preco = preco;
            Tipo = tipo;
        }
    }
}
