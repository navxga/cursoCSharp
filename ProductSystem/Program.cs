using ProductSystem.Entities;
using System.Globalization;

namespace ProductSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int qtdProducts = int.Parse(Console.ReadLine());

            for (var i = 1; i <= qtdProducts; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, used or imported (C/U/I)? ");
                char status = char.Parse(Console.ReadLine().ToUpper().Trim());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (status == 'C')
                {
                    products.Add(new Product(name, price));
                }
                else if (status == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (status == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    Console.WriteLine("Digite um status existente!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");

            foreach(Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}