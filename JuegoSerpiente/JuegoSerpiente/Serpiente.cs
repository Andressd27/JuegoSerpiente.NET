using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoSerpiente
{
    public class Serpiente
    {
        List<Posicion> Cola { get; set; }
        public Direccion Direccion { get; set; }
        int Puntos { get; set; }
        public bool EstaViva { get; set; }

        public Serpiente(int x, int y)
        {
            Posicion posicionInicial = new Posicion(x, y);
            Cola = new List<Posicion>() { posicionInicial };
            Direccion = Direccion.Abajo;
            Puntos = 0;
            EstaViva = true;
        }

        public void DibujarSerpiente()
        {
            foreach(Posicion posicion in Cola)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Util.DibujarPosicion(posicion.X, posicion.Y, "x");
                Console.ResetColor();
            }
        }

        public void Morir()
        {
            throw new NotImplementedException();
        }

        public void Moverse()
        {
            List<Posicion> nuevaCola = new List<Posicion>();
            nuevaCola.Add(ObtenerNuevaPrimeraPosicion());

            Cola = nuevaCola;
        }

        private Posicion ObtenerNuevaPrimeraPosicion()
        {
            int x = Cola.First().X;
            int y = Cola.First().Y;

            switch (Direccion)
            {
                case Direccion.Abajo:
                    y += 1;
                    break;
                case Direccion.Arriba:
                    y -= 1;
                    break;
                case Direccion.Derecha:
                    x += 1;
                    break;
                case Direccion.Izquierda:
                    x -= 1;
                    break;
            }
            return new Posicion(x, y);
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
