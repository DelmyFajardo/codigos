using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasedel6deabril
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
    //sub clase ingeniero, hereda de empleado
    public class Ingeniero:Empleado, Fiscalizable
    {  // con la palabra base se usa para invocar un construcctor  a la clase
        public Ingeniero(string nombre, int edad, double salario, string especialidad):base(nombre,edad,salario)
        { //este es un constructor 
            Especialidad = especialidad;

        }
        //propiedad especifica para ingeniero
        public string Especialidad { get; set; }
        public int CalcularImpuesto()
        {
            return (int)((int)Salario * 0.1);
        }
        //metodo especifico para ingeniero
        public void MostrarEspecialidad()
        {
            Console.WriteLine($"Especialidad: {Especialidad}");
        }
    } 
    public class Disenador : Empleado , Fiscalizable
    {
        public Disenador(string nombre,int edad,double salario, string tipoDiseno) :base (nombre,edad,salario)
        {
            TipoDiseno = tipoDiseno;
        }
        //propiedad especifica de diseñador 
        public string TipoDiseno { get; set; }
        //metodo especifico de diseñador 
        public void MostrarTipoDeDiseno()
        {
            Console.WriteLine($"Tipo de diseño: {TipoDiseno}");
                
        }

        public  int CalcularImpuesto()
        {
            return (int)((int)Salario* 0.05);
        }
    }
    //una interzar es una de las obligaciones que todas las clases deben cumplir 
    public interface Fiscalizable
    {
        int CalcularImpuesto();
    }
    
}
