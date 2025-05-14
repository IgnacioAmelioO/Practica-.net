namespace Empleados
{
    public class Empleado
    {
        private static int contadorId = 0;

        public int Id;
        public string Nombre;
        public int Sueldo;

        public Empleado(string nombre, int sueldo)
        {
            Id = ++contadorId;
            Nombre = nombre;
            Sueldo = sueldo;
        }
    }
}
