using OrderSystem.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OrderSystem.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double Total = 0;

            foreach(OrderItem item in OrderItems)
            {
                Total += item.Price;
            }

            return Total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            double tot = 0.0;
            foreach(OrderItem item in OrderItems)
            {
                sb.Append($"{item.Product.Name}, ");
                sb.Append($"{item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
                sb.Append($"Quantity: {item.Quantity}, ");
                sb.AppendLine($"Subtotal: {item.Price.ToString("F2", CultureInfo.InvariantCulture)}");

                tot += item.Price;
            }

            sb.Append($"Total price: {tot}");

            return sb.ToString();
        }
    }
}
