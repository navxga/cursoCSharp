using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Http.Headers;

namespace section03.Exercises04
{
    internal class ex03
    {
        internal static void Execute()
        {
            Console.Write("Digite quantos casos de testes deseja efetuar: ");
            int n = int.Parse(Console.ReadLine());

            double soma = 0;

            double[] media = new double[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    soma += nota;
                }
                media[i] = soma / 3;
                Console.WriteLine("Média: " + media[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
