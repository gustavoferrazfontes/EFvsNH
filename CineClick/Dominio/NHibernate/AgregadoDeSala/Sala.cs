using CineClick.SharedKernel;

namespace CineClick.Dominio.NHibernate.AgregadoDeSala
{
    public class Sala : RaizDeAgregado
    {

        public virtual int Capacidade { get; protected set; }
        public virtual string Descricao { get; protected set; }
   

        protected Sala()
        {

        }

        public Sala( int capacidade, string descricao)
        {
          
            Capacidade = capacidade;
            Descricao = descricao;
        }

      
    }
}