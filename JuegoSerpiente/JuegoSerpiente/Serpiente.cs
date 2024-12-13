using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpiente
{
    class Serpiente
    {
        List<Posicion> Cola { get; set; }
        Direccion Direccion { get; set; }
        int Puntos { get; set; }

        public Serpiente(int x, int y)
        {
            Posicion posicionInicial = new Posicion(x, y);
            Cola = new List<Posicion>() { posicionInicial };
            Direccion = Direccion.Abajo;
        }

        public void DibujarSerpiente()
        {
            foreach(Posicion posicion in Cola)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Util.DibujarPosicion(posicion.X, posicion.Y, "x");
            }
        }

        public void Morir()
        {
            throw new NotImplementedException();
        }

        public void Moverse()
        {
            throw new NotImplementedException();
        }

        public void ComerCaramelo()
        {
            //Aumentar tamaño
            //Sumar puntos
            //Quitar caramelo
            throw new NotImplementedException();
        }
    }
}
