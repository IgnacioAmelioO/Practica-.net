
class Program
{
    static async Task Main()
    {
        
        var progreso = new Progress<int>(porcentaje =>
        {
            Console.WriteLine($"Progreso: {porcentaje}%");
        });

       
        await OperacionLargaConProgresoAsync(progreso);
    }

    static async Task OperacionLargaConProgresoAsync(IProgress<int> progreso)
    {
        const int totalPasos = 10;

        for (int paso = 1; paso <= totalPasos; paso++)
        {
            await Task.Delay(500); 

            int porcentaje = paso * 100 / totalPasos;
            progreso.Report(porcentaje);
        }
    }
}
