using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises04
{
    internal class ex07
    {
        internal static void Execute()
        {
            Console.Write("Digite o número de linhas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
