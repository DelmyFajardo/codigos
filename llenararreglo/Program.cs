using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llenararreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arreglo udimensionales clase 23    
            // loas arreglos udimensionales solo tienen una dimension 

            //cuando definimos un arreglo con tamaño pero  no le pusimos informacion  lo podemos hacer 
            Persona[] personas = new Persona[3];
            LlenarArreglo(personas);

            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine(personas[i].ToString());
            }
            Console.WriteLine("Mayores de edad ");
            Persona[] mayoresDeEdad = BuscarMayores(personas);
            for (int i = 0; i < mayoresDeEdad.Length; i++)
            {// el null evalua si existe uno diferente 
                if (null != mayoresDeEdad[i])
                {
                    Console.WriteLine(personas[i].ToString());
                }
               
            }
            Console.ReadKey(); 



           
        }

        private static Persona[] BuscarMayores(Persona[] personas)
        {
            Persona[] mayores = new Persona[personas.Length];
            for (int  i= 0;i<personas.Length;i++)
            {
                Persona personaTemp = personas[i];
                if (personaTemp.Edad >=18)
                    mayores[i] = personaTemp;
            }
            return mayores;
        }

        //este metodo nos devuelve otro array como un valor 
        private static void LlenarArreglo(Persona[] personas)
        {
            // las varibles de control se llaman por i ya que representa el indice 
            //como no siempre vamos a saber el tamaño del arreglo ponemos el nombre del arreglo.Length en este caso cambie 3 por
            //personas.Length
            //Mediante este metodo solicito la informacion 
            for (int i = 0; i < personas.Length; i++)
            {

                Console.WriteLine("ingrese Nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese edad");
                int edad = int.Parse(Console.ReadLine());
                Persona newPerson = new Persona(nombre, edad);
                personas[i] = newPerson;

            }
        }
        class Persona
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Persona() { }
            public Persona(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }

            public override string ToString()
            { // me muestra la clase con sus estado 
                return "Persona  { nombre = " + Nombre + " Edad= " + Edad + "}";
            }

        }
    }
}
