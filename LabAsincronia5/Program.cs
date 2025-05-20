class Program
{
    static async Task Main()
    {
        var progreso = new Progress<int>(porcentaje =>
        {
            Console.WriteLine($"Progreso: {porcentaje}%");
        });

        using var cts = new CancellationTokenSource();

        // Lanzar una tarea para cancelar cuando el usuario presione una tecla
        Task.Run(() =>
        {
            Console.WriteLine("Presiona cualquier tecla para cancelar la operación...");
            Console.ReadKey(true);
            cts.Cancel();
        });

        try
        {
            await OperacionCancelableAsync(cts.Token, progreso);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Operación cancelada por el usuario.");
        }
    }

    static async Task OperacionCancelableAsync(CancellationToken token, IProgress<int> progreso)
    {
        const int totalPasos = 10;
        for (int paso = 1; paso <= totalPasos; paso++)
        {
            token.ThrowIfCancellationRequested();
            await Task.Delay(1000, token);
            int porcentaje = paso * 100 / totalPasos;
            progreso.Report(porcentaje);
        }
    }
}
