using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasedel_13_abril
{
    internal class Auto
    {
        //propiedades
        public int HP { get; set; }
        public string Color { get; set; }

        //constructor parametrizado
        public Auto (int hp, string color)
        {   this.HP = hp; 
            this.Color = color;
        }
        //metodos 
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0}  - Color: {1}", HP, Color);

        }
        //virtual puede ser sobre escrito o invalidado
        public virtual void Reparar()
        {
            Console.WriteLine("El auto ya esta reparado");
        }
      //  { }
    }
}
