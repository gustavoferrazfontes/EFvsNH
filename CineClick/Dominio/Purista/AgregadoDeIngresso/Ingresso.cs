using CineClick.SharedKernel;
using System;

namespace CineClick.Dominio.Puro.AgregadoDeIngresso
{
    public sealed class Ingresso:RaizDeAgregado
    {
        public  Guid SessaoId { get; private set; }
        public  Preco Preco { get; private set; }
        public  TipoDoIngresso Tipo { get; private set; }

     
        public Ingresso(Guid sessaoId, Preco preco, TipoDoIngresso tipo)
        {
            Id = Guid.NewGuid();
            SessaoId = sessaoId;
            Preco = preco;
            Tipo = tipo;
        }
    }
}
