using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Clase_6deabril.Empleado2;

namespace Clase_6deabril
{
     internal class Program
    {
        static void Main(string[] args)
        {
            //herencia cuando las clases comparten los atributos 
            // es cuando tenemos dos clases con atributos similares y las podemos generalizar= podemos agrupar
            //los atributos que tienen; cuando no podemos aplicar herencia  cuando las dos clases no compaarten los mismos atributos 
            //con solo uno que no tenga no se puede heredar, y hay que tomar en cuenta que deben de ser del mismo tipo ejemplo 
            //un ejemplo es (la foto )
            //la jerarquia de herencias es caundo hay una super clase osea la clase mayor, de esta se derivan las subclases y de estas subclases se derivan mas 
            //pero es mejor 

            string Nombre = "Juan";
            int Edad = 30;
            int salario = 5000;
            string Especialidad = "Ingeniero Civil";
            //crear un objeto ingeniero
            Ingeniero ingeniero = new Ingeniero(Nombre, Edad, salario, Especialidad);
            //mostrar informacion del ingeniro
            Console.WriteLine("Informacion del ingeniro");
            ingeniero.MostrarInformacion();
            ingeniero.MostrarEspecialidad();

            Console.WriteLine();

            Nombre = "maria";
            Edad = 20;
            salario = 45000;
            string TipoDiseno = "Diseño Grafico";
            //crear un objeto diseñador
            Disenador disenador = new Disenador(Nombre, Edad, salario, TipoDiseno);
            //mostrar informacion del diseñador 
            Console.WriteLine("Informacion del Diseñador");
            disenador.MostrarInformacion();
            disenador.MostrarTipoDeDiseno();

            Console.ReadKey();
            Console.ReadLine();

            //una interfaz se denominan metodos abstracctos= no tiene logica implementada es decir que los metodos estan
            //vacios 
            //una interfaz es un contrato, siempre llevan la terminacion aude

        }
    }
}
