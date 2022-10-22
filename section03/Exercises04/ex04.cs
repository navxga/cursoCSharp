using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section03.Exercises04
{
    internal class ex04
    {
        internal static void Execute()
        {
            Console.Write("Digite a quantidade vezes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Números: ");
                string[] nums = Console.ReadLine().Split(' ');

                double a = double.Parse(nums[0]);
                double b = double.Parse(nums[1]);

                if (b != 0)
                {
                    double divisao = a / b;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                } 
                else Console.WriteLine("Divisão impossível");
            }
        }
    }
}
