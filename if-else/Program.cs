using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese lla temperatura actual");
            string temperatura = Console.ReadLine();
            int numTemperatura;
            int numero;
            if (int.TryParse(temperatura, out numero))
            {
                numTemperatura = numero;
            }
            else
            {
                numTemperatura = 0;
                Console.WriteLine("el valor ingresado no es valido, se establecio que la temperatura es 0 ");
            }
        }
    }
}
