using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpiente
{
    class Program
    {
        static void Main(string[] args)
        {
            Tablero tablero = new Tablero(20, 20);
            tablero.DibujarTablero();

            Caramelo caramelo = new Caramelo(2, 3);

            Serpiente serpiente = new Serpiente(10, 10);
            serpiente.DibujarSerpiente();

            Console.ReadKey();
        }
    }
}
