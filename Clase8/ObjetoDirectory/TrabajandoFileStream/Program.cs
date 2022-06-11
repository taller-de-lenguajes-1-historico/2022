using System;
using System.IO;
using System.Collections.Generic;

namespace TrabajandoFileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string RutaArchivo = @"c:\Repogit\Tempo\text1.txt";

            if (File.Exists(RutaArchivo))
            {
                FileStream Fstream = new FileStream(RutaArchivo, FileMode.Open);
                StreamReader Streamr = new StreamReader(Fstream);

                string linea;
                do
                {
                    linea = Streamr.ReadLine(); // lee una linea completa
                    Console.WriteLine(linea);
                } while (linea != null);

                Streamr.Close();

            }
            else
            {
                Console.WriteLine("Archivo no encontrado : {0}",RutaArchivo);
            }
           

        }
    }
}
