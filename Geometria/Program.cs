using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {

            //Cuadrado
            Figura cuadrado = new Figura();
            cuadrado.setLados(10);
            Console.WriteLine("El perímetro del cuadrado es: " + cuadrado.Perimetro());
            Console.WriteLine("El área del cuadrado es: " + cuadrado.Area());

            //Rectángulo
            Rectangulo rectuangulo = new Rectangulo();
            rectuangulo.setLados(10, 20);
            Console.WriteLine("El perímetro del rectángulo es: " + rectuangulo.Perimetro());
            Console.WriteLine("El área del rectángulo es: " + rectuangulo.Area());

            //Triángulo
            Triangulo triangulo = new Triangulo();
            triangulo.setLados(10);
            Console.WriteLine("El perímetro del triángulo es: " + triangulo.Perimetro());
            Console.WriteLine("El área del triángulo es: " + triangulo.Area());

            Console.ReadLine();

        }
    }
}
