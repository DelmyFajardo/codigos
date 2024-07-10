using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosBIdimensionales
{
    internal class Program
    {
        static void Main(string[] args)
        {//cuando son arreglos bidimensionales deben de llevar una coma para separar las dimensiones 
            //una coma significa que es de dos dimensiones, cuando tiene dos comas es de tres dimensiones, cuando es de 3 comas tiene cuatro dimensiones
            //por lo general solo se usan de dos dimensiones ya que alude a [1,2]
            //cuando hablamos de 2 dimensiones son filas y columnas y en tres serian filas columnas y paginas 
            Curso[,] calendario =
            {
                {new Curso("Matematicas"),new Curso("Matematicas"),new Curso("Matematicas"), new Curso("Matematicas"),new Curso("Matematicas") },
                {new Curso("Lenguaje"),new Curso("Lenguaje"),new Curso("Lenguaje"), new Curso("Lenguaje"),new Curso("Lenguaje") },
                {new Curso("Arte"),new Curso("Arte"),new Curso("Arte"),new Curso("Arte"), new Curso("Arte")},
                {new Curso("Fisica"),new Curso("Fisica"),new Curso("Fisica"),new Curso("Fisica"), new Curso("Fisica")},
                {new Curso("Computacion"),new Curso("Computacion"),new Curso("Computacion"),new Curso("Computacion"), new Curso("Computacion")},
            };
            // para acceder a estos objetos lo hago por medio de indices  en este caso voy a acceder a la fila uno posicion 1
            Console.WriteLine(calendario[0, 0]);

            //para mostar todo el arreglo creo otro arreglo
            MostrarArreglo(calendario);

            Console.ReadKey();


        }

        private static void MostrarArreglo(Curso[,] calendario)
        { //5 porque se que tiene 5 filas 
            //en este caso length no nos sirve porque lo que hace este es mostrar el tamaño de los elementos y en este caso nos daria 25
            //por lo que toca usar  este metodo Get.Length para cualquier arregl0
            //cero porque indica la fila  dimension 1  y columna dimension 1 
           for (int fila = 0; fila < calendario.GetLength(0); fila++)
            {
                for (int columna= 0; columna < calendario.GetLength(1) ; columna++)
                {
                    Console.Write(calendario[fila, columna] + "-");
                }
                Console.WriteLine();
            }
        }
    }

    class Curso
    {
        public string Nombre { get; set; }
        //constructor vacio 
        public Curso() { }
        //construcctor con nombre
        public Curso(string nombre) { Nombre = nombre; }

        public override string ToString()
        {
            return "Curso {Nombre = " + Nombre + "}";
        }
    }
}
