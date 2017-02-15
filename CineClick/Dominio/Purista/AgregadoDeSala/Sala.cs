using CineClick.SharedKernel;

namespace CineClick.Dominio.Puro.AgregadoDeSala
{
    public sealed class Sala : RaizDeAgregado
    {

        public  int Capacidade { get; private set; }
        public string Descricao { get; private set; }
   

        public Sala( int capacidade, string descricao)
        {
          
            Capacidade = capacidade;
            Descricao = descricao;
        }

      
    }
}