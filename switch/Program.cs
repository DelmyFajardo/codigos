using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string piedraPapelTijera = "Tijera";
            switch (piedraPapelTijera)
            {
                case "Piedra":
                    Console.WriteLine("Piedra mata a tijera ");
                    break;
                case "Papel":
                    Console.WriteLine("Papel mata a piedra ");
                    break;
                case "Tijera":
                    Console.WriteLine(" Tijera  mata a papel ");
                    break;
                default:
                    Console.WriteLine(" ese elemento no forma parte del juego  ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
