List<int> numeros = new List<int>
{    
};

string seguir = "s";

while (seguir == "s")
{
    Console.WriteLine("Escriba un numero");
    int numero = int.Parse(Console.ReadLine());
    numeros.Add(numero);
    Console.WriteLine("¿Desea seguir? (s/n)");
    seguir = Console.ReadLine();

}


var numsElegidos =

from n in numeros

where n > 20
select n;

foreach (var n in numsElegidos)
{
    Console.WriteLine(n);
}
