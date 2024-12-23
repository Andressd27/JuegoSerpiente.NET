﻿namespace JuegoSerpiente
{
    public class Tablero
    {
        public readonly int Altura;
        public readonly int Anchura;
        public bool ContieneCaramelo;
        public Tablero( int altura, int anchura )
        {
            Altura = altura;
            Anchura = anchura;
            ContieneCaramelo = false;
        }

        public void DibujarTablero()
        {
            for (int i = 0; i <= Altura; i++)
            {
                //Linea derecha
                Util.DibujarPosicion(Anchura, i, "#");

                //Linea izquierda
                Util.DibujarPosicion(0, i, "#");
            }

            for (int i = 0; i <= Anchura; i++)
            {
                Util.DibujarPosicion(i, Altura, "#");
                Util.DibujarPosicion(i,0,"#");
            }
        }
    }
}
