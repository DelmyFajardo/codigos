using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace clasedel_13_abril
{
    class BMW: Auto
    {
        //Variables
        private string marca = "BMW";
        //propiedad
        public string Modelo {get; set;}
        public BMW(int hp, string color, string modelo): base(hp,color)
        {
            
            this.Modelo = modelo;
        }
        //metodos
        public  void MostrarDetalles()
        { 
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }
        //override= sobreescribir o invalidar 
        public override void Reparar()
        {
            Console.WriteLine("El BMW {0} esta reparado ", Modelo);
        }
    }
   
}
