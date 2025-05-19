
using System.Diagnostics;


class Program
{
    static async Task Main()
    {
        Console.WriteLine("Ejecutando tareas en forma secuencial...");
        await EjecutarTareasSecuencialesAsync();

        Console.WriteLine("\nEjecutando tareas en paralelo...");
        await EjecutarTareasParalelasAsync();
    }

    static async Task OperacionMediaAsync()
    {
        Console.WriteLine("Inicio Operación Media (2s)");
        await Task.Delay(2000);
        Console.WriteLine("Fin Operación Media");
    }

    static async Task OperacionLargaAsync()
    {
        Console.WriteLine("Inicio Operación Larga (3s)");
        await Task.Delay(3000);
        Console.WriteLine("Fin Operación Larga");
    }

    static async Task OperacionCortaAsync()
    {
        Console.WriteLine("Inicio Operación Corta (1s)");
        await Task.Delay(1000);
        Console.WriteLine("Fin Operación Corta");
    }

    static async Task EjecutarTareasSecuencialesAsync()
    {
        var tiempoTot = new Stopwatch();
        tiempoTot.Start();

        await OperacionCortaAsync();
        await OperacionMediaAsync();
        await OperacionLargaAsync();

        tiempoTot.Stop();
        Console.WriteLine($"Tiempo total (secuencial): {tiempoTot.ElapsedMilliseconds} ms");
    }

    static async Task EjecutarTareasParalelasAsync()
    {
        var tiempoTot = new Stopwatch();
        tiempoTot.Start();

        Task t1 = OperacionCortaAsync();
        Task t2 = OperacionMediaAsync();
        Task t3 = OperacionLargaAsync();

        await Task.WhenAll(t1, t2, t3);

        tiempoTot.Stop();
        Console.WriteLine($"Tiempo total (paralelo): {tiempoTot.ElapsedMilliseconds} ms");
    }
}
