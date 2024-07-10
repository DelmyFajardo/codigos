using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasedel_13_abril
{
     class Audi: Auto
    {
        private string marca = "Audi";
        //propiedad
        public string Modelo { get; set; }
        //construcctor 
        public Audi (int hp, string color, string modelo): base(hp,color)
        { 
            this.Modelo = modelo;
        }

        //metodos
        //    { }
        public void MostrarDetalles() 
        {
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }
        public override void Reparar()
        { 
            Console.WriteLine("El Audi {0} esta reparado ", Modelo);
        }


    }
}
