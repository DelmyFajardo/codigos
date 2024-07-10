using System;
namespace Fundamentos
{
    class EntredaSalida
    {
#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado
        {
            string nombre;
            Console.Write("Escribe tu nombre: ");
                nombre = Console.ReadLine();
            Console.WriteLine("hola" + nombre);
            Console.WriteLine();
        }
    }
}
