using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Serpiente serpiente = new Serpiente(10, 10);

            do
            {
                Console.Clear();
                tablero.DibujarTablero();
                
                serpiente.Moverse();
                serpiente.DibujarSerpiente();

                var sw = Stopwatch.StartNew(); //Se utiliza para medir el tiempo y asegurarse de que cada movimiento de la serpiente dure exactamente 200 milisegundos
                while (sw.ElapsedMilliseconds <= 200)
                {
                    serpiente.Direccion = LeerMovimiento(serpiente.Direccion);
                }

            } while (serpiente.EstaViva);

            Console.ReadKey();
        }

        static Direccion LeerMovimiento(Direccion movimientoActual)
        {
            if (Console.KeyAvailable) //Determina si se ha presionado una tecla en la consola
            {
                var key = Console.ReadKey().Key; //captura la tecla presionada por el usuario
                if ( key == ConsoleKey.UpArrow && movimientoActual != Direccion.Abajo )
                {
                    return Direccion.Arriba;
                }else if ( key == ConsoleKey.DownArrow && movimientoActual != Direccion.Arriba )
                {
                    return Direccion.Abajo;
                }
                else if (key == ConsoleKey.LeftArrow && movimientoActual != Direccion.Derecha)
                {
                    return Direccion.Izquierda;
                }
                else if (key == ConsoleKey.RightArrow && movimientoActual != Direccion.Izquierda)
                {
                    return Direccion.Derecha;
                }
            }
            return movimientoActual;
        }
    }
}
