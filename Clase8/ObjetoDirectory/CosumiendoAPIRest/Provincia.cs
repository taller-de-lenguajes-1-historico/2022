using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TrabajandoJson
{

    public class Parametros
    {
        [JsonPropertyName("campos")]
        public List<string> Campos { get; set; }
    }

    public class Provincia
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("nombre")]
        public string Nombre { get; set; }
    }


    public class ProvinciasArgentina
    {
        [JsonPropertyName("cantidad")]
        public int Cantidad { get; set; }

        [JsonPropertyName("inicio")]
        public int Inicio { get; set; }

        [JsonPropertyName("parametros")]
        public Parametros Parametros { get; set; }

        [JsonPropertyName("provincias")]
        public List<Provincia> Provincias { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }


}


// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Root
{
    public string _id { get; set; }
    public double dist { get; set; }
    public int lid { get; set; }
    public int fid { get; set; }
    public int int_number { get; set; }
    public string name { get; set; }
    public string province { get; set; }
    public string lat { get; set; }
    public string lon { get; set; }
    public string zoom { get; set; }
    public int updated { get; set; }
    public Weather weather { get; set; }
    public object forecast { get; set; }
}

public class Weather
{
    
    public int id { get; set; }
    public string description { get; set; }
    public double? temp { get; set; }

}





