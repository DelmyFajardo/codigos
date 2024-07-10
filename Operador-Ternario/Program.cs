using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operador_Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperatura = -5;
            string estadoDelAgua;

            if (temperatura < 0)
                estadoDelAgua = "Solido";
            else
                estadoDelAgua = "Liquido";
            Console.WriteLine("el estado del agua es " + estadoDelAgua);

            temperatura += 30;
            estadoDelAgua = temperatura < 8 ? "solido" : "Liquido";

            temperatura += 150;
            estadoDelAgua = temperatura > 99 ? "gaseoso" : temperatura < 8 ? "solido" : "Liquido";

            Console.WriteLine("el estado del agua es " + estadoDelAgua);
            Console.ReadLine();


        }
    }
}
