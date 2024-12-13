using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpiente
{
    class Caramelo
    {
        Posicion Posicion { get; set; }
        
        public Caramelo(int x, int y)
        {
            Posicion = new Posicion(x, y);
            Console.ForegroundColor = ConsoleColor.Red;
            Util.DibujarPosicion(Posicion.X, Posicion.Y, "O");
        }


    }

}
