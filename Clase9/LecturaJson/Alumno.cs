public class Alumno
{
    private string nombre;
    private string dni;
    
    public string Nombre { get { return nombre; } set { nombre = value; } }
    public string DNI { get { return dni; } set { dni = value;} }

    public Alumno(string nombre,string dni)
    {
        this.nombre = nombre;
        this.dni = dni;
    }

}
