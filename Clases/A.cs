using static System.Console;

namespace A
{
    public class Class1
    {
        private string nombreInstancia;

        private void Nombredefecto() {
            nombreInstancia = "Instancia sin nombre";
            M1();
        }
        private void Nombreparam(string nom)
        {
            nombreInstancia = nom;
            M2();
        }
        private void MostrarNombre()
        {
            M3();
            Console.WriteLine(nombreInstancia);
          
        }
        private void M1() 
        {
            Console.WriteLine("se llamo el metodo Nombredefecto");
        }
        private void M2()
        {
            Console.WriteLine("se llamo el metodo Nombreparam");
        }
        private void M3()
        {
            Console.WriteLine("se llamo el metodo MostrarNombre");
        }
    };
        
     
    }




