using System.Text.Json;

const string NombreArchivo = "alumnos.json";
var miHelperdeArchivos = new HelperDeJson();

var listadoAlumnos = new List<Alumno>();
          
Alumno alumno1 = new Alumno("Persona 1", "DNI 3");
Alumno alumno2 = new Alumno("Persona 2", "DNI 2");
Alumno alumno3 = new Alumno("Persona 3", "DNI 3");

listadoAlumnos.Add(alumno1);
listadoAlumnos.Add(alumno2);
listadoAlumnos.Add(alumno3);

ImprimirAlumnos(listadoAlumnos);

//Guardo el archivo
Console.WriteLine("--Serializando--");
string alumnosJson = JsonSerializer.Serialize(listadoAlumnos);
Console.WriteLine("Archivo Serializado : " + alumnosJson);
Console.WriteLine("--Guardando--");
miHelperdeArchivos.GuardarArchivoTexto(NombreArchivo, alumnosJson);

//Abro el Archivo
Console.WriteLine("--Abriendo--");
string jsonDocument = miHelperdeArchivos.AbrirArchivoTexto(NombreArchivo);
Console.WriteLine("--Deserializando--");
var listadoAlumnosRecuperado = JsonSerializer.Deserialize<List<Alumno>>(jsonDocument);
Console.WriteLine("--Mostrando datos recuperardos--");
ImprimirAlumnos(listadoAlumnosRecuperado);
      

static void ImprimirAlumno(Alumno alumno)
{
    Console.WriteLine(alumno.DNI + " - " + alumno.Nombre);
}

static void ImprimirAlumnos(List<Alumno> alumnos )
{
    foreach (var item in alumnos)
    {
        ImprimirAlumno(item);
    }
}
  