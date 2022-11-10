using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace section05.Exercises01
{
    class exemplo01
    {
        public static void Execute()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();

            Console.Write("Preço: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Produto p = new Produto(Nome, Preco, Quantidade);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();


            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");

            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido do estoque: ");

            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
