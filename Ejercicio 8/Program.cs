Console.WriteLine("La contraseña a ingresar es: Clave123");

for (int intento = 0; intento < 4; intento++)
{
    Console.Write("Ingrese la contraseña: ");
    string clave = Console.ReadLine();
    if (clave == "Clave123")
    {
        Console.WriteLine("Contraseña correcta");
        break;
    }
    else
    {
        if (intento == 3)
        {
            Console.WriteLine("Contraseña incorrecta. Ha agotado los intentos.");
            break;
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Intente nuevamente.");
        }
        
       
    }
}