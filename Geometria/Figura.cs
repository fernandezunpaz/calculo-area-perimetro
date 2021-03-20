using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{

    public class Figura
    {
        public List<int> lados = new List<int>();
        public virtual void setLados(int lado)
        {
            for (int i = 0; i < 4; i++)
            {
                lados.Add(lado);
            }
        }
        public int Perimetro()
        {
            int perimetro = 0;
            for (int i = 0; i < lados.Count; i++)
            {
                perimetro += lados[i];
            }
            return perimetro;
        }
        public virtual double Area()
        {
            return lados[0] * lados[1];
        }
    }

}
