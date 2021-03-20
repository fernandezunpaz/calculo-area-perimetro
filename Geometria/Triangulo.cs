using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

    public class Triangulo : Figura
    {
        public override void setLados(int lado)
        {
            for (int i = 0; i < 3; i++)
            {
                lados.Add(lado);
            }
        }
        public override double Area()
        {
            return (lados[0] * Altura()) / 2;
        }

        public double Altura()
        {
            return Math.Sqrt(3 * lados[0]) / 2;
        }
    }

}
