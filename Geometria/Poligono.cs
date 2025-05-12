using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    internal class Poligono
    {
        public double m_base;

        public double m_altura;

        public void CalcularPerimetro()
        {
            Console.WriteLine("El perimetro es: " + (2 * (m_base + m_altura)));
        }

        public void CalcularSuperficie()
        {
            Console.WriteLine("El sueperficie es: " + (m_base * m_altura));
        }
    }

    internal class Rectangulo : Poligono
    {
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


    }
    internal class Cuadrado : Rectangulo
    {
        public double Lado
        {
            get => default;
            set
            {
                m_base = Double.Parse(Console.ReadLine());
                m_altura = m_base;
            }
        }

    }
}
