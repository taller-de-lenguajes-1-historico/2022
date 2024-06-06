using System.Text.Json;

var listClima = await GetClimaAsync();
var listProvincias = await GetProvinciasArgentinasAsync();

Console.WriteLine("-----------------------------");
Console.WriteLine("Provincias");
foreach (var Prov in listProvincias.Provincias)
{
    Console.WriteLine("Nombre: " + Prov.Nombre);
}
Console.Read();
Console.WriteLine("-----------------------------");
Console.WriteLine("Climas");
foreach (var Prov in listClima)
{
    Console.WriteLine("Nombre: " + Prov.name + " Temperatura: " + Prov.weather.temp);
}



static async Task<List<Root>> GetClimaAsync()
{
    var url = "https://ws.smn.gob.ar/map_items/weather/";

    try
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        List<Root> listclima = JsonSerializer.Deserialize<List<Root>>(responseBody);
        return listclima;
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("Problemas de acceso a la API");
        Console.WriteLine("Message :{0} ", e.Message);
        return null;
    }
}




static async Task<ProvinciasArgentina> GetProvinciasArgentinasAsync()
{
    var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";

    try
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        ProvinciasArgentina provincias = JsonSerializer.Deserialize<ProvinciasArgentina>(responseBody);
        return provincias;
    }
    catch (HttpRequestException e)
    {
        Console.WriteLine("Problemas de acceso a la API");
        Console.WriteLine("Message :{0} ", e.Message);
        return null;
    }
}