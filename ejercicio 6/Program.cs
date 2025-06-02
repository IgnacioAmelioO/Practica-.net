Console.Write("Ingrese un número entero entre 1 y 3999: ");
int numero = int.Parse(Console.ReadLine());
string romano = ConvertirARomano(numero);
Console.WriteLine("Número romano" +romano);
    

    static string ConvertirARomano(int numero)
{
    if (numero < 1 || numero > 3999)
    {
        Console.WriteLine("El número debe estar entre 1 y 3999.");
        return "";
    }

    string[] miles = { "", "M", "MM", "MMM" };
    string[] cientos = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
    string[] decenas = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
    string[] unidades = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

    string resultado = miles[numero / 1000] +
                       cientos[(numero % 1000) / 100] +
                       decenas[(numero % 100) / 10] +
                       unidades[numero % 10];

    return resultado;
}
