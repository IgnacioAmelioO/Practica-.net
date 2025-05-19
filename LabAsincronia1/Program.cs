
using System.Diagnostics;

class Program
{
    static async Task Main()
    {
        await CompararSincronoVsAsincrono();
    }

    static void SimularOperacionPesada()
    {
        Thread.Sleep(3000);
    }

    static async Task SimularOperacionPesadaAsync()
    {
        await Task.Delay(3000);
    }

    static async Task CompararSincronoVsAsincrono()
    {
        var tiempotot = new Stopwatch();

        Console.WriteLine("Iniciando operación SINCRÓNICA...");
        tiempotot.Start();
        SimularOperacionPesada();
        tiempotot.Stop();
        Console.WriteLine("Operación SINCRÓNICA finalizada.");
        Console.WriteLine($"Tiempo sincrónico: {tiempotot.ElapsedMilliseconds} ms");

        tiempotot.Reset();
        Console.WriteLine("Iniciando operación ASINCRÓNICA...");
        tiempotot.Start();

        Task tarea = SimularOperacionPesadaAsync();
        Console.WriteLine("Podés escribir algo mientras se ejecuta la tarea:");
        string entradaUsuario = Console.ReadLine();

        await tarea;

        tiempotot.Stop();
        Console.WriteLine("Operación ASINCRÓNICA finalizada.");
        Console.WriteLine($"Entrada del usuario: {entradaUsuario}");
        Console.WriteLine($"Tiempo asincrónico: {tiempotot.ElapsedMilliseconds} ms");
    }
}


