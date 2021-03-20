using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

    public class Rectangulo : Figura
    {
        public void setLados(int lado1, int lado2)
        {
            lados.Add(lado1);
            lados.Add(lado1);
            lados.Add(lado2);
            lados.Add(lado2);
        }
        public override double Area()
        {
            int altura = lados[0];
            for (int i = 1; i < lados.Count; i++)
            {
                if (altura != lados[i])
                {
                    return lados[i] * altura;
                }
            }

            return altura * altura;
        }
    }

}
