using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading;

namespace cursoCSharp.section03
{
    class ex002
    {
        static void Main(string[] args)
        {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            // Cardápio
            string itens = " ,Cachorro Quente,X-Salada,X-Bacon,Torrada simples,Refrigerante";
            string[] listaItem = itens.Split(',');

            string precos = " ,4.0,4.5,5.0,2.0,1.5";
            string[] listaPrecos = precos.Split(',');


            // Atendimento
            atendimento:

            Console.Write("Digite o código do seu lanche: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade: ");
            int qtd = int.Parse(Console.ReadLine());


            // Calculo do valor final à pagar
            double valorFinal = Convert.ToDouble(listaPrecos[codigo], provider) * qtd;

            // Conta preparada para pagamento
            if (qtd == 1)
                Console.WriteLine($"{qtd} {listaItem[codigo]} custa R${valorFinal},00");
            else
                Console.WriteLine($"{qtd} {listaItem[codigo]} custam R${valorFinal},00");


            // Pedido finalizado
            Console.WriteLine("Deseja realizar outro pedido? [y/n]: ");
            string op = Console.ReadLine().Trim().ToUpper();

            if (op.Contains('Y')) goto atendimento;
            else 
                Console.WriteLine("Obrigado pela preferência!");
                Thread.Sleep(2000); 
                return;
        }
    }
}