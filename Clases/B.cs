using static System.Console;
using A;

public class B : Class1
{
    public B() : base(){
        nombreInstancia = "Instancia sin nombre hijo";
        M4();
    }

    private void M4()
    {
        Console.WriteLine("metodo del hijo invocado");
    } 
    
}
