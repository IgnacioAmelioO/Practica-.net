string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio","Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
string mes = Console.ReadLine();
for(int i = 0; i < meses.Length; i++)
{
    if (meses[i] == mes)
    {
        Console.WriteLine("El mes " + mes + " es el número " + (i + 1));
        break;
    }
    else if (i == meses.Length - 1)
    {
        Console.WriteLine("El mes no existe");
    }
}
