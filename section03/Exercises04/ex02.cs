using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises04
{
    internal class ex02
    {
        internal static void Execute()
        {
            Console.Write("Digite o valor: ");
            int n = int.Parse(Console.ReadLine());

            int dentro = 0;
            int fora = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20) dentro += 1;
                else fora += 1;
            }

            Console.WriteLine($"{dentro} in\n{fora} out");
        }
    }
}
