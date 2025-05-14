using Empleados;
List<Empleado> empleados = new List<Empleado>();

string seguir = "s";
while (seguir == "s")
{
    Console.WriteLine("Ingrese el nombre del empleado:");
    string nombre = Console.ReadLine();
    Console.WriteLine("Ingrese el sueldo del empleado:");
    int sueldo = int.Parse(Console.ReadLine());
    Empleado empleado = new Empleado(nombre, sueldo);
    empleados.Add(empleado);
    Console.WriteLine("¿Desea agregar otro empleado? (s/n)");
    seguir = Console.ReadLine();
}
List<Empleado> empOrdenados = empleados.OrderBy(e => e.Sueldo).ToList();

foreach (Empleado e in empOrdenados)
{
    Console.WriteLine($"ID:{e.Id} Nombre: {e.Nombre}, Sueldo: {e.Sueldo}");

}
