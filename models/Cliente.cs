namespace GestiorEmpleados.Models;

public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
    }

}