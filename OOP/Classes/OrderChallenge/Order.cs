using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classes.OrderChallenge
{
    public class Order
    {
        public Client Client { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatusEnum Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatusEnum status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double TotalPrice()
        {
            return Items.Sum(x => x.SubTotal());
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("\nORDER SUMMARY: ");
            sb.AppendLine("Order Moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");

            sb.AppendLine("Order Items:");
            foreach (var item in Items)
            {
                sb.AppendLine($"{item.Product.Name}, ${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity: {item.Quantity}, SubTotal: ${item.SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }

            sb.Append("Total price $" + TotalPrice().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }

    public enum OrderStatusEnum
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
