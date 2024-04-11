
public class Persona
{
    public string Nombre;
    public string Apellido;

    public string DNI;
    public DateTime FechaDeNacimiento;

    public Persona()
    {
        
    }   
    
    public Persona(string nombre, string apellido, DateTime fechaDeNacimiento)
    {
        Nombre = nombre;
        Apellido = apellido;
        FechaDeNacimiento = fechaDeNacimiento;
    }

    public int Edad(DateTime Today)
    {
        return (Today.Subtract(FechaDeNacimiento).Days / 365); 
    }

    public string MostrarDatos()
    {
        return NombreCompleto() + " su edad es " + Edad(DateTime.Now);
    }

    public string NombreCompleto()
    {
        return Apellido+ ", "+ Nombre;
    }
    
}

public class mascota 
{
    public int tipo = 0; 
}