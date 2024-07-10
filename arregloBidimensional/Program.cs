using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arregloBidimensional
{
    internal class Program
    {  //arreglo bidimensional con tipos de datos primitivos 
        const char disponible = '-';
        char[,] tablero =
        {
            { disponible,disponible,disponible },
            { disponible,disponible,disponible },
            { disponible,disponible,disponible },
        };//la variable tablero se le da un scup o un alcance la puedo usar en cualquier metodo 
        static void Main(string[] args) //en un metodo static solo puedo llamar a un main 
        { // por lo que uso una instancia de la clase program creo un objeto de la clase program
            Program p = new Program();

            //declaro una variables
            bool fin = false;
            char jugadorActual = 'X';
            do
            {
                p.RealizarJugada(jugadorActual);
                p.MostrarTablero();
              
                //para indicar al programa cuando termina
                ////le indico que se salga || solo cuanos el tablero este lleno 
                fin = p.tableroLleno() || p.EsGanador(jugadorActual);
                jugadorActual = jugadorActual == 'X' ? '0' : 'X';
            } while (!fin);

            Console.ReadKey();
            Console.ReadLine();
        }

        private bool EsGanador(char jugadorActual)
        {
           
            for (int i = 0; i < 3; i++)
            {     //filas
                if (tablero[i, 0] == jugadorActual && tablero[i, 1] == jugadorActual && tablero[i, 2] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador "+jugadorActual+" Has Ganado!!!");
                    return true;
                }
                //columnas
                if (tablero[0, i] == jugadorActual && tablero[1,i] == jugadorActual && tablero[2,i] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador " + jugadorActual + " Has Ganado!!!");
                    return true;
                }
                //validar las diagonales del tablero

                if (tablero[0, 0] == jugadorActual && tablero[1, 1] == jugadorActual && tablero[2, 2] == jugadorActual)
                {
                    Console.WriteLine("Felicidades jugador " + jugadorActual + " Has Ganado!!!");
                    return true;
                }
            }
            return false;
            
        }

        //este me dara un verdadero cuando este,  este lleno 
        private bool tableroLleno()
        {
            bool esDisponible = true;
            for (int fi= 0; fi < 3; fi++)
            {
                for (int col=0; col < 3; col++)
                {
                    if (tablero[fi, col] == disponible)
                    {
                        esDisponible = false;
                        return esDisponible;
                    }
                }
            }
            return esDisponible;
        }

        private void RealizarJugada(char jugadorActual)
        { //este metodo lo utilizo para saber en que posicion juagar 
            Console.WriteLine("Es el turno de" + jugadorActual);
            bool valida = false;
            do
            {
                Console.WriteLine("Elija una fija");
                int fila = int.Parse(Console.ReadLine());
                Console.WriteLine("elija una columna");
                int columna = int.Parse(Console.ReadLine());

                if (tablero[fila, columna] == disponible)
                {
                    tablero[fila, columna] = jugadorActual;
                    valida = true;
                }
                else
                {
                    Console.WriteLine("pocision invalida");
                    valida = false;
                }
                //esto lo va hacer mientras la entrada no sea valida
            } while (!valida);
            
        }

        //creo un metodo 
        public void MostrarTablero()
        {  //para limpiar la pantalla
            Console.Clear();
            for (int  fila = 0; fila<3; fila++)
            {
                for (int col= 0; col<3 ; col++)
                {
                    Console.Write(tablero[fila, col]);
                }
                Console.WriteLine();
           
           }
            Console.WriteLine("Preciona una tecla");
            Console.ReadKey();
        }
    }
}
