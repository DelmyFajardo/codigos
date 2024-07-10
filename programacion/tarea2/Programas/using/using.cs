using System;
using System.IO;
namespace Sentencias
{
    class SentecniasUsing
    {
#pragma warning disable IDE0060 // Quitar el parámetro no utilizado
        public static void Main(string[] args)
#pragma warning restore IDE0060 // Quitar el parámetro no utilizado
        {
            string s;
            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea uno");
                w.WriteLine("linea dos");

            }
            using (TextReader r = File.OpenText ("log.txt"))
            {
                while ((s = r.ReadLine()) != null)
                {
                   Console.WriteLine(s);
                }
            }
        }
    }
}
