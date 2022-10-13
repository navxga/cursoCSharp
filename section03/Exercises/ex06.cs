using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises
{
    internal class ex06
    {
        internal static void Execute()
        {
            double n = double.Parse(Console.ReadLine());

            if (n < 0.0 || n > 100.00) Console.WriteLine("Fora dos intervalos existentes");

            else if (n <= 25.00) Console.WriteLine("Intervalo [0,25]");

            else if (n <= 50.00) Console.WriteLine("Intervalo [25,50]");

            else if (n <= 75.00) Console.WriteLine("Intervalo [50,75]");

            else Console.WriteLine("Intervalo [75,100]");
        }
    }
}
