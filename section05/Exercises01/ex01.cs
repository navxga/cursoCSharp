using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section05.Exercises01
{
    public class ex01
    {
        public static void Execute()
        {
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o número da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial [s/n] ?");
            char depositoInicial = char.Parse(Console.ReadLine().ToLower());

            if (depositoInicial == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine());

                Conta c = new Conta(numero, titular, deposito);
            }
            else
            {
                Conta c = new Conta(numero, titular);
            }

            

            Console.WriteLine("Dados da Conta");
        }
    }
}
