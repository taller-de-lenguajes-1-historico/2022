using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace ObjetoDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Leyendo disco lógicos 
            List<string> Discos = Directory.GetLogicalDrives().ToList();
            foreach (string discoX in Discos)
            {
                Console.WriteLine(discoX);
            }
            Console.ReadKey();

            //listar Carpetas o directorios del disco C:\
            List<string> ListadoDeCarpetas = Directory.GetDirectories(@"c:\").ToList();
            foreach (string CarpetaY in ListadoDeCarpetas)
            {
                Console.WriteLine(CarpetaY);
            }

            Console.ReadKey();

            // obtiene información de un determinado directorio 
            string Directorio = @"C:\Repogit"; // aquí debes poner un directorio propio de tu pc 
            string info = Directory.GetDirectoryRoot(Directorio);

            Console.WriteLine("Info sobre la raiz del directorio: " + info);

            Console.ReadKey();

            // Ksuta Carpetas del directorio ingresado anteriormente
            List<string> ListadoDeCarpetasEnRepo = Directory.GetDirectories(Directorio).ToList();
            Console.WriteLine("------------------------ ");
            Console.WriteLine("Carpetas en repositorio - " + Directorio);
            foreach (string Carpeta in ListadoDeCarpetasEnRepo)
            {
                Console.WriteLine(Carpeta);
            }

            //obtiene la ruta de windows desde la variables de ambiente 
            string winDir = System.Environment.GetEnvironmentVariable("windir");
            
            //Información de un determinado archivo. (en este caso es Notepad.exe)
            FileInfo FileOp = new FileInfo(winDir + "\\Notepad.exe");
            Console.WriteLine("File Name = " + FileOp.FullName);
            Console.WriteLine("Creation Time = " + FileOp.CreationTime);
            Console.WriteLine("Last Access Time = " + FileOp.LastAccessTime);
            Console.WriteLine("Last Write TIme = " + FileOp.LastWriteTime);
            Console.WriteLine("Size = {0} Kb", ((FileOp.Length) / 2014));

            Console.WriteLine();

            if(!(Directory.Exists(Directorio + @"\Tempo")))
            {
                Directory.CreateDirectory(Directorio + @"\Tempo");
            }
            
            // Listado de carpetas en respositorio
            List<string> ListadoDeCarpetasEnRepo2 = Directory.GetDirectories(Directorio).ToList();
            Console.WriteLine("------------------------ ");
            Console.WriteLine("Carpetas en repositorio - " + Directorio);
            foreach (string Carpeta in ListadoDeCarpetasEnRepo2)
            {
                Console.WriteLine(Carpeta);
            }

            //Utilizando el objeto File 
            string NuevoArchivo = Directorio + @"\Tempo" + @"\Prueba.txt";
            string NuevoArchivoCopia = Directorio + @"\Tempo" + @"\Prueba_Copia.txt";
            
            //Controla si el archivo existe, en caso de no existir lo crea
            if (!File.Exists(NuevoArchivo))
            {
                File.Create(NuevoArchivo);// crea el archivo en la ruta especificada 
            }
            
            // Mueve un archivo de una ubicación a otra
            File.Move(NuevoArchivo, NuevoArchivoCopia);
          

        }
    }
}
