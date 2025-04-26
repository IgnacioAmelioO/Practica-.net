string[] array;
array = new string[5];
int cantIteraciones = 5;
for (int i = 0; i < cantIteraciones; i++)
{
    array[i] = Console.ReadLine();
}
for (int i = cantIteraciones; i > 0; i--)
{
    Console.WriteLine(array[i]);
}