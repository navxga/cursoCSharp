using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section04.Exercises01
{
    class ex05
    {
        public static void Execute()
        {
            Console.Write("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Circunferência: {Calculadora.Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {Calculadora.Volume(raio).ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Pi: {Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");

            Thread.Sleep(2000);
        }
    }
}
