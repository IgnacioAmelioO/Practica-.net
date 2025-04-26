
int año = int.Parse(Console.ReadLine());

int resultado1 = año % 4;
int resultado2 = año % 100;
int resultado3 = año % 400;

if (resultado1 == 0 && resultado2 != 0)
{
    Console.WriteLine("El año" + año + "es bisiesto");
}
else if (resultado3 == 0)
{
    Console.WriteLine("El año" + año + "es bisiesto");
}
else
{
    Console.WriteLine("El año" + año + "no es bisiesto");
}
