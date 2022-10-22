using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section03.Exercises03
{
    internal class ex01
    {
        internal static void Execute()
        {
            int senha = 2022;

            Console.Write("Digite a senha: ");
            int digitado = int.Parse(Console.ReadLine());
            while(digitado != senha)
            {
                Console.WriteLine("Senha inválida");
                Console.Write("Tente novamente: ");

                digitado = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
