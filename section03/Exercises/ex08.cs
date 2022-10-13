using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section03.Exercises
{
    internal class ex08
    {
        internal static void Execute ()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario > 0.00 && salario < 2000.00) Console.WriteLine("Isento");
            else if (salario > 2000.01 && salario < 3000.00)
            {
                int IR = 8;
                Console.WriteLine(CalcularDesconto(salario, IR));

            }





        }
        private static double CalcularDesconto(double s, int IR)
        {
            double desconto = s * IR/100;

            return desconto;
        }
    }
}
