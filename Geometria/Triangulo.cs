using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Triangulo
    {
        public double m_base;

        public double m_altura;

        public double m_lado1;

        public double m_lado2;

        public double Base
        {
            get => default;
            set
            {
                m_base = Double.Parse(Console.ReadLine());
            }
        }
        public double Altura
        {
            get => default;
            set
            {
                m_altura = Double.Parse(Console.ReadLine());
            }
        }

        public double Lado1
        {
            get => default;
            set
            {
                m_lado1 = Double.Parse(Console.ReadLine());
            }
        }

        public double Lado2
        {
            get => default;
            set
            {
                m_lado2 = Double.Parse(Console.ReadLine());
            }
        }

        public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro es: " + (m_base * m_lado1 * m_lado2));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("La superficie es: " + (m_base * m_altura) / 2);
        }
    }
}
