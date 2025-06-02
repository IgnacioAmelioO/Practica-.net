Console.Write("Ingrese cuántos pares de primos gemelos desea ver: ");
int n = int.Parse(Console.ReadLine());

List<(int, int)> primosGemelos = ObtenerPrimosGemelos(n);

Console.WriteLine("Los primeros {n} pares de primos gemelos son:");
foreach (var par in primosGemelos)
{
    Console.WriteLine($"({par.Item1}, {par.Item2})");
}
static List<(int, int)> ObtenerPrimosGemelos(int cantidad)
{
    List<(int, int)> gemelos = new List<(int, int)>();
    int numero = 3;

    while (gemelos.Count < cantidad)
    {
        if (EsPrimo(numero) && EsPrimo(numero + 2))
        {
            gemelos.Add((numero, numero + 2));
        }
        numero++;
    }

    return gemelos;
}

static bool EsPrimo(int num)
{

    for (int i = 2; i * i <= num; i++)
    {
        if (num % i == 0) return false;
    }
    return true;
}
