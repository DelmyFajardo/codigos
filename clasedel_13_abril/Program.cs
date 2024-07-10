using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasedel_13_abril
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //polimorfismo
            ////poli es de muchos y morfismo de 
            var autos = new List<Auto>
            {
                new Audi (200, "azul", "A4"),
                new Audi (300, "lila", "L4"),
                new BMW (200, "Morado", "K4"),
                new BMW(100, "verde", "A3")
            };

            foreach (var auto in autos)
            {
                auto.Reparar();
            }
            Auto auto1 = new BMW(200, "negro", "Z3");
            Auto auto2 = new Audi(200, "naranja", "A3");

            auto1.MostrarDetalles();
            auto2.MostrarDetalles ();

            BMW bmwM5 = new BMW(330, "blanco", "M5");
            bmwM5.MostrarDetalles ();
            Auto auto8 = (Auto)bmwM5;
            auto8.MostrarDetalles();
         
            Console.ReadLine();
        }
    }
}
