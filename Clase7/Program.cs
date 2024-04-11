internal class Program
{
    const int CantidadDeTareas = 10;
    private static void Main(string[] args)
    {
        var ListaDeTareas = new List<Tarea>();

        CrearTares(ListaDeTareas);
        ListaDeTareas[0].Estado = Estado.Completada;
        MostrarTareas(ListaDeTareas);

    }

    private static void CrearTares(List<Tarea> ListaDeTareas)
    {
        for (int i = 0; i < CantidadDeTareas; i++)
        {
            var TareaX = new Tarea(i + 1, DateTime.Now.AddDays(i), "Tarea " + i);            
            ListaDeTareas.Add(TareaX);
        }
    }

    private static void MostrarTareas(List<Tarea> ListaDeTareas)
    {
        foreach (Tarea TareaX in ListaDeTareas)
        {
            Console.WriteLine(TareaX.MostrarTarea());
        }
    }

    private static void ImprimirPersona(Persona persona)
    {
         System.Console.WriteLine(persona.MostrarDatos());
    }
}


public enum Estado 
{
    Pendiete = 0,
    Haciendo = 1,    
    Completada = 2
}

public class Tarea
{
    private Estado estado;
    private int prioridad;
    private DateTime fechaLimite;
    private String descripcion;

    public int Prioridad
    {
        get => prioridad;
        
        set
        {
            if(value < 0 ) prioridad = 0;
            else prioridad = value;
        }
    }
    public DateTime FechaLimite { get => fechaLimite; set => fechaLimite = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public Estado Estado { get => estado; set => estado = value; }

    public Tarea()
    {

    }

    public Tarea(int prioridad, DateTime fechaLimite, string descripcion)
    {    
        this.prioridad = prioridad;
        FechaLimite = fechaLimite;
        Descripcion = descripcion;
        Estado = Estado.Pendiete;
    }

    public String MostrarTarea()
    {
        return Descripcion + " - Limite :" + FechaLimite.ToShortDateString() + "("+ Estado +")";
    }


}