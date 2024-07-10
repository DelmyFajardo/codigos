using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace usuarios
{
    internal class Program
       
    {
        private static void Main(ref string contrasena, ref string confirmarContrasena);
        static void Main(string[] args)
        {
            bool esAdmi = false;
            bool estaResgistrado = true;
            string nombreDeUsuario = "";
            string contrasena = "";
            string confirmarContrasena = "";


            Console.WriteLine("Ingrese su nombre de usuario ");
            nombreDeUsuario = Console.ReadLine();
            if (estaResgistrado)
            {
                Console.WriteLine("hola usuario registrado");
                if (nombreDeUsuario != "")
                {
                    Console.WriteLine("Hola, " + nombreDeUsuario);
                    if (nombreDeUsuario.Equals("Admin"))
                    {
                        Console.WriteLine("Hola Admin");
                    }
                }
            }

            private static void Main(ref string contrasena, ref  string confirmarContrasena  )
            {  
           
            Console.WriteLine("ingrese su contraseña ");
            contrasena = Console.ReadLine();
          
            Console.WriteLine("confirma tu contraseña");
            confirmarContrasena = Console.ReadLine();
  
             if ( confirmarContrasena   == contrasena)
            {
                Console.WriteLine("contraseña  confirmada");
            }
             else
                Console.WriteLine("contraseña  incorrecta");
            }


            Console.ReadLine();
        }
    }
}
