using System;
using System.Collections.Generic;
using System.Text;

namespace LectorCSV
{
    class Contacto
    {
        string nombre;
        string apellido;
        int edad;

        public Contacto(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public static List<Contacto> ConversorDeContacto(List<string[]> Filas)
        {

            List<Contacto> MisContactos = new List<Contacto>();
            foreach (string[] filas in Filas)
            {
                Contacto Ctacto = new Contacto(filas[0], filas[1], Convert.ToInt32(filas[2]));
                MisContactos.Add(Ctacto);
            }
            return MisContactos;

        }

    }
}
