using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasedel23
{
    internal class Program
    {
        static void Main(string[] args)
        { // arreglo que guarda dos objetos de persona
          // Persona[] personas = new Persona[2];
          // personas[0] = new Persona();
          //quiero asignarle nombre 
          //  Persona JUan = new Persona();
          // JUan.nombre = "juan";
          //  personas[1] = JUan;  //el estado es el valor de cada una de las propiedades 
          //creo un objeto por lo cual accedo al nombre del objeto   del arreglo y  posicion 0  del dato que quiero 

            //personas[0].nombre= "yeff";

            //indico que quiero el arreglo de persona y que quiero que me muestre su estado en posicion 0 
            //Console.WriteLine(personas[0]);
            // Console.ReadKey(true);

            //le asigno de una vez valores al arreglo          le doy un estado 
            Persona[] personas = { new Persona("delmy", 19), new Persona("marlon", 12), new Persona("Anderson", 10) };

            //MANIPULO DIRECTAMENTE DESDE SU INDICE 
            Console.WriteLine(personas[0]);
            //para cambiar el  nombre de la primer persona 
            personas[0].Nombre = "Maria ";
            //cambio la edad 
            personas[0].Edad = 20;
            Console.WriteLine(personas[0]);


            // cambio el estado  de las personas   
            //MANIPULO CREANDO NUEVOS VALORES O OBJETOS  
            personas[1] = new Persona ("sara", 45);
            Console.WriteLine(personas[1]);


            Console.WriteLine("=====================================");
            //MANIPULO HACIENDO REFERENCIA A ESTE OBJETO MEDIANTE A ESTE OBJETO CON UNA VARIABLE TEMPORAL MODIFICANDO SU ESTADO 
            //esta es otra manera de manipular los estados 
            Console.WriteLine(personas[2]);
            Persona personaTemp = personas[2];
            personaTemp.Nombre = "julio ";
            Console.WriteLine(personas[2]);

            //cuando definimos un arreglo con tamaño pero  no le pusimos informacion  lo podemos hacer 
            Persona[] personas = new Persona[3];
            LlenarArreglo(personas);
            //el objetivo de los arreglos es que manejemos datos mayores 
            //  programa que ayuda a modificar un objeto o valor por repeticion ya que escribir linea por linea no tenie cuenta 
            //Length es un atributo que representa el tamaño de un arreglo y mediante este atributo podemos acceder al tamaño del arreglo Ejemplo;
            Console.WriteLine("el tamaño del arreglo" +personas.Length);
            //para acceder a cada uno de los datos cuando son muchos se hace mediante un ciclo de repeticion 
            // las varibles de control se llaman por i ya que representa el indice 
            //como no siempre vamos a saber el tamaño del arreglo ponemos el nombre del arreglo.Length en este caso cambie 3 por
            //personas.Length
            for (int i = 0; i < personas.Length; i ++)
            { 
                Console.WriteLine(personas[i].ToString());
            }

           


            Console.ReadKey();

           
        }

        private static void LlenarArreglo(Persona[] personas)
        {
            //Mediante este metodo solicito la informacion 
            for (int i = 0; i < personas.Length; i++)
            {
                Console.WriteLine("ingrese Nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese edad");
                int edad = int.Parse(Console.ReadLine());
                Persona newPerson = new Persona();
            }
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


        public override string  ToString()
            { // me muestra la clase con sus estado 
              return "Persona  { nombre = "+Nombre+" Edad= "+Edad+"}";
            }

    }
}
