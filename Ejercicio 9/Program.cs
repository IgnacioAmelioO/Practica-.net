Console.Write("Ingrese el número de filas: ");
int filas = int.Parse(Console.ReadLine());

for (int i = 1; i <= filas; i++)
{
    int espacios = filas - i;
    int asteriscos = 2 * i - 1;

    Console.Write(new string(' ', espacios));
    Console.WriteLine(new string('*', asteriscos));
}