int[] suma;
int cantidad = int.Parse(Console.ReadLine());
suma = new int[cantidad];
suma[0] = 0;
suma[1] = 1;
int i = 0;
int res = 0;
while (i <= cantidad - 3)
{    
    res = suma[i] + suma[i + 1];
    suma[i + 2] = res;
    i++;
}
for (int j = 0; j < cantidad - 3; j++)
{
    Console.WriteLine(suma[j]);
}