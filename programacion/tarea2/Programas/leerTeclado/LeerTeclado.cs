using System;

namespace LeerTeclado
{
    ///<sumary>
    ///leer datos deesde teclado
    ///</sumary>
    class Program
    {
#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        static void Main(string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado
        {
            Console.WriteLine("suma de dos numeros");
            Console.WriteLine("Ingresa numero 1: ");
            //los datos se leen como cadena
            string dato = Console.ReadLine();
            //convertir a numero con int.Parse
            int n1 = int.Parse(dato);
            Console.WriteLine("inggresa numero 2: ");
            dato = Console.ReadLine();  
            int  n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("el resultaod es: {0}", suma);
            Console.ReadLine();
        }
    }
}

