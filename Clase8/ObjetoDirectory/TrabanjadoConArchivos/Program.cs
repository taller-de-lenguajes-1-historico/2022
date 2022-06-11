using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TrabanjadoConArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string RutaArchivo = @"c:\Repogit\Tempo\text1.txt";

            string texto = File.ReadAllText(RutaArchivo);
            Console.WriteLine("Contenido: {0}", texto);

            List<string> LineasDelArchivo = File.ReadAllLines(RutaArchivo).ToList();

            foreach (string Linea in LineasDelArchivo)
            {
                Console.WriteLine("\t" + Linea);
            }


            string[] MisLineas = { "Prueba 1 ", "Prueba 2" };
            File.WriteAllLines(RutaArchivo, MisLineas);
            
        }
      
    }
}
