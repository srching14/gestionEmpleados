namespace GestiorEmpleados.Models;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public byte Edad { get; set; }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
    }
}