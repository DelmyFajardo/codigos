using System;


namespace Sentencias
{
    class SentenciaIf
    {

#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        public static void Main (string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado

        {
            int numeroEntero= int.Parse(Console.ReadLine());
            if (numeroEntero == 7)
                Console.WriteLine("numero entero es 7.");
            else if (numeroEntero < 0)
                Console.WriteLine("numero entero es negativo");
            else
                Console.WriteLine("numeroEntero no es ninguno de los casos programados");
            concole.ReadLine();
        }
    }
}

