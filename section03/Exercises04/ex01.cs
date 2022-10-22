using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises04
{
    internal class ex01
    {
        internal static void Execute()
        {
            start:

            Console.Write("Digite o valor: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 1 && x <= 1000)
            {
                for (int i = 1; i <= x; i += 2)
                {
                    Console.WriteLine(i);
                }
            } else
            {
                Console.WriteLine("Digite um valor entre 1 e 1000");
                goto start;
            }
        }
    }
}
