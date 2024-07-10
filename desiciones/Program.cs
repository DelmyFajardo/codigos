using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingresa la temperatura actua");
            string temperatura = Console.ReadLine();
            int numTemperatura = int.Parse(temperatura);
            if (numTemperatura < 20)
            {
                Console.WriteLine("Abrigate!");
            }
            if (numTemperatura == 20)
            {
                Console.WriteLine("VIste comodo!");
            }
            if (numTemperatura > 20)
            {
                Console.WriteLine("Usa ropa liviana");
            }
            Console.ReadLine();
        }
    }
}
