using System;
using System.IO;

namespace TrabajandoJson
{
    public class HelperDeJson
    {

        public string AbrirArchivoTexto(string nombreArchivo)
        {
            string documento;
            var archivoOpen = new FileStream(nombreArchivo, FileMode.Open);
            using (var strReader = new StreamReader(archivoOpen))
            {
                documento = strReader.ReadToEnd();
            }

            return documento;
        }

        public void GuardarArchivoTexto(string nombreArchivo, string datos)
        {
            var archivo = new FileStream(nombreArchivo, FileMode.Create);
            using (var strWriter = new StreamWriter(archivo))
            {
                strWriter.WriteLine("{0}", datos);
                strWriter.Close();
            }
        }
    }
}
