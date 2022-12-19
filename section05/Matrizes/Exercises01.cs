using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace section05.Matrizes
{
    public class Exercise01
    {
        public static void Execute()
        {
            Console.Write("Ordem da matriz: ");

            string[] ordem = Console.ReadLine().Split(' ');
            int m = int.Parse(ordem[0]);
            int n = int.Parse(ordem[1]);

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Qual número deseja? ");
            int searchNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == searchNum)
                    {
                        Console.WriteLine($"Position: {i}, {j}");
                        if (i > 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                        if (j > 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }
                    }
                }
            }
        }
    }
}
