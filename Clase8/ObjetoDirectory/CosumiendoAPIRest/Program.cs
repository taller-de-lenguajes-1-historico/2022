

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace TrabajandoJson
{
    partial class Program
    {

        //https://json2csharp.com/

        static void Main(string[] args)
        {
            GetProvinciasArgentinas();
            GetClima();
        }


        private static void GetProvinciasArgentinas()
        {
            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            ProvinciasArgentina ListProvincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
                            foreach (Provincia Prov in ListProvincias.Provincias)
                            {
                                Console.WriteLine("id: " + Prov.Id + " Nombre: " + Prov.Nombre);
                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
        }

        private static void GetClima()
        {
           var url = $"https://ws.smn.gob.ar/map_items/weather/";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
           
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            List<Root> listclima = JsonSerializer.Deserialize<List<Root>>(responseBody);
                            foreach (var Prov in listclima)
                            {
                                Console.WriteLine("Nombre: " + Prov.name + " Temperatura: " + Prov.weather.temp);
                            }

                        }
                    }
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine("Problemas de acceso a la API");
            }
        }


        private static async Task GetClimaAsync()
        {
            var url = "https://ws.smn.gob.ar/map_items/weather/";

            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                List<Root> listclima = JsonSerializer.Deserialize<List<Root>>(responseBody);
                foreach (var Prov in listclima)
                {
                    Console.WriteLine("Nombre: " + Prov.name + " Temperatura: " + Prov.weather.temp);
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Problemas de acceso a la API");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }

    }
}
