namespace Geometria
{
    public class Circulo
    {
        public double m_radio;

        public double Radio
        {
            get => default;
            set
            {
                m_radio = 3.14;
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro es: " + (2 * 3.14 * m_radio));
        }

        public void CalcularSuperfie()
        {
            Console.WriteLine("La superficie es: " + (3.14 * m_radio * m_radio));
        }
    }
}
