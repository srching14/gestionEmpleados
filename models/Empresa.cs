namespace GestiorEmpleados.Models;

public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> Empleados { get; set; }


    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
    }

    public void MostrarEmpleados()
    {
        foreach (var empleado in Empleados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine("-----------------------");
        }
    }

    // metodo para eliminar un empleado por su nombre y apellido
    public void EliminarEmpleado(string nombre, string apellido)
    {
        var empleado = Empleados.FirstOrDefault(e => e.Nombre == nombre && e.Apellido == apellido);
        if (empleado != null)
        {
            Empleados.Remove(empleado);
            Console.WriteLine($"Empleado {nombre} {apellido} eliminado.");
        }
        else
        {
            Console.WriteLine($"Empleado {nombre} {apellido} no encontrado.");
        }
    }

    // ActualizarEmpleado: Este método permitirá actualizar un empleado de la lista utilizando su número de identificacion.   
    public void ActualizarEmpleado(string numeroDeIdentificacion, Empleado empleadoActualizado)
    {
        var empleado = Empleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            empleado.Nombre = empleadoActualizado.Nombre;
            empleado.Apellido = empleadoActualizado.Apellido;
            empleado.Edad = empleadoActualizado.Edad;
            empleado.Posicion = empleadoActualizado.Posicion;
            empleado.Salario = empleadoActualizado.Salario;
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} actualizado.");
        }
        else
        {
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} no encontrado.");
        }
    }

    //BuscarEmpleado: Este método permitirá buscar un empleado por numero de identificacion y mostrar su información.
    public void BuscarEmpleado(string numeroDeIdentificacion)
    {
        var empleado = Empleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            empleado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine($"Empleado con ID {numeroDeIdentificacion} no encontrado.");
        }
    }

    // ListarEmpleadosPorCargo: Este método permitirá listar todos los empleados que tienen un cargo específico.
    public void MostrarEmpleadosPorCargo(string cargo)
    {
        var empleadosPorCargo = Empleados.Where(e => e.Posicion == cargo).ToList();
        if (empleadosPorCargo.Count != 0)
        {
            foreach (var empleado in empleadosPorCargo)
            {
                empleado.MostrarInformacion();
                Console.WriteLine("-----------------------");
            }
        }
        else
        {
            Console.WriteLine($"No se encontraron empleados con el cargo {cargo}.");
        }
    }
    
}