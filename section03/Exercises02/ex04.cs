using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises02
{
    internal class ex04
    {
        internal static void Execute()
        {
            Console.WriteLine("Digite as horas [# #]: ");
            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            } else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            duracao = horaInicial < horaFinal ?
                        horaFinal - horaInicial
                        :
                        24 - horaInicial + horaFinal;

            Console.WriteLine($"O jogo durou {duracao} horas");
        }
    }
}
