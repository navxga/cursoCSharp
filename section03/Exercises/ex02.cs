using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises
{
    internal class ex02
    {
        internal static void Execute()
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine(n1 % 2 == 0 ? "PAR" : "ÍMPAR");
        }
    }
}
