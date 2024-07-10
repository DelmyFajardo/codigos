using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuario = "";

            Console.WriteLine("por favor, ingrese su nombre de usuario");
            nombreDeUsuario = Console.ReadLine();
            if (estaRegistrado)
            {
                Console.WriteLine("hola, usuario registrado");
                if (nombreDeUsuario != "")
                {
                    Console.WriteLine("Hola " + nombreDeUsuario);
                    if (nombreDeUsuario.Equals("Admin"))
                    {
                        Console.WriteLine(" hola Admin");
                    }
                }
            }
        }
    }
}
