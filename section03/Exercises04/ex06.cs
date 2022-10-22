using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises04
{
    internal class ex06
    {
        internal static void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) Console.WriteLine(i);
            }
        }
    }
}
