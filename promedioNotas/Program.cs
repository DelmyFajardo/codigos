using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedioNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad, nota;
            double promedio;

            string nombre;
            Console.WriteLine("ingresa la cantidad de alumnos; ");
            cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingresa en nombre del alumno; ");
                nombre = Console.ReadLine();
           
            string nota1;
            Console.WriteLine("ingresa la cantidad de notas; ");
            nota = int.Parse(Console.ReadLine());
              for ( int n= 0; n < nota ; n++)
                {
                    Console.WriteLine("Ingresa la nota del alumno ; ");
                    nota1 = Console.ReadLine();
                }
 
                promedio = (nota++ ) / 2 ;

                Console.WriteLine("el  promedio del alumno " + nombre + "es " + promedio);

            }
            Console.ReadLine();
        }
    }
}
