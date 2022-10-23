using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace section04.Exercises01
{
    class ex04
    {
        public static void Execute()
        {
            Produto produto = new Produto();

            // Entrada de dados
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());


            //Saída
            Console.WriteLine($"Dados do produto: {produto}");

            // Adicionar produtos ao estoque
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int add = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(add);



            //Saída
            Console.WriteLine($"Dados atualizados: {produto}");

            // Remover produtos do estoque
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            int remove = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(remove);

            //Saída
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            double tot = Quantidade * Preco;
            return tot;
        }
        public void AdicionarProdutos(int add)
        {
            Quantidade += add;
        }
        public void RemoverProdutos(int remove)
        {
            Quantidade -= remove;
        }

        public override string ToString()
        {
            return $"{Nome}, " +
                $"R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"{Quantidade} unidades, " +
                $"Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
