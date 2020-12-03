using System;

namespace TestConsola.Interfaces
{
    class Automovil : IVehiculoTerrestre
    {
        public Automovil()
        {
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelero nuestro automovil");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando motor de automvil");
        }

        public void AumentarVelocidad()
        {
            Console.WriteLine("La velocidad de manejo aumento considerablemente");
        }

        public void Prender()
        {
            Console.WriteLine("Motor encendido");
        }
    }
}
