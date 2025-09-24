namespace GestiorEmpleados.Models;

public class Empleado : Persona
{
    public Guid Id { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public string Posicion { get; set; }
    public double Salario { get; set; }


    private double CalcularBonificacion()
    {
        var bono = Salario * 0.10;
        Salario += bono;
        return Salario;
    }

    public override void MostrarInformacion()
    {
        Console.WriteLine($"ID: {Id}");
        base.MostrarInformacion();
        Console.WriteLine($"Número de Identificación: {NumeroDeIdentificacion}");
        Console.WriteLine($"Posición: {Posicion}");
        Console.WriteLine($"Salario con bonificación: {CalcularBonificacion():C}");
    }
}