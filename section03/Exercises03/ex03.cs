using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises03
{
    internal class ex03
    {
        internal static void Execute()
        {
            int op = 1;
            int[] combustiveis = new int[4];

            consulta:
            while (op > 0 && op < 4)
            {
                Console.WriteLine("Digite o combustível abastecido:\n[1] Álcool\n[2] Gasolina\n[3] Diesel");
                op = int.Parse(Console.ReadLine());

                if (op == 1) ++combustiveis[1];

                if (op == 2) ++combustiveis[2];

                if (op == 3) ++combustiveis[3];
            }
            if (op == 4) Console.WriteLine($"MUITO OBRIGADO !\n" +
                $"Álcool: {combustiveis[1]}\n" +
                $"Gasolina: {combustiveis[2]}\n" +
                $"Diesel: {combustiveis[3]}");
            else {
                Console.WriteLine("Código fora da faixa! Digite um código existente.");
                op = 1;
                goto consulta;
            }
        }
    } 
}
