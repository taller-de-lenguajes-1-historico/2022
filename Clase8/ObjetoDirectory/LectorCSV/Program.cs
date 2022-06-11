using System;
using System.Collections.Generic;
using System.IO;

namespace LectorCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // [*  *   *   * ]
            // [*  *   *   * ]
            // [*  *   *   * ]

            string nombreDeArchivo = "MiArchivoCsv.csv";
            string rutaDeArchivo = @"C:\Users\javie\Documents\Pruebas\";

            List<string[]> LecturaDelArchivo = HelperCsv.LeerCsv(rutaDeArchivo, nombreDeArchivo, ';');
            List<Contacto> MisContactos = Contacto.ConversorDeContacto(LecturaDelArchivo);            

            //List<Contacto> MisContactos = new List<Contacto>();
            //foreach (string[] filas in LecturaDelArchivo)
            //{
            //    Contacto Ctacto = new Contacto(filas[0], filas[1], Convert.ToInt32(filas[2]));
            //    MisContactos.Add(Ctacto);
            //}



        }
    }
}
