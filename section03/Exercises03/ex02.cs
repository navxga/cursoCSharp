using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises03
{
    internal class ex02
    {
        internal static void Execute()
        {
            Console.Write("X = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y = ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0) Console.WriteLine("Primeiro"); break;
                if (x < 0 && y > 0) Console.WriteLine("Primeiro"); break;
                if (x < 0 && y < 0) Console.WriteLine("Primeiro"); break;
                if (x > 0 && y < 0) Console.WriteLine("Primeiro"); break;
            }
        }
    }
}
