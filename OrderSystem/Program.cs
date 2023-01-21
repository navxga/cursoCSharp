using OrderSystem.Entities;
using OrderSystem.Entities.Enums;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace Section09.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");

            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime clientBirthDate = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());


            Client client = new Client(clientName, clientEmail, clientBirthDate);
            Order order = new Order(DateTime.Now, orderStatus, client);


            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, product);

                order.OrderItems.Add(orderItem);
            }

            Console.WriteLine("Order Summary:");
            Console.WriteLine();
            Console.WriteLine($"Order moment: {order.Moment}");
            Console.WriteLine($"Order status: {order.Status}");
            Console.WriteLine($"Client: {order.Client.Name}");
            Console.WriteLine("Order items:");
            Console.WriteLine(order);
        }
    }
}