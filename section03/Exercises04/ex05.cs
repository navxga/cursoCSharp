using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises04
{
    internal class ex05
    {
        internal static void Execute()
        {
            Console.Write("Digite o número: ");
            int num = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine(fatorial);
        }
    }
}
