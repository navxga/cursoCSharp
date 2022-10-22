using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section04.Exercises01
{
    class ex03
    {
        internal static void Execute()
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();


            Console.WriteLine($"Área de X: {areaX.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y: {areaY.ToString("F1", CultureInfo.InvariantCulture)}");

            if (areaX > areaY) Console.WriteLine("Maior área: X");
            else Console.WriteLine("Maior área: Y");
        }
    }
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + B) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
