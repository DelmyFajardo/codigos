using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectores__logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esAdmin = false;
            bool estaRegistrado = true;
            string nombreDeUsuarios = "";

        Console.WriteLine("Por favor, ingrese su nombre de usuario");
        nombreDeUsuarios = Console.ReadLine();
            if (estaRegistrado && nombreDeUsuarios != "" && nombreDeUsuarios.Equals("Admin"))
            {
                Console.WriteLine("Hola usuarios resgistrados");
                Console.WriteLine("Hola " + nombreDeUsuarios);
                Console.WriteLine("Hola Admin");

            }
            if (esAdmin || estaRegistrado)
            {
                Console.WriteLine("Estas Loguado");
            }

        }
    }
}
