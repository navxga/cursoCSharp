using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises02
{
    internal class ex07
    {
        internal static void Execute()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());


            if (x == 0.0 && y == 0.0) Console.WriteLine("Origem");
            else if (x > 0.0 && y == 0.0) Console.WriteLine("Eixo X");
            else if (x == 0.0 && y > 0.0) Console.WriteLine("Eixo Y");

            else if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");
            else if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");
            else if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");
            else if (x > 0.0 && y < 0.0) Console.WriteLine("Q4");
        }
    }
}
