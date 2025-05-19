

class Program
{
    static async Task Main()
    {
        await ProbarManejoExcepcionesAsync();
        
    }

    static async Task OperacionConErrorAsync()
    {
        Console.WriteLine("Iniciando operación que lanzará error...");
        await Task.Delay(2000);
        Console.WriteLine("Lanzando error...");
        throw new InvalidOperationException("Error simulado en operación asincrónica");
        
    }

    static async Task ProbarManejoExcepcionesAsync()
    {
        try
        {
            await OperacionConErrorAsync();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Excepción capturada: {ex.Message}");
        }
    }
}
