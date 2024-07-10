using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6deabril
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
        public Empleado(string nombre, int edad, double salario)
        {
            Nombre = nombre;
            Edad = edad;
            Salario = salario;
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre:{Nombre}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Salario: {Salario}");


        }
    }


    /
}