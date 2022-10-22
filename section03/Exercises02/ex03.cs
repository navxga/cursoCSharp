using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises02
{
    internal class ex03
    {
        internal static void Execute()
        {
            // Entrada de dados
            Console.Write("Digite um número: ");
            int n1 =  int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());

            // Organizando os números, ordenando do menor para o maior
            List<int> ordem = new List<int>();
            ordem.Add(n1);
            ordem.Add(n2);
            ordem.Sort();

            // Execução
            int valor = ordem[1] % ordem[0];

            // Resposta
            Console.WriteLine(valor == 0 ? $"{ordem[1]} e {ordem[0]} SÃO MÚLTIPLOS" : $"{ordem[1]} e {ordem[0]} NÃO SÃO MÚLTIPLOS");
        }
    }
}
